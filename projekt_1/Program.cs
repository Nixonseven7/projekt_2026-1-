using Raylib_cs;
using System.Numerics;

class Program
{
    static void Main()
    {
        //start 
        Raylib.InitWindow(800, 450, "Dazzling Dreamers");
        Raylib.SetTargetFPS(60);


        while (!Raylib.WindowShouldClose())
        {
            //Input
            if (Raylib.IsKeyPressed(KeyboardKey.Z)) ;
            if (Raylib.IsKeyPressed(KeyboardKey.X)) ;
            if (Raylib.IsKeyPressed(KeyboardKey.Period)) ;
            if (Raylib.IsKeyPressed(KeyboardKey.Minus)) ;

            //Drawing 
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Brown);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}
