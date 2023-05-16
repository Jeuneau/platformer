using Raylib_cs;
using System; // Math
using System.Numerics; 




namespace platformer
{

    class Platform {
        Rectangle rect;
        int blocking;
        Color color;

        public Rectangle Rect { get; internal set; }
        public int Type { get; internal set; }
        public object Color { get; internal set; }
    }
}