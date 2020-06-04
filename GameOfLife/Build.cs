using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GameOfLife
{
    public partial class FrmBuild : Form
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        private readonly int[] totalGridVisualTime = { 2000, 3000, 8000 };
        private List<String> TrialMemory;
        private Cell[,] managerStage;
        private BuildInfo bi;
        public FrmBuild(BuildInfo _bi)
        {
            bi = _bi;
            InitializeComponent();
        }
        private void FrmBuild_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            runTrials(bi.Iterations);
        }
        private async void runTrials(int iterations) 
        {
            Manager m;
            if (bi.RandomBuild) { m = new Manager(CreateRandomGrid()); } else { m = new Manager(CreateSetGrid()); };
            TrialMemory = new List<string>();
            
            for (int i = 1; i <= iterations; i++)
            {
                m.expandGrid();
                m.countAliveNeighbours();
                m.assignState();
                m.finalizeGrid();
                managerStage = m.setGrid;
                await Task.Delay(gridTimelapse(iterations));
                pictureBox1.Invalidate();
                commitToMemory(m.setGrid);
            }

            // update controls
            updateModelNumber(TrialMemory.Count - 1);
            txt_model.Enabled = true;
        }
        public Cell[,] CreateSetGrid()
        {
            Cell[,] outputGrid = new Cell[RandomInt(1, bi.Height), RandomInt(1, bi.Width)];

            for (int y = 0; y < outputGrid.GetLength(0); y++)
            {
                for (int x = 0; x < outputGrid.GetLength(1); x++)
                {
                    outputGrid[y, x] = new Cell(RandomBool(bi.Probability));
                }
            }

            return outputGrid;
        }
        public Cell[,] CreateRandomGrid()
        {
            Cell[,] outputGrid = new Cell[RandomInt(1, 50), RandomInt(1, 50)];

            for (int y = 0; y < outputGrid.GetLength(0); y++)
            {
                for (int x = 0; x < outputGrid.GetLength(1); x++)
                {
                    Double randomDouble = (double)RandomInt(1, 99) / 100;
                    outputGrid[y, x] = new Cell(RandomBool(randomDouble));
                }
            }

            return outputGrid;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            button1.Visible = false;

            Graphics g = e.Graphics;
            int gridRowCount = managerStage.GetLength(0);
            int gridColumnCount = managerStage.GetLength(1);
            int cellSize = 20; // default cell size is 15x15px but will reduce if needed           
            autoCellSize(gridRowCount, ref cellSize, this.Size.Height);
            autoCellSize(gridColumnCount, ref cellSize, this.Size.Width);
            pictureBox1.Height = (cellSize * gridRowCount) + 1;
            pictureBox1.Width = (cellSize * gridColumnCount) + 1;
            pictureBox1.Location = new Point(((this.Size.Width - pictureBox1.Width) / 2) - 10, ((this.Size.Height - pictureBox1.Height) / 2) - 10); //location is difficult to map due to variable windows appearance scaling

            Pen p = new Pen(Color.Black);
            SolidBrush myBrush = new SolidBrush(Color.Green);
            
            // Draw live cells
            for (int y = 0; y < gridRowCount; y++)
            {
                for (int x = 0; x < gridColumnCount; x++)
                {
                    if (managerStage[y, x].CurrentState)
                    {
                        g.FillRectangle(myBrush, x * cellSize +2 , y * cellSize +2, cellSize-3, cellSize-3);
                    }
                    
                }
            }

            // Draw Graph
            for (int horiLine = 0; horiLine <= gridRowCount; horiLine++)
            {
                g.DrawLine(p, 0, horiLine * cellSize, gridColumnCount * cellSize, horiLine * cellSize);
            }
            for (int vertLine = 0; vertLine <= gridColumnCount; vertLine++)
            {
                g.DrawLine(p, vertLine * cellSize, 0, vertLine * cellSize, gridRowCount * cellSize);
            }

            // Warn user cells have died
            if (gridRowCount == 0 || gridColumnCount == 0)
            {
                g.DrawString("Sorry, all cells have died...", new Font("Arial", 16), new SolidBrush(Color.Black), pictureBox1.Location);
            }
        }
        private void autoCellSize(int cellCount, ref int cellSize, int formSize)
        {
            while (cellCount * cellSize > formSize * .85)
            {
                cellSize--;
            }
        }
        private void commitToMemory(Cell[,] inputGrid)
        {
            CellGrid cg = new CellGrid();
            cg.SizeX = inputGrid.GetLength(1);
            cg.SizeY = inputGrid.GetLength(0);
            cg.AliveCells = new List<int[]>();
            for (int y = 0; y < cg.SizeY; y++)
            {
                for (int x = 0; x < cg.SizeX; x++)
                {
                    if (managerStage[y, x].CurrentState)
                    {
                        cg.AliveCells.Add(new int[2] {y,x});
                    }
                }
            }
            string json = JsonConvert.SerializeObject(cg);
            TrialMemory.Add(json);
        }
        private void drawGrid(string json) 
        {
            CellGrid cg = JsonConvert.DeserializeObject<CellGrid>(json);
            managerStage = new Cell[cg.SizeY,cg.SizeX];

            foreach (int[] cell in cg.AliveCells)
            {
                managerStage[cell[0], cell[1]] = new Cell(true);
            }

            for (int y=0; y < cg.SizeY; y++)
            {
                for (int x=0; x< cg.SizeX; x++)
                {
                    if (managerStage[y,x] == null)
                    {
                        managerStage[y, x] = new Cell(false);
                    }
                }
            }
            pictureBox1.Invalidate();
        }
        private int gridTimelapse(int iterations)
        {
            int totalInterval = 1;
            if (iterations > 100)
            {
                totalInterval = totalGridVisualTime[2];
            }
            else if (iterations > 20)
            {
                totalInterval = totalGridVisualTime[1];
            }
            else
            {
                totalInterval = totalGridVisualTime[0];
            }
            int indivInterval = totalInterval / iterations;

            return indivInterval;
        }
        public static bool RandomBool(double prob)
        {
            lock (syncLock)
            { // synchronize
                return random.NextDouble() <= prob ? true : false;
            }
        }
        public static int RandomInt(int minValue, int maxValue)
        {
            lock (syncLock)
            {
                return random.Next(minValue, maxValue);
            }
        }
        private void updateModelNumber(int i)
        {
            txt_model.Text = i.ToString();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            drawGrid(TrialMemory[0]);
            updateModelNumber(0);
        }
        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_model.Text, out int model))
            {
                if (model != 0)
                {
                    drawGrid(TrialMemory[model - 1]);
                    updateModelNumber(model - 1);
                }
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_model.Text, out int model))
            {
                if (model != TrialMemory.Count -1)
                {
                    drawGrid(TrialMemory[model + 1]);
                    updateModelNumber(model + 1);
                }
            }
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            drawGrid(TrialMemory[TrialMemory.Count-1]);
            updateModelNumber(TrialMemory.Count - 1);
        }
        private void txt_model_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txt_model.Text, out int model))
                {
                    if (model >= 0 && model < TrialMemory.Count)
                    {
                        drawGrid(TrialMemory[model]);
                    } else
                    {
                        drawGrid(TrialMemory[TrialMemory.Count - 1]);
                    }
                }
            }
        }
    }
}


