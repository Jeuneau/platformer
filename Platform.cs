using Raylib_cs;
using System; // Math
using System.Numerics; 




namespace platformer
{

    class Platform {
        
        public Vector2 position;
        public float speed;
        Texture2D texture;
         public Platform()
        {
            //position = new Vector2(100,400);
            speed = 0;
            Image platform = Raylib.LoadImage("Assets/platform.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(platform);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(platform); 
        }

        public void Draw()
        {
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Color.WHITE);
        }
       
    }
}