using System;
using Raylib_cs;

namespace platformer
{
    public class Program
    {
        public float window_width = 1280;
        public float window_height = 720;
            public static void Main()
            {
                Raylib.InitWindow(1280, 720, "Platformer");

                Scene scene = new Scene();

                while (!Raylib.WindowShouldClose())
                {
                    scene.Update();
                }

                Raylib.CloseWindow();
            }
       
    }
}
