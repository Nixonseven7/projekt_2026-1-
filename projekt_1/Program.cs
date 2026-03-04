
using Raylib_cs;
using System.Numerics;

public class Program()
{
    public static void Main()
    {
        //start 
        Raylib.InitWindow(1200, 800, "Dazzling Dreams");
        Raylib.SetTargetFPS(60);

        Texture2D Enemy_wiz = Textures.Wiz();
        Rectangle enemyWizRectangle = new(800, 350, Enemy_wiz.Dimensions);


        Texture2D Dude = Textures.Dude();
        Rectangle DudeSpriteSourcef1 = new(0, 0, 64, 64);
        Rectangle DudeSpriteSourcef2 = new(64, 0, 64, 64);
        Rectangle DudeSpriteSourcef3 = new(0, 64, 64, 64);
        Rectangle DudeSpriteDest = new(600, 400, 256, 256);
        Vector2 DudeOrigin = new Vector2(DudeSpriteDest.Width / 2, DudeSpriteDest.Height / 2);
        float DudeRotation = 0;

        while (!Raylib.WindowShouldClose())
        {
            //Input
            if (Raylib.IsKeyPressed(KeyboardKey.Z)) { }
            ;
            if (Raylib.IsKeyPressed(KeyboardKey.X)) { }
            ;
            if (Raylib.IsKeyPressed(KeyboardKey.Period)) { }
            ;
            if (Raylib.IsKeyPressed(KeyboardKey.Minus)) { }
            ;

            //Drawing 
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Gray);


            Raylib.DrawTexturePro(Dude, DudeSpriteSourcef1, DudeSpriteDest, DudeOrigin, DudeRotation, Color.White);
            // Raylib.DrawTexturePro(Dude, DudeSpriteSourcef2, DudeSpriteDest, DudeOrigin, DudeRotation,  Color.White);
            // Raylib.DrawTexturePro(Dude, DudeSpriteSourcef3, DudeSpriteDest, DudeOrigin, DudeRotation,  Color.White);

            Raylib.DrawTexture(Enemy_wiz, (int)enemyWizRectangle.X, (int)enemyWizRectangle.Y, Color.White);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}