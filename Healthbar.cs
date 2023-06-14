using Raylib_cs;
using System; // Math
using System.Numerics; 


namespace platformer;

public class Healthbar: Node {
    public float hp = 100;
    Vector2 pivot;
    Texture2D texture;

    public Healthbar()
    {
       
        //Position= new Vector2(1700,30);
        pivot = new Vector2(0, 0.5f);
        Image health = Raylib.LoadImage("Assets/platformer_healthbar.png");  // Load image data into CPU memory (RAM)
        
        texture = Raylib.LoadTextureFromImage(health);       // Image converted to texture, GPU memory (RAM -> VRAM)
        Raylib.UnloadImage(health);
    }

    public void Draw()
    {
        float width = texture.width;
        float height = texture.height;

        // draw the Texture
        Rectangle sourceRect = new Rectangle(0.0f, 0.0f, width, height);
        Rectangle destRect = new Rectangle(WorldPosition.X, WorldPosition.Y, width * Scale.X, height);
        //Vector2 pivot = new Vector2(width * pivot.X * WorldScale.X, height * pivot.Y * WorldScale.Y);
        float rot = WorldRotation * 180 / (float) Math.PI;
        Raylib.DrawTexturePro(texture, sourceRect, destRect, pivot, rot, Color.WHITE);
        Console.WriteLine(hp);
    }

    public void ScaleHP() {
        Scale.X = hp / 10;
    }


    

}