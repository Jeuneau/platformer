using Raylib_cs;
using System; // Math
using System.Numerics; 

namespace platformer
{
   
    public class Player {

        
        float jumpSpeed= 350.0f;
        float horSpeed= 200.0f;
        public Vector2 position;
        public float speed;
        public bool canJump;
        Texture2D texture;
        float deltaTime;

        public Player()
        {
            position = new Vector2(400,280);
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
            speed -= jumpSpeed;
            canJump = false;
            position.Y = speed * deltaTime;
           
        }

      
    }

}