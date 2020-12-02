using System;
using fightgrid.Models;

namespace fightgrid
{
    public class Arena{ 

        public static int arenaWidth = 3;
        public static int arenaHeight = 3;

        //Messages
        public static string Description ="";
        public static string Description2="";
        public static string Direction="";

        //Collision
        public static void Occupied(){
            Description ="Occupied";
        }
        public static void WallWarn(){
            Description="There's a wall there";
        }
        public static void Empty(){
            Description = "";
        }
        public static void Line2(string desc){
            Description2 = desc;
        }
      
        public static void Arrow(char dir){

            switch(dir){
            //left
                case ('l'):
                     Direction="\u2190";
                     break;
            //up
                case ('u'):
                    Direction="\u2191";
                    break;
            //right
                case ('r'):
                    Direction="\u2192";
                    break;
            //down
                case ('d'):
                    Direction="\u2193";
                    break;
            }

        }
        public static void DrawArena (Fighter Oguy, Fighter Xguy) {

            //draw 2D arr
            Console.Clear();
            Console.SetCursorPosition(0,0);
            string[, ] arenaGrid = new string[, ] { { "*", "*", "*" }, { "*", "*", "*" }, { "*", "*", "*" } };
            int[, ] arenaInt = new int[, ] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } }; //0 is O, 1 is X, 2 is empty
            

            arenaInt[Oguy.Position[0], Oguy.Position[1]] = Oguy.Role;
            arenaInt[Xguy.Position[0], Xguy.Position[1]] = Xguy.Role;

            Console.WriteLine("__________");
            Console.WriteLine ($"| {arenaInt[0,0]} {arenaInt[0,1]} {arenaInt[0,2]} | O:{Oguy.Focus}");
            Console.WriteLine ($"| {arenaInt[1,0]} {arenaInt[1,1]} {arenaInt[1,2]} | X:{Xguy.Focus}");
            Console.WriteLine ($"| {arenaInt[2,0]} {arenaInt[2,1]} {arenaInt[2,2]} | Mode: {Oguy.Mode}");
            Console.WriteLine("__________");
            Console.WriteLine($"Current Phase:{Turn.CurrentPhase}");
            Console.WriteLine($"{Description}");
            Console.Write($"{Direction}");
            Console.WriteLine($"{Description2}");
        }
    }
     
}