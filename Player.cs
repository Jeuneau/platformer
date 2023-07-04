using Raylib_cs;
using System; // Math
using System.Numerics; 

namespace platformer
{
   
    public class Player: Node 
    {
        public float window_width = 1920;
        public float window_height = 1080;
        float horSpeed= 400.0f;
        public Vector2 position;
        public Vector2 velocity;
        public float gravity = 520f;
        public float jumpSpeed = -540.0f;
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
                velocity.Y = jumpSpeed;
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

        public void WrapEdges()
		{
			float scr_width = window_width;
			float scr_height = window_height;
			float spr_width = playerwidth;
			float spr_height = playerheight;
            
			if (position.X > scr_width) {
                position.X = 0;
            }
            if (position.X < 0) {
                position.X = scr_width;
            }
            if (position.Y > scr_height) {
                position.Y = 0;
            }
            if (position.Y < 0) {
                position.Y = scr_height;
            }

		

		}

     }

}