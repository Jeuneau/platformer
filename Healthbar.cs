using Raylib_cs;
using System; // Math
using System.Numerics; 


namespace platformer {

    class Healthbar: SpriteNode 
    {
    
   
        Texture2D texture;
        Player player;
    

        public Healthbar(Player player) : base("Assets/Healthbar2.png") 
        {   
            this.player = player;
            Image health = Raylib.LoadImage(base.TextureName);  // Load image data into CPU memory (RAM)
            //TextureName = "Assets/platformer_healthbar.png";
            texture = Raylib.LoadTextureFromImage(health);       // Image converted to texture, GPU memory (RAM -> VRAM)
        // Raylib.UnloadImage(health);
            Position= new Vector2(1700,30);
            TextureSize = new Vector2(5, 5);
            Console.WriteLine(base.TextureSize);
            Pivot = new Vector2(0, 0.5f);
        }

   

        public void ScaleHP() 
        {
            Scale.X = player.hp / 10;
        }

        public void DrawHP()
        {
            ResourceManager resman = ResourceManager.Instance;
            Texture2D texture = resman.GetTexture(TextureName);
            float width = texture.width;
            float height = texture.height;

            // this Entity might not know its Size yet...
            if (TextureSize.X == 0)
            {
                Vector2 size = new Vector2(width, height);
                TextureSize = size;
            }
            // draw the Texture
            Rectangle sourceRect = new Rectangle(0.0f, 0.0f, width, height);
            Rectangle destRect = new Rectangle(WorldPosition.X, WorldPosition.Y, width * Scale.X, height );
            Vector2 pivot = new Vector2(width * Pivot.X * WorldScale.X, height * Pivot.Y * WorldScale.Y);
            float rot = WorldRotation * 180 / (float) Math.PI;
            Raylib.DrawTexturePro(texture, sourceRect, destRect, pivot, rot, Color.GREEN);
        }
    } 
}