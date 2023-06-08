using Raylib_cs;
using System; // Math
using System.Numerics; 


namespace platformer;

public class Healthbar {
private int health;
Vector2 position;
Vector2 pivot;
Texture2D texture;




     public Healthbar()
    {
       
        position= new Vector2(1000,1000);
        pivot= new Vector2(0,0);
        Image health = Raylib.LoadImage("Assets/player_health.png");  // Load image data into CPU memory (RAM)
        texture = Raylib.LoadTextureFromImage(health);       // Image converted to texture, GPU memory (RAM -> VRAM)
        Raylib.UnloadImage(health);
    }

    public void Draw()
        {
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Color.WHITE);
        }

    void Update() {
    
    }


    

}