using Raylib_cs;

namespace platformer 
{
    public class HUD 
    {
		public int collected_coins = 0;

        public HUD() 
        {
            
        }

        public void ShowScore()
		{		
			Raylib.DrawText("Score: "+ collected_coins, 1800, 60, 20, Color.BLUE);
			
		}
    }
}