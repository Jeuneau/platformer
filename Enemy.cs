using Raylib_cs;
using System; // Math
using System.Numerics; 

namespace platformer {
    public class Enemy {
        Texture2D texture;
        public Vector2 position;
        public float speed; 
        public float movementrange;
        public bool movingright;
        public float deltaTime = Raylib.GetFrameTime();
        Platform platform;
      
        public Enemy(Platform p) {
            position = p.position;
            Image snowman = Raylib.LoadImage("Assets/snowman_enemy.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(snowman);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(snowman);
            speed = 1.0f;
            movementrange = 5;
            movingright = true; 
            platform  = p;
            
        }

        public void Draw()
        {
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Color.WHITE);
        }

        public void Update() {
            /*if(movingright) {
                position.X += speed * deltaTime;
                if(position.X >= movementrange + platform.platform_width) {
                    position.X = movementrange + platform.platform_width;
                    movingright = false;
                }                
            }
            else {
                position.X -= speed * deltaTime;
                if(position.X <= movementrange) {
                    position.X = movementrange;
                    movingright = true;
                }
            }*/
        }
    }
}