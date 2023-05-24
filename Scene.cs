using Raylib_cs;
using System; // Math
using System.Numerics;
using System.Collections.Generic; 




namespace platformer
{
    class Scene {
       
        
        float deltaTime;

        Player player = new Player();

        List<Platform> platforms;
        private Platform platform;
        private Platform platform2;
        private Platform platform3;

		private Platform platform4;
		private Platform platform5;

		private Platform platform6;
        private Platform platform7;
        private Platform platform8;
        private int i;


        public Scene() {
        
        Platform platform= new Platform();
        platforms= new List<Platform>();
		platform= new Platform();
		platform2= new Platform();
		platform3= new Platform();
		platform4= new Platform();
		platform5= new Platform();
		platform6= new Platform();
		platform7= new Platform();
		platform8= new Platform();

        platforms.Add(platform);
		platforms.Add(platform2);
		platforms.Add(platform3);
		platforms.Add(platform4);
		platforms.Add(platform5);
		platforms.Add(platform6);
		platforms.Add(platform7);
		platforms.Add(platform8);

        platform.position = new Vector2(100,400);
		platform2.position= new Vector2(100,400);
		platform3.position= new Vector2(100,400);
		platform4.position = new Vector2(100,400);
		platform5.position = new Vector2(100,400);
		platform6.position = new Vector2(100,400);
		platform7.position= new Vector2(100,400);
		platform8.position= new Vector2(100,400);
			


			
        
        }
        public void Update() {

            deltaTime= Raylib.GetFrameTime();


            HandleInput(deltaTime);


            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.GRAY);

            player.Draw();
            platforms[i].Draw();

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
                   
    }
     
}






        