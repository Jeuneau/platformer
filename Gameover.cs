using System; // Console
using System.Numerics; // Vector2
using Raylib_cs; // Color



namespace platformer
{
   
    class Gameover : Node {
    public Program program = new Program();  
    Texture2D texture;
    
    
        public Gameover() {

            Position = new Vector2(program.window_width / 2, program.window_height / 2);
            Image gameover_ = Raylib.LoadImage("Assets/platformer_gameover.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(gameover_);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(gameover_);
        }

        public void Draw() {
            Raylib.DrawTexture(texture, (int)Position.X, (int)Position.Y, Color.WHITE); 
        }


    }



}