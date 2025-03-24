using System;
using System.Runtime.Versioning;

namespace Start // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kollision(4, 0, 4, 0, 4, 2, 4, 2);
        }
        static void Kollision(int TopwallY, int BottomWallY, int RightwallY, int LeftwallY, int TopwallX, int BottomWallX, int RightwallX, int LeftwallX)
        {
            if (KollisionY(TopwallY, BottomWallY , TopwallX, BottomWallX) == true)
            {
                if (KollisionX(RightwallY, LeftwallY, RightwallX, LeftwallX) == true)
                {
                    Console.WriteLine("Boom");
                    Console.WriteLine("Hier ist das Volumen des des Schnittes");
                    Console.WriteLine(Volumen(TopwallY, BottomWallY, RightwallY, LeftwallY, TopwallX, BottomWallX, RightwallX, LeftwallX));
                }
                else
                {
                    Console.WriteLine("nicht Boom");
                }
            }
            else
            {
                Console.WriteLine("nicht Boom");
            }
        }
        static Boolean KollisionY(int TopY, int BotY, int Topx, int Botx)
        {
            if (TopY >= Botx & BotY <= Topx)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        static Boolean KollisionX(int RightY, int LeftY, int RightX, int LeftX)
        {
            if (RightY >= LeftX & LeftY <= RightX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int Volumen(int TopwallY, int BottomWallY, int RightwallY, int LeftwallY, int TopwallX, int BottomWallX, int RightwallX, int LeftwallX)
        {
            if (TopwallY > TopwallX)
            {
                int DiffY = TopwallX - BottomWallY;
                if (RightwallY > RightwallX)
                {
                    int DiffX = RightwallX - LeftwallY;
                    return DiffX * DiffY;
                }
                else
                {
                    int DiffX = RightwallY - LeftwallX;
                    return DiffX * DiffY;
                }
            }
            else
            {
                int DiffY = TopwallY - BottomWallX;
                if (RightwallY > RightwallX)
                {
                    int DiffX = RightwallX - LeftwallY;
                    return DiffX * DiffY;
                }
                else
                {
                    int DiffX = RightwallY - LeftwallX;
                    return DiffX * DiffY;
                }
            }

        }
    }
}
