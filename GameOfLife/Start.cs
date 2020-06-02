using System;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }
        private void btn_begin_Click(object sender, EventArgs e)
        {
            BuildInfo bi = new BuildInfo() {
                RandomBuild = false,  
                Width = (int)nud_width.Value,
                Height = (int)nud_height.Value,
                Probability = (double)nud_prob.Value,
                Iterations = (int)nud_turns.Value };
            FrmBuild fb = new FrmBuild(bi);
            fb.ShowDialog();
        }
        private void btn_rdm_begin_Click(object sender, EventArgs e)
        {
            BuildInfo bi = new BuildInfo()
            {
                RandomBuild = true,
                Iterations = (int)nud_turns.Value
            };
            FrmBuild fb = new FrmBuild(bi);
            fb.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "For more information on Conway's Game of Life, please click 'Yes'. ", "About", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                    ) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life");
            }
        }
    }
}
