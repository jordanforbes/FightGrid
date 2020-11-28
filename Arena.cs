using System;
using fightgrid.Models;

namespace fightgrid
{
    public class Arena{ 
        public static void DrawArena (Fighter Oguy, Fighter Xguy) {

            //draw 2D arr
            string[, ] arenaGrid = new string[, ] { { "*", "*", "*" }, { "*", "*", "*" }, { "*", "*", "*" } };
            int[, ] arenaInt = new int[, ] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } }; //0 is O, 1 is X, 2 is empty

            arenaInt[Oguy.Position[0], Oguy.Position[1]] = Oguy.Role;
            arenaInt[Xguy.Position[0], Xguy.Position[1]] = Xguy.Role;

            Console.WriteLine ($"| {arenaInt[0,0]} {arenaInt[0,1]} {arenaInt[0,2]} | O:{Oguy.Focus}");
            Console.WriteLine ($"| {arenaInt[1,0]} {arenaInt[1,1]} {arenaInt[1,2]} | X:{Xguy.Focus}");
            Console.WriteLine ($"| {arenaInt[2,0]} {arenaInt[2,1]} {arenaInt[2,2]} |");
        }
    }
     
}