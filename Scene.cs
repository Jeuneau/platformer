using Raylib_cs;
using System; // Math
using System.Numerics; 




namespace platformer
{
    class Scene {
         const int screenwwidth = 800;
         const int screenheight = 450;
         Player player = new Player();
        
         
         

         public void Main() {
            
            player.position= new Vector2(400,280);
            player.speed= 0;
            player.canJump= false;

             Platform[] platforms = {
            new Platform { Rect = new Rectangle(0, 0, 1000, 400), Type = 0, Color = Color.LIGHTGRAY },
            new Platform { Rect = new Rectangle(0, 400, 1000, 200), Type = 1, Color = Color.GRAY },
            new Platform { Rect = new Rectangle(300, 200, 400, 10), Type = 1, Color = Color.GRAY },
            new Platform { Rect = new Rectangle(250, 300, 100, 10), Type = 1, Color = Color.GRAY },
            new Platform { Rect = new Rectangle(650, 300, 100, 10), Type = 1, Color = Color.GRAY }
            
             };

            
           

        }
       
       

      
    }

}