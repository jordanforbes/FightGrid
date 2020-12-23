using System;
using fightgrid.Models;

namespace fightgrid
{
    public class Arena{ 

        public static int arenaWidth = 3;
        public static int arenaHeight = 3;
        private static Fighter Oguy = Instance.O;
        private static Fighter Xguy = Instance.X;

        //Messages
        public static string Description ="";
        public static string Description2="";
        public static string Direction="";
       

        //debug
        public static string DebugMsg ="";

        public static int currPhase=0;

        //Collision
        public static void Occupied(){
            Description ="Occupied";
        }
        public static void Desc(string desc){
            Description = desc;
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
        public static int GetPhase(){
            currPhase=Turn.CurrentPhase;
            return currPhase;
        }
        public static void Debug(string msg){
            DebugMsg=msg;
        }
         public static void DebugL(string msg){
            DebugMsg+=" "+msg;
        }
        public static void clearDebug(){
            DebugMsg="";
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
        public static void DrawArena () {

            //draw 2D arr
            Console.Clear();
            Console.SetCursorPosition(0,0);
            string[, ] arenaGrid = new string[, ] { { "*", "*", "*" }, { "*", "*", "*" }, { "*", "*", "*" } };
            double[, ] arenaDouble = new double[, ] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } }; //0 is O, 1 is X, 2 is empty
            

            arenaDouble[Oguy.Position[0], Oguy.Position[1]] = Oguy.Role;
            arenaDouble[Xguy.Position[0], Xguy.Position[1]] = Xguy.Role;

            Console.WriteLine(processArena(arenaDouble));
            Console.WriteLine("__________");
            // Console.WriteLine($"{processRow(arenaDouble[0])}");
            Console.WriteLine ($"| {processTile(arenaDouble[0,0])} {arenaDouble[0,1]} {arenaDouble[0,2]} | O:{Oguy.Focus}");
            Console.WriteLine ($"| {arenaDouble[1,0]} {arenaDouble[1,1]} {arenaDouble[1,2]} | X:{Xguy.Focus}");
            Console.WriteLine ($"| {arenaDouble[2,0]} {arenaDouble[2,1]} {arenaDouble[2,2]} | Mode: {Oguy.Mode}");
            Console.WriteLine($"Player X:{Instance.O.Position[1]}, Y:{Instance.O.Position[0]}");
            Console.WriteLine($"Enemy X:{Instance.X.Position[1]}, Y:{Instance.X.Position[0]}");
            Console.WriteLine($"Current Phase:{GetPhase()}");
            // Console.WriteLine($"{Description}");
            Console.Write($"{Direction}");
            Console.WriteLine($"{Description2}");
            Console.WriteLine($"Debug: {DebugMsg}");
        }

        public static String processTile(double tile){
            if(tile == 0){
                return "O";
            }else if(tile == 1){
                return "X";
            }else{
                return "#";
            }
        }

        public static String processRow(double[] row){
            // foreach()
            String finRow="";
            foreach (int tile in row)
            {
             finRow+= processTile(tile);

            }
            return finRow;
        }
        public static String processArena(double[,] arena){
            // foreach(int[] row in arena){

            // }
            var row = arena.Slice (0);
            foreach(e in row){
                Console.WriteLine(row);
            }
            // for(int i = 0; i<3; i++){
            //     processRow(arena[i,]);
            // }
            return "called";
        }
    
    }
     
}