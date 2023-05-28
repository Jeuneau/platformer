using Raylib_cs;
using System; // Math
using System.Numerics; 

namespace platformer
{

    public class Foot {
        Rectangle foot;
        

            public Foot() {
                
                
                
        }

          public void Draw()
        {
            Raylib.DrawRectangle(175,385,64, 15, Color.RED);
        }
    
    }   
}