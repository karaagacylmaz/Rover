using System;

namespace MarsRover
{
    public class Map
    {
        public Map(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width { get; }
        public int Height { get; }
    }
}
