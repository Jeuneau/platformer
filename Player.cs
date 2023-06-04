using Raylib_cs;
using System; // Math
using System.Numerics; 

namespace platformer
{
   
    public class Player {

        
        float jumpSpeed;
        float horSpeed= 200.0f;
        public Vector2 position;
        public Vector2 velocity;
        public float gravity = 50f;
        public float speed;
        public bool isJumping;
        Texture2D texture;
        public float deltaTime;

        bool jump;
        int jumptimer;
        bool collision;
        
        public int playerwidth= 56;
        public int playerheight= 64;
        
        Platform platform= new Platform();

        public Player()
        {
            
            position = new Vector2(175,340);
            speed = 0;
            Image stickman = Raylib.LoadImage("Assets/platformer_stickman_player.png");  // Load image data into CPU memory (RAM)
            texture = Raylib.LoadTextureFromImage(stickman);       // Image converted to texture, GPU memory (RAM -> VRAM)
            Raylib.UnloadImage(stickman);
           
             
            
        }
         
        public void Update() {
         deltaTime= Raylib.GetFrameTime();   
        }

        public void Draw()
        {
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Color.WHITE);
        }

        public void MoveLeft(float deltaTime) {
            position.X -= horSpeed * deltaTime;
        }

        public  void MoveRight(float deltaTime) {
            position.X += horSpeed*deltaTime;
        }

        public void Jump(float deltaTime) {
           
            //speed -= jumpSpeed;
            //position.Y = speed * deltaTime;
           

            if(!isJumping) {

                //jumpSpeed= 2.0f; 
                velocity.Y = -150.0f;
                isJumping = true;
                //jumptimer += 1;
            }

           

            /*if(Scene.collision == true) {
                canJump = false;
                jumptimer = 0;
            }
            if(Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE) && Scene.collision == true) {
                jumptimer = 0;
                canJump = true;
            }
            if(jumptimer < 80) {
                position.Y -= speed;
            }

            else if(Scene.collision == false) {
                position.Y += speed;
                canJump = false;
            }*/
           
        }

      
    }

}