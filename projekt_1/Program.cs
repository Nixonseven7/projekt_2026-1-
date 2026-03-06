
using Dudeclass;
using EnemiesClass;
using Raylib_cs;
using System.Numerics;

public class Program()
{
    public static void Main()
    {
        //start 
        Raylib.InitWindow(1200, 800, "Dazzling Dreams");
        Raylib.SetTargetFPS(60);
        int dudeframe = 0;
        int gobantFrame = 0;


        Texture2D Enemy_wiz = Textures.Wiz();
        Gobant.texture = Textures.ant();
        Dude.texture = Textures.Dude();
        Rectangle enemyWizRectangle = new(800, 350, Enemy_wiz.Dimensions);

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

            int cooldown = 0;
            int velocity = 0;
            int movement = 0;



            dudeframe = Frames.DudeFrames(dudeframe, Dude.texture);
            gobantFrame = Frames.GobantFrames(gobantFrame, Gobant.texture);
            Raylib.DrawTexture(Enemy_wiz, (int)enemyWizRectangle.X, (int)enemyWizRectangle.Y, Color.White);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}