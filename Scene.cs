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
        private Platform platform9;
        
        

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
        platform9= new Platform();

        platforms.Add(platform);
		platforms.Add(platform2);
		platforms.Add(platform3);
		platforms.Add(platform4);
		platforms.Add(platform5);
		platforms.Add(platform6);
		platforms.Add(platform7);
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
			


			
        
        }
        public void Update() {


            deltaTime= Raylib.GetFrameTime();


            HandleInput(deltaTime);


            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.GRAY);

            player.Draw();

            for (var i = 0; i < platforms.Count; i++) {
			 platforms[i].Draw();
			}
           
            Raylib.DrawRectangle(175,385,64, 15, Color.RED);

            Raylib.EndDrawing();

            /*for (int i = 0; i < platforms.Count; i++) {
					
					if (player.position) 
					{
                        
						platforms.RemoveAt(i);
						
						
							
					}*/
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






        