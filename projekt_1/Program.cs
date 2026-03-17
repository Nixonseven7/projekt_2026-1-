
using Dudeclass;
using EnemiesClass;
using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

public class Program()
{
    public static void Main()
    {
        // start 
        Raylib.InitWindow(1200, 800, "Dazzling Dreams");
        Raylib.SetTargetFPS(60);

        // Textures 
        Texture2D Enemy_wiz = Textures.Wiz();
        Gobant.texture = Textures.ant();
        Dude.texture = Textures.Dude();
        Rectangle enemyWizRectangle = new(800, 350, Enemy_wiz.Dimensions);
        int dudeframe = 0;
        int gobantFrame = 0;

        // Miss/hit count
        // int misses = 0;
        // int hp = 5;
        // int hits = 0;
        // int perfects = 0;

        // enemy movement (gobant)
        float gobpositionx = 1200;
        float gobpositiony = 470;
        float sincelast = 0;
        float gobcooldown = 10;
        float gobvelocity = 5;


        // collisions
        Rectangle duderec = new Rectangle(600, 400, 256, 256);
        Rectangle gobantrec = new Rectangle(gobpositionx, gobpositiony, 128, 128);

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

            // Draw text
            // Raylib.DrawText("HP:" + hp.ToString(), 40, 40, 32, Color.Black);
            Text.Hp();


            // enemy movement (gobant)
            sincelast += 1;

            if (sincelast >= gobcooldown)
            {
                gobpositionx -= gobvelocity;
                sincelast = 0;
            }

            // check gobant collision with dude
            // bool areOverlapping = Raylib.CheckCollisionRecs(duderec, gobantrec);
            // if (areOverlapping == true)
            // {
            //     misses++;
            //     hp--;

            //     if (hp <= 0)
            //     {
            //         // you lose

            //     }
            // }


            dudeframe = Frames.DudeFrames(dudeframe, Dude.texture);
            gobantFrame = Frames.GobantFrames(gobantFrame, Gobant.texture, gobpositionx, gobpositiony);
            Raylib.DrawTexture(Enemy_wiz, (int)enemyWizRectangle.X, (int)enemyWizRectangle.Y, Color.White);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}