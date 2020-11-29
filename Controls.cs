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
                case (ConsoleKey.F):
                    if(Oguy.Focus >=2){
                        Oguy.Mode = 'P';
                        Console.WriteLine("Punch Ready");   
                    }else{
                        Console.WriteLine("Can't Punch Yet");
                        Oguy.Mode = 'M';
                    }
                    
                    break;
                //kick mode
                case (ConsoleKey.D):
                    if(Oguy.Focus >=2){
                        Oguy.Mode = 'K';
                        Console.WriteLine("Kick Ready");
                    }else{
                        Console.WriteLine("Can't Kick Yet");
                        Oguy.Mode = 'M';
                    }
                    break;
                //movement mode
                case (ConsoleKey.S):
                    Oguy.Mode = 'M';
                    Console.WriteLine("Movement");
                    break;
                //Arrow keys
                //UP
                case (ConsoleKey.UpArrow):
                    Console.WriteLine ("\u2191");
                    //punch mode
                    if(Oguy.Mode == 'P'){
                        Oguy.Punch (0, 1, Oguy, Xguy, Xguy);
                        Oguy.Mode= 'M';
                        Turn.PhaseShift();
                    //kick mode
                    }else if(Oguy.Mode == 'K'){
                        Oguy.Kick (0,1,Oguy,Xguy,Xguy);
                        Oguy.Mode='M';
                        Turn.PhaseShift();
                    //Movement
                    }else{
                        if (Oguy.Position[0] != 0) {
                             //collision detection with enemy
                            if(Oguy.Position[0]-1==Xguy.Position[0] && Oguy.Position[1] == Xguy.Position[1]){
                                Console.WriteLine("Occupied");
                            }else{
                                Oguy.Position[0] -= 1; //move Up
                                Turn.PhaseShift();
                            }
                        } else {
                            Console.WriteLine ("there's a wall there");
                        }
                    }
                    break;
                    //DOWN
                case (ConsoleKey.DownArrow):
                    Console.WriteLine ("\u2193");
                    //Punch mode
                    if(Oguy.Mode == 'P'){
                        Oguy.Punch (0, 1, Xguy, Oguy, Xguy);
                        Oguy.Mode= 'M';
                        Turn.PhaseShift();
                    //kick mode
                    }else if(Oguy.Mode == 'K'){
                        Oguy.Kick (0, 1, Xguy, Oguy, Xguy);
                        Oguy.Mode='M';
                        Turn.PhaseShift();
                    }else{
                    //Movement
                        if (Oguy.Position[0] != Arena.arenaHeight-1) {
                             //collision detection with enemy
                            if(Oguy.Position[0]+1 ==Xguy.Position[0] && Oguy.Position[1]== Xguy.Position[1]){
                                Console.WriteLine("Occupied");
                            }else{
                                Oguy.Position[0] += 1; //move Down
                                Turn.PhaseShift();
                            }
                        } else {
                            Console.WriteLine ("there's a wall there");
                        }
                    }
                    break;
                    //LEFT
                case (ConsoleKey.LeftArrow):
                    Console.WriteLine ("\u2190");
                     //Punch mode
                    if(Oguy.Mode == 'P'){
                        Oguy.Punch (1, 0, Oguy, Xguy, Xguy);
                        Oguy.Mode= 'M';
                        Turn.PhaseShift();
                    //kick mode
                    }else if(Oguy.Mode == 'K'){
                        Oguy.Kick (1, 0, Oguy, Xguy, Xguy);
                        Oguy.Mode='M';
                        Turn.PhaseShift();
                    //Movement
                    }else{
                        if (Oguy.Position[1] != 0) {
                            //collision detection with enemy
                            if(Oguy.Position[0]==Xguy.Position[0] && Oguy.Position[1]-1 == Xguy.Position[1]){
                                Console.WriteLine("Occupied");
                            }else{
                                Oguy.Position[1] -= 1; //move Left
                                Turn.PhaseShift();
                            }
                        } else {
                            Console.WriteLine ("there's a wall there");
                        }
                    }
                    break;
                //RIGHT
                case (ConsoleKey.RightArrow):
                    Console.WriteLine ("\u2192");
              
                    //Punch mode
                    if(Oguy.Mode == 'P'){
                        Oguy.Punch (1, 0, Xguy, Oguy, Xguy);
                        Oguy.Mode= 'M';
                        Turn.PhaseShift();
                    //kick mode
                    }else if(Oguy.Mode == 'K'){
                        Oguy.Kick (1, 0, Xguy, Oguy, Xguy);
                        Oguy.Mode='M';
                        Turn.PhaseShift();
                    //Movement
                    }else{
                        if (Oguy.Position[1] != Arena.arenaWidth-1) {
                            if(Oguy.Position[0]==Xguy.Position[0] && Oguy.Position[1]+1 == Xguy.Position[1]){
                                Console.WriteLine("Occupied");
                            }else{
                                Oguy.Position[1] += 1; //move Right
                                Turn.PhaseShift();
                            }    
                        } else {
                            Console.WriteLine ("there's a wall there");
                        }
                    }
                    break;
                    
            };

        
            
    }
}
    
}