using Raylib_cs;
using System; // Math
using System.Collections.Generic;
using System.Numerics; 

namespace platformer 
{
    public class Coin: Node 
    {
        Texture2D texture;
        public Vector2 position;
        public Platform platform;
        public int coin_width = 40;
        public int coin_height = 40;
        public Coin(Platform p) 
        {
            Image coin = Raylib.LoadImage("Assets/coin.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(coin);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(coin);
            platform = p;
            position.Y = platform.position.Y - platform.platform_height + 28; //magic number!!!!
            position.X = platform.position.X + platform.platform_width/2 - 25; //magic number 
        }

        public void Draw()
        {
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Color.WHITE);
        }
    }
}