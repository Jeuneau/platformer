using System; // Console
using System.Numerics; // Vector2
using Raylib_cs; // Color



namespace platformer 
{
    class Youwin : Node 
    {
        public float window_width = 1920;
        public float window_height = 1080;
        Texture2D texture;
        public Youwin() 
        {
            Position = new Vector2(window_width / 4, window_height / 4);
            Image youwin_ = Raylib.LoadImage("Assets/platformer_YouWon.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(youwin_);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(youwin_);
        }

        public void Draw() {
            Raylib.DrawTexture(texture, (int)Position.X, (int)Position.Y, Color.WHITE); 
        }
    }
}