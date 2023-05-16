using Raylib_cs;
using System; // Math
using System.Numerics; 




namespace platformer
{
   
    class Player {

        int g= 400;
        float jumpSpeed= 350.0f;
        float horSpeed= 200.0f;

        float delta;

        public Vector2 position;
        public float speed;
        public bool canJump;
        int hitObstacle;

        public void Update() {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
			{
				position.X-= horSpeed * delta;
			}

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
			{
				position.X+= horSpeed*delta;
			}

            if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) && canJump)
			{
				speed= -jumpSpeed;
                canJump= false;
			}

            hitObstacle = 0;
           // for(int i=0; i<envItemsLength)
        }





    }

}