using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {

        public Cell(bool state)
        {
            CurrentState = state;
        }

        public void setNextState()
        {
            if (CurrentState && (AliveNeighbours == 2 || AliveNeighbours == 3))
            { CurrentState = true; } 
            else { CurrentState = false; }
            if (!CurrentState && (AliveNeighbours == 3))
                { CurrentState = true; }
        }
        
        public bool CurrentState { get; set; }
        public int AliveNeighbours { get; set; }
    }
}
