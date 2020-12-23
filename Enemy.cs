using System;
using System.Net.Mail;
using fightgrid.Models;

namespace fightgrid {
    public class Enemy {

        private static Fighter Oguy = Instance.O;
        private static Fighter Xguy = Instance.X;
        private static char AtkDir;

        public static bool isOccupied (int x, int y) {
            if (x == Oguy.Position[1] && y == Oguy.Position[0]) {
                return true;
            } else {
                return false;
            }
        }
        public static void Atk () {
            //kicklogic
            if (Oguy.Position[0] == Xguy.Position[0]) {
                if (Oguy.Position[1] > Xguy.Position[1]) {
                    Xguy.Mode = 'K';
                    AtkDir = 'd';
                } else {
                    Xguy.Mode = 'K';
                    AtkDir = 'u';
                }
            } else if (Oguy.Position[1] == Xguy.Position[1]) {
                if (Oguy.Position[0] > Xguy.Position[0]) {
                    Xguy.Mode = 'K';
                    AtkDir = 'l';
                } else {
                    Xguy.Mode = 'K';
                    AtkDir = 'r';
                }
            }
            // if(Oguy.Position[0]==Xguy.Position[0] || Oguy.Position[1]==Xguy.Position[1]){
            //     if(Xguy.Mode=='M'){
            //         Xguy.Mode='K'
            //     }else if(Xguy.Mode=='K'){
            //         Attack.Hit(Oguy,2);
            //         Xguy.Focus -=1;
            //     }
            // }else{
            //     Move();
            // }
        }
        //enemy AI
        public static void Move () {
            Random rng = new Random ();
            int action = rng.Next (0, 6);
            Arena.Line2 ($"Enemy X:{Xguy.Position[1]} Enemy Y: {Xguy.Position[0]}");

            switch (action) {
                //0 = up
                case (0):
                    if (Xguy.Position[0] <= 0) {
                        Move ();
                    } else {
                        Arena.Debug ($"{isOccupied (Xguy.Position[1], Xguy.Position[0] - 1)}");
                        if (isOccupied (Xguy.Position[1], Xguy.Position[0] - 1) == true) {
                            Move ();
                        } else {
                            Xguy.Position[0] -= 1;
                        }
                    }
                    break;
                    //1 = down
                case (1):
                    if (Xguy.Position[0] >= 2) {
                        Move ();
                    } else {
                        Arena.Debug ($"{isOccupied (Xguy.Position[1], Xguy.Position[0] + 1)}");
                        if (isOccupied (Xguy.Position[1], Xguy.Position[0] + 1) == true) {
                            Move ();
                        } else {
                            Xguy.Position[0] += 1;
                        }
                    }
                    break;
                    //2 = left
                case (2):
                    if (Xguy.Position[1] <= 0) {
                        Move ();
                    } else {
                        Arena.Debug ($"{isOccupied (Xguy.Position[1] - 1, Xguy.Position[0])}");
                        if (isOccupied (Xguy.Position[1] - 1, Xguy.Position[0]) == true) {
                            Move ();
                        } else {

                            Xguy.Position[1] -= 1;
                        }
                    }
                    break;
                    //3 = right
                case (3):
                    if (Xguy.Position[1] >= 2) {
                        Move ();
                    } else {
                        Arena.Debug ($"{isOccupied (Xguy.Position[1] + 1, Xguy.Position[0])}");
                        if (isOccupied (Xguy.Position[1] + 1, Xguy.Position[0]) == true) {
                            Move ();
                        } else {
                            Xguy.Position[1] += 1;
                        }
                    }
                    break;
                case (4):
                    if (Xguy.Focus < 2) {
                        Move ();
                    } else {
                        Atk ();
                    }
                    break;
            }
            Arena.DrawArena ();
        }
    }

}