using Raylib_cs;
using System; // Math
using System.Numerics;
using System.Collections.Generic; 




namespace platformer
{
    public class Scene {
       
        
        float deltaTime;

        Player player = new Player();
        Foot foot = new Foot();
        
        
        
        public List<Enemy> enemies;
        


        public List<Platform> platforms;
        public Platform platform;
        public Platform platform2;
        public Platform platform3;

		public Platform platform4;
		public Platform platform5;

		public Platform platform6;
        public Platform platform7;
        public Platform platform8;
        public Platform platform9;
        
       

        public static bool collision { get; internal set; }

        public Scene() {
        
        Platform platform= new Platform();
        platforms = new List<Platform>();
		platform = new Platform();
		platform2 = new Platform();
		platform3 = new Platform();
		platform4 = new Platform();
		platform5 = new Platform();
		platform6 = new Platform();
		platform7 = new Platform();
		platform8 = new Platform();
        platform9 = new Platform();

        platforms.Add(platform);
		platforms.Add(platform2);
		platforms.Add(platform3);
		platforms.Add(platform4); //enemy
		platforms.Add(platform5); 
		platforms.Add(platform6); //enemy
		platforms.Add(platform7);//enemy
		platforms.Add(platform8);
        platforms.Add(platform9);

        platform.position = new Vector2(100,400);
		platform2.position= new Vector2(50,100);
		platform3.position= new Vector2(500,120);
		platform4.position = new Vector2(950,90);
		platform5.position = new Vector2(1300,160);
		platform6.position = new Vector2(550,600);
		platform7.position= new Vector2(1000,800);
		platform8.position= new Vector2(450,900);
        platform9.position= new Vector2(900,400);

        foot = new Foot();

       
        enemies= new List<Enemy>();
        
        enemies.Add(new Enemy(platform6));
        enemies.Add(new Enemy(platform7));
        enemies.Add(new Enemy(platform4));

       
        
       


        
			
        
        }
        public void Update() {


            deltaTime= Raylib.GetFrameTime();


            HandleInput(deltaTime);


            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.GRAY);

            player.Draw();

            //foot.Draw();

            for (int i = 0; i < platforms.Count; i++) {
			 platforms[i].Draw();
			}

            
            //Jump logic
            player.velocity.Y += player.gravity * deltaTime;
            player.position += player.velocity * deltaTime;

            for (int i = 0; i < platforms.Count; i++) {
                Rectangle player_rec = new Rectangle(player.position.X, player.position.Y, player.playerwidth, player.playerheight);
                Rectangle platform_rec = new Rectangle(platforms[i].position.X, platforms[i].position.Y, platforms[i].platform_width, platforms[i].platform_height);
                    if(Raylib.CheckCollisionRecs(player_rec, platform_rec)) {
                        if(player.velocity.Y > 0) {
                            player.velocity.Y = 0;
                            player.position.Y = platforms[i].position.Y - player.playerheight; //player snapped to platform
                            player.isJumping = false;
                        }
                       
                    }
            }

            if(!player.isJumping && player.velocity.Y == 0) {
                player.isJumping = false;
            }
               
          
                   
                  

           //movement + draw enemies 
            //Move(deltaTime);
            for(int i = 0; i < enemies.Count; i++) {
			    enemies[i].Draw();
                enemies[i].Move(deltaTime);
            }
			
            
            Raylib.EndDrawing();

           
        }


        public void HandleInput(float deltaTime)
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
			{
                player.MoveLeft(deltaTime);
			}

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
			{ 
                player.MoveRight(deltaTime);
			}

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
			{
                player.Jump(deltaTime);
			}
        }

        	private float CalculateDistance(Vector2 a, Vector2 b)
        {
            return Vector2.Distance(a, b);
        }

         
            
            
                
        
                   
    }
}
     







        