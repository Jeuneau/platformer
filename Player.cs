using Raylib_cs;
using System; // Math
using System.Numerics; 

namespace platformer
{
   
    public class Player: Node 
    {

        float horSpeed= 300.0f;
        public Vector2 position;
        public Vector2 velocity;
        public float gravity = 180f;
        public float speed;
        public bool isJumping;
        Texture2D texture;
        public float deltaTime;
        public int playerwidth= 56;
        public int playerheight= 64;
        
        public float hp = 100.0f;
        
       

        public Player()
        {
            
            position = new Vector2(175,340);
            speed = 0;
            Image stickman = Raylib.LoadImage("Assets/platformer_stickman_player.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(stickman);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(stickman);
           
             
            
        }

        public void Draw()
        {
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Color.WHITE);
        }

        public void MoveLeft(float deltaTime) 
        {
            position.X -= horSpeed * deltaTime;
        }

        public  void MoveRight(float deltaTime) 
        {
            position.X += horSpeed * deltaTime;
        }

        public void Jump(float deltaTime) 
        {
           
            if(!isJumping) {
                velocity.Y = -400.0f;
                isJumping = true;
            }
        }

        public void Damage() 
        {
          hp -= 0.03f;
        }

        public bool IsAlive() 
        {
			if (hp <= 0) {
				return false;
			}
			return true;
			
		}

     }

}