/*
 * Description
 * - Manager takes in a grid of Cell objects and runs test to verify
 *   whether or not the cells will live in the next iteration.
 *   It is important to keep track of the past, present, and future.
 *   
 *   Notible steps:
 *   - testGrid is extended in preperation for expansion (increases the array bounds -- expandGrid())
 *   - Assigns a state to the Cells in the testGrid ( countAliveNeighbours() & assignState() )
 *   - If there are dead cells along the outside bounds, Manager will shrink the array (finalizeGrid())
 *   - Once grid is finalized, setGrid will be set to testGrid (finalizeGrid())
 *   
 *   More logic steps must be taken because of the grid's 2-dimensional array structure.
 *  
 */
using System;

namespace GameOfLife
{
    public class Manager
    {
        public Cell[,] setGrid;
        private Cell[,] testGrid; // After test are ran on testGrid, setGrid is then set to testGrid

        public Manager(Cell[,] _inputGrid)
        {
            setGrid = (Cell[,])_inputGrid.Clone();
        }

        public void expandGrid()
        {
            testGrid = new Cell[setGrid.GetLength(0) + 2, setGrid.GetLength(1) + 2];

            // Set perimeter cell objects
            for (int y=0; y < testGrid.GetLength(0); y++)
            {
                testGrid[y, 0] = new Cell(false);
                testGrid[y, testGrid.GetLength(1)-1] = new Cell(false);
            }
            for (int x=0; x < testGrid.GetLength(1); x++)
            {
                testGrid[0, x] = new Cell(false);
                testGrid[testGrid.GetLength(0)-1, x] = new Cell(false);
            }

            // Set input grid in expanded grid
            for (int y=1; y <= setGrid.GetLength(0); y++)
            {
                for (int x=1; x <= setGrid.GetLength(1); x++)
                {
                    testGrid[y, x] = setGrid[y-1,x-1];
                }
            }
        }

        public void countAliveNeighbours()
        {
            int aliveNeighbourCount;
            int yBound;
            int xBound;
            bool[,] neighbourhood;

            for (int y = 0; y < testGrid.GetLength(0); y++)
            {
                for (int x = 0; x < testGrid.GetLength(1); x++)
                {
                    aliveNeighbourCount = 0;
                    neighbourhood = new bool[,] { { true, true, true }, { true, false, true }, { true, true, true } };
                    yBound = 3;
                    xBound = 3;

                    if (y == 0) // no row above expanded grid
                    {
                        neighbourhood.SetValue(false, 0, 0);
                        neighbourhood.SetValue(false, 0, 1);
                        neighbourhood.SetValue(false, 0, 2);
                    }
                    if (y == testGrid.GetLength(0)-1) // no row below expanded grid
                    {
                        neighbourhood.SetValue(false, 2, 0);
                        neighbourhood.SetValue(false, 2, 1);
                        neighbourhood.SetValue(false, 2, 2);
                        yBound = 2;
                    }
                    if (x == 0) // no column on the left
                    {
                        neighbourhood.SetValue(false, 0, 0);
                        neighbourhood.SetValue(false, 1, 0);
                        neighbourhood.SetValue(false, 2, 0);
                    }
                    if (x == testGrid.GetLength(1)-1) // no column to the right
                    {
                        neighbourhood.SetValue(false, 0, 2);
                        neighbourhood.SetValue(false, 1, 2);
                        neighbourhood.SetValue(false, 2, 2);
                        xBound = 2;
                    }

                    // Assess potential neighbours
                    for (int neighbourY = 0; neighbourY < yBound; neighbourY++)
                    {
                        for (int neighbourX = 0; neighbourX < xBound; neighbourX++)
                        {
                            if (neighbourhood[neighbourY, neighbourX])
                            {
                                int row = y + neighbourY -1;
                                int col = x + neighbourX -1;
                                if (testGrid[row, col].CurrentState)
                                {
                                    aliveNeighbourCount++;
                                }
                            }
                        }
                    }

                    testGrid[y, x].AliveNeighbours = aliveNeighbourCount;
                }
            }                
        }

        public void assignState()
        {
            for (int y = 0; y < testGrid.GetLength(0); y++)
            {
                for (int x = 0; x < testGrid.GetLength(1); x++)
                {
                    testGrid[y, x].setNextState();
                }
            }
        }

        public void finalizeGrid()
        {
            //Check to see if any of the perimeter rows have live cells
            //Those rows or columns without alive cells can be omitted

            for (int x = 0; x < testGrid.GetLength(1); x++)
            {
                if (testGrid[testGrid.GetLength(0) - 1, x].CurrentState)
                {
                    // checks bottom row
                    break;
                }
                if (x == testGrid.GetLength(1) - 1)
                {
                    testGrid = ResizeEndArray(testGrid, testGrid.GetLength(0) - 1, testGrid.GetLength(1));
                    if (testGrid.GetLength(0) == 0)
                    {
                        testGrid = ResizeEndArray(testGrid, 0, 0);
                    }
                    x = 0;
                }
            }

            for (int y = 0; y < testGrid.GetLength(0); y++)
            {
                if (testGrid[y, testGrid.GetLength(1)-1].CurrentState)
                {
                    // checks right column
                    break;
                }
                if (y == testGrid.GetLength(0) - 1)
                {
                    testGrid = ResizeEndArray(testGrid, testGrid.GetLength(0), testGrid.GetLength(1) - 1);
                    y = 0;
                }
            }

            for (int x = 0; x < testGrid.GetLength(1); x++)
            {
                if (testGrid[0, x].CurrentState)
                {
                    // checks top row
                    break;
                }
                if (x == testGrid.GetLength(1) - 1)
                {
                    testGrid = ResizeBeginArray(testGrid, testGrid.GetLength(0) - 1, testGrid.GetLength(1));
                    x = 0;
                }
            }

            for (int y = 0; y < testGrid.GetLength(0); y++)
            {
                if (testGrid[y, 0].CurrentState)
                {
                    // checks left column
                    break;
                }
                if (y == testGrid.GetLength(0) - 1)
                {
                    testGrid = ResizeBeginArray(testGrid, testGrid.GetLength(0), testGrid.GetLength(1) - 1);
                    y = 0;
                }
            }
            
            setGrid = testGrid;
            testGrid = null;
        }
        public T[,] ResizeEndArray<T>(T[,] original, int rows, int cols)
        {
            var newArray = new T[rows, cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = original[i, j];
            return newArray;
        }
        public T[,] ResizeBeginArray<T>(T[,] original, int rows, int cols)
        {
            var newArray = new T[rows, cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            int diffCols = original.GetLength(1) - cols;
            int diffRows = original.GetLength(0) - rows;
            for (int y = 0; y < minRows; y++)
                for (int x = 0; x < minCols; x++)
                    newArray[y, x] = original[y + diffRows, x + diffCols];
            return newArray;
        }
    }
}


