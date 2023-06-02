using Raylib_cs;
using System; // Math
using System.Numerics; 

namespace platformer {
    public class Enemy {
        Texture2D texture;
        public Vector2 position;

        public Enemy() {
            position = new Vector2(175,340);
            Image snowman = Raylib.LoadImage("Assets/snowman_enemy.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(snowman);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(snowman);
        }

        public void Draw()
        {
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Color.WHITE);
        }
    }
}