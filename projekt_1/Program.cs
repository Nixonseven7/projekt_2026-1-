
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
        int misses = 0;
        int hp = 5;
        int hits = 0;
        int perfects = 0;

        // enemy movement (gobant)
        float gobpositionx = 1400;
        float gobpositiony = 355;
        float sincelast = 0;
        float gobcooldown = 10;
        float gobvelocity = 5;


        // collisions
        Rectangle shield = new Rectangle(560, 360, 10, 60);
        Rectangle duderec = new Rectangle(585, 355, 32, 64);
        Rectangle gobantrec = new Rectangle(gobpositionx, gobpositiony, 32, 64);
        // bool areOverlapping = Raylib.CheckCollisionRecs(duderec, gobantrec);

        while (!Raylib.WindowShouldClose())
        {
            //Input
            // left
            if (Raylib.IsKeyPressed(KeyboardKey.A)) { shield.X = 560; shield.Y = 360; shield.Width = 10; shield.Height = 60; }
            ;
            // up
            if (Raylib.IsKeyPressed(KeyboardKey.S)) { shield.X = 575; shield.Y = 320; shield.Width = 60; shield.Height = 10; }
            ;
            // down
            if (Raylib.IsKeyPressed(KeyboardKey.K)) { shield.X = 575; shield.Y = 440; shield.Width = 60; shield.Height = 10; }
            ;
            // right
            if (Raylib.IsKeyPressed(KeyboardKey.L)) { shield.X = 640; shield.Y = 360; shield.Width = 10; shield.Height = 60; }
            ;


            //Drawing 
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Gray);

            // Draw text
            // Text.Hp();
            // Text.Hits();
            // Text.Perfects();
            // Text.Misses();
            Raylib.DrawText("HP:" + hp.ToString(), 30, 30, 30, Color.Black);
            Raylib.DrawText("Hit:" + hits.ToString(), 120, 30, 30, Color.Black);
            Raylib.DrawText("Miss:" + misses.ToString(), 210, 30, 30, Color.Black);
            Raylib.DrawText("Perfect:" + perfects.ToString(), 320, 30, 30, Color.Black);
            // Raylib.DrawText( areOverlapping.ToString(), 600, 30, 30, Color.Black);


            // enemy movement (gobant)
            sincelast += 1;

            if (sincelast >= gobcooldown)
            {
                gobantrec.X -= gobvelocity;
                sincelast = 0;
            }

            // check gobant collision with dude
            Raylib.DrawRectangleLinesEx(gobantrec, 1, Color.Red);
            Raylib.DrawRectangleLinesEx(duderec, 1, Color.Green);
            bool areOverlapping = Raylib.CheckCollisionRecs(duderec, gobantrec);
            if (areOverlapping == true)
            {
                misses++;
                hp--;

                if (hp <= 0)
                {
                    // you lose

                }
            }


            dudeframe = Frames.DudeFrames(dudeframe, Dude.texture);
            gobantFrame = Frames.GobantFrames(gobantFrame, Gobant.texture, (int)gobantrec.X, (int)gobantrec.Y);
            // Raylib.DrawTexture(Enemy_wiz, (int)enemyWizRectangle.X, (int)enemyWizRectangle.Y, Color.White);
            Raylib.DrawRectangle((int)shield.X, (int)shield.Y, (int)shield.Width, (int)shield.Height, Color.Brown);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}