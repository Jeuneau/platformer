using Raylib_cs;

namespace platformer
{
    static class Program
    {
        public static void Main()
        {
            Raylib.InitWindow(800, 480, "Platformer");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GRAY);

                //Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
