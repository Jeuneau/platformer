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
        public Platform platform;    
        
      
        public Enemy(Platform p) {
            
            Image snowman = Raylib.LoadImage("Assets/snowman_enemy.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(snowman);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(snowman);
            speed = 30.0f;
            movingright = true; 
            platform = p;
            position.Y = platform.position.Y - platform.platform_height + 12; //magic number!!!!
            position.X = platform.position.X;


        
        }

        public void Draw()
        {
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Color.WHITE);
        }

        public void Move(float deltaTime) {
            if(movingright) {
               position.X += speed * deltaTime;
                float rightside = platform.position.X + platform.platform_width;
                if(position.X >= rightside - enemywidth) {
                    movingright = false;
                } 
            }
            else {
                position.X -= speed * deltaTime;
                float leftside = platform.position.X;
                if(position.X <= leftside) {
                    movingright= true;
                }
            }
                
            
            /*if (movingright)
                {
                    position.X += speed * deltaTime;   
                            if (position.X >= movementrange + 200 - enemywidth)
                            {
                                position.X = movementrange + 200 - enemywidth;
                                movingright = false; // Change direction when reaching the range limit
                            }
                }   
                else
                {
                   position.X -= speed * deltaTime;
                    if (position.X <= movementrange)
                    {
                       position.X = movementrange;
                        movingright = true; // Change direction when reaching the range limit
                    }
                }
                */
        }
       
    }
}

    
    
