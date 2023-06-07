using Raylib_cs;
using System; // Math
using System.Collections.Generic;
using System.Numerics; 

namespace platformer {
    public class Enemy {
        Texture2D texture;
        public Vector2 position;
        public float speed; 
        public float movementrange;
        public bool movingright;
        public int enemywidth= 64;
        public int enemyheight= 66;
        
      
        public Enemy(Platform platform) {
            Image snowman = Raylib.LoadImage("Assets/snowman_enemy.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(snowman);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(snowman);
            speed = 30.0f;
            movementrange = 3;
            movingright = true; 
            position.Y = platform.position.Y - platform.platform_height + 12;
        
        }

        public void Draw()
        {
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Color.WHITE);
        }

       
    }
}

    
    
