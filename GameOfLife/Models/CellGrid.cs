using System;
using System.Collections.Generic;


namespace GameOfLife
{
    public class CellGrid
    {
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public List<int[]> AliveCells {get;set;}
    }
}
