using System;
using Raylib_cs;

namespace platformer
{
    static class Program
    {
        public static void Main()
        {
            Raylib.InitWindow(1920, 1080, "Platformer");

            Scene scene = new Scene();

            while (!Raylib.WindowShouldClose())
            {
                scene.Update();
            }

            Raylib.CloseWindow();
        }
       
    }
}
