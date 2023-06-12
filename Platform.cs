using Raylib_cs;
using System; // Math
using System.Numerics; 




namespace platformer
{

    public class Platform: Node {
        
        public Vector2 position;
        public float speed;
        Texture2D texture;
        
        public int platform_width = 200;
        public int platform_height = 78;
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