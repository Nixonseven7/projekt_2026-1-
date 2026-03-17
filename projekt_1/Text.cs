using Raylib_cs;
using System.Numerics;
public class Text()
{
    static int misses = 0;
    static int perfects = 0;
    static int hits = 0;
    static int hp = 5;
     public static int Hp()
    {

            {
            Raylib.DrawText("HP:" + hp.ToString(), 30, 30, 30, Color.Black);
            }
            return hp;
    }


}