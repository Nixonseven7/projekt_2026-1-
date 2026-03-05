using Raylib_cs;
using System.Numerics;

public class Textures()
{
    public static Texture2D Dude()
    {
        Texture2D Dude = Raylib.LoadTexture(@"Dude.png");
        return Dude;
        
    }
    
    
    public static Texture2D Wiz()
    {
        Texture2D Enemy_wiz = Raylib.LoadTexture(@"enemy_wiz.png");
        return Enemy_wiz;
    }
}