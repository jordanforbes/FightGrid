using System;
using fightgrid.Models;

namespace fightgrid
{
    public class Controls
    {
         public static void Movement (Fighter Oguy, Fighter Xguy, ConsoleKey key) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //MOVEMENT
            switch (key) {
                //punch mode
                case (ConsoleKey.P):
                    Oguy.Mode = 1;
                    break;
                case (ConsoleKey.K):
                    Oguy.Mode =2;
                    break;
                case (ConsoleKey.M):
                    Oguy.Mode = 0;
                    break;
                //UP
                case (ConsoleKey.UpArrow):
                    Console.WriteLine ("\u2191");
                    if (Oguy.Position[0] != 0) {
                        Oguy.Position[0] -= 1; //move Up
                    } else {
                        Console.WriteLine ("there's a wall there");
                    }
                    break;
                    //DOWN
                case (ConsoleKey.DownArrow):
                    Console.WriteLine ("\u2193");
                    if (Oguy.Position[0] != 2) {
                        Oguy.Position[0] += 1; //move Down
                    } else {
                        Console.WriteLine ("there's a wall there");
                    }
                    break;
                    //LEFT
                case (ConsoleKey.LeftArrow):
                    Console.WriteLine ("\u2190");
                    if (Oguy.Position[1] != 0) {
                        Oguy.Position[1] -= 1; //move Left
                    } else {
                        Console.WriteLine ("there's a wall there");
                    }
                    break;
                    //RIGHT
                case (ConsoleKey.RightArrow):
                    Console.WriteLine ("\u2192");
                    if (Oguy.Position[1] != 2) {
                        Oguy.Position[1] += 1; //move Right
                    } else {
                        Console.WriteLine ("there's a wall there");
                    }
                    break;
            };

           

            //ATTACK
            switch (key) {
                //ATTACK UP
                case (ConsoleKey.W):
                    Oguy.Punch (0, 1, Oguy, Xguy, Xguy);
                    break;
                //ATTACK DOWN
                case (ConsoleKey.S):
                    Oguy.Kick (0, 1, Xguy, Oguy, Xguy);
                    break;
                //ATTACK LEFT
                case (ConsoleKey.A):
                    Oguy.Kick (1, 0, Oguy, Xguy, Xguy);
                    break;
                //ATTACK RIGHT
                case (ConsoleKey.D):
                    Oguy.Punch (1, 0, Xguy, Oguy, Xguy);
                    break;
            }
            
    }
}
    
}