using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
public class Frames()
{
    static int frameTimer = 0;

    public static int DudeFrames(int dudeframe, Texture2D Dude)
    {

        frameTimer++;
        if (frameTimer > 10)
        {
            dudeframe++;
            frameTimer = 0;
        }

        Rectangle DudeSpriteSourcef1 = new(0, 0, 64, 64);
        Rectangle DudeSpriteSourcef2 = new(64, 0, 64, 64);
        Rectangle DudeSpriteSourcef3 = new(0, 64, 64, 64);
        Rectangle DudeSpriteDest = new(600, 400, 256, 256);
        Vector2 DudeOrigin = new Vector2(DudeSpriteDest.Width / 2, DudeSpriteDest.Height / 2);
        float DudeRotation = 0;

        // FRAME: variabel för vilken ruta som ska visas (0-3)
        // BREDD: (i bildrutor) hela bildens bred (128) / enskilda bilden (64)
        // HÖJD: (i bildrutor) hela bildens höjd (128) / enskilda bildens höjd (64)
        /*
            rad = FRAME / HÖJD
            column = FRAME % BREDD
            x = rad * 64
            y = column * 64

            int[] frames = {0,1,2,1}
            
            i++
            i %= frames.Length
            Rektangel src = (x, y, 64, 64)

            DrawTecturePro(bilden, src, dest, osv osv)
        */

        if (dudeframe == 0)
        {
            dudeframe = 60;
            Raylib.DrawTexturePro(Dude, DudeSpriteSourcef1, DudeSpriteDest, DudeOrigin, DudeRotation, Color.White);
        }
        else if (dudeframe > 50)
        {
            Raylib.DrawTexturePro(Dude, DudeSpriteSourcef1, DudeSpriteDest, DudeOrigin, DudeRotation, Color.White);
            dudeframe -= 1;
        }
        else if (dudeframe >= 40 && dudeframe <= 50)
        {
            Raylib.DrawTexturePro(Dude, DudeSpriteSourcef2, DudeSpriteDest, DudeOrigin, DudeRotation, Color.White);
            dudeframe -= 1;
        }
        else if (dudeframe >= 30 && dudeframe <= 40)
        {
            Raylib.DrawTexturePro(Dude, DudeSpriteSourcef3, DudeSpriteDest, DudeOrigin, DudeRotation, Color.White);
            dudeframe -= 1;
        }
        else if (dudeframe >= 20 && dudeframe <= 30)
        {
            Raylib.DrawTexturePro(Dude, DudeSpriteSourcef3, DudeSpriteDest, DudeOrigin, DudeRotation, Color.White);
            dudeframe -= 1;
        }
        else if (dudeframe >= 10 && dudeframe <= 20)
        {
            Raylib.DrawTexturePro(Dude, DudeSpriteSourcef2, DudeSpriteDest, DudeOrigin, DudeRotation, Color.White);
            dudeframe -= 1;
        }
        else if (dudeframe >= 1 && dudeframe <= 10)
        {
            Raylib.DrawTexturePro(Dude, DudeSpriteSourcef1, DudeSpriteDest, DudeOrigin, DudeRotation, Color.White);
            dudeframe -= 1;
        }
        return dudeframe;
    }

    public static int GobantFrames(int gobantFrame, Texture2D Gobant, float x, float y)
    {
        Rectangle GobantSpriteSourcef1 = new(0, 0, 64, 64);
        Rectangle GobantSpriteSourcef2 = new(64, 0, 64, 64);
        Rectangle GobantSpriteSourcef3 = new(0, 64, 64, 64);
        Rectangle GobantSpriteSourcef4 = new(64, 64, 64, 64);
        Rectangle GobantSpriteDest = new(x, y, 128, 128);
        Vector2 GobantOrigin = new Vector2(GobantSpriteDest.Width, GobantSpriteDest.Height);
        float GobantRotation = 0;
        if (gobantFrame == 0)
        {
            gobantFrame = 60;
            Raylib.DrawTexturePro(Gobant, GobantSpriteSourcef1, GobantSpriteDest, GobantOrigin, GobantRotation, Color.White);
        }
        else if (gobantFrame >= 45)
        {
            Raylib.DrawTexturePro(Gobant, GobantSpriteSourcef1, GobantSpriteDest, GobantOrigin, GobantRotation, Color.White);
            gobantFrame -= 1;
        }
        else if (gobantFrame >= 30 && gobantFrame < 45)
        {
            Raylib.DrawTexturePro(Gobant, GobantSpriteSourcef2, GobantSpriteDest, GobantOrigin, GobantRotation, Color.White);
            gobantFrame -= 1;
        }
        else if (gobantFrame >= 15 && gobantFrame < 30)
        {
            Raylib.DrawTexturePro(Gobant, GobantSpriteSourcef3, GobantSpriteDest, GobantOrigin, GobantRotation, Color.White);
            gobantFrame -= 1;
        }
        else if (gobantFrame >= 1 && gobantFrame < 15)
        {
            Raylib.DrawTexturePro(Gobant, GobantSpriteSourcef4, GobantSpriteDest, GobantOrigin, GobantRotation, Color.White);
            gobantFrame -= 1;
        }
        return gobantFrame;

    }

}
