using Raylib_cs;
using System; // Math
using System.Numerics; 

namespace platformer
{

    public class Foot {
        /*public int footX = 175;
        public int footY = 385;*/
        public Vector2 position;
        public int foot_width = 64;
        public int foot_height= 15;
        

            public Foot() {
            position= new Vector2(175,385);    
                
                
        }

          public void Draw()
        {
            Raylib.DrawRectangle((int) position.X, (int) position.Y,foot_width, foot_height, Color.RED);
        }
    
    }   
}