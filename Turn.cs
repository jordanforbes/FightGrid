using System;
using fightgrid.Models;

namespace fightgrid
{
    public class Turn {
        private static Fighter Oguy = Instance.O;
        private static Fighter Xguy = Instance.X;
        public static int CurrentPhase = 1;
        //0 = start turn 
        //1 = player phase
        //2 = enemy phase
        public static void IncreFocus(){
            if(Oguy.Focus <10){
                    Oguy.Focus +=1;
                }
            if(Xguy.Focus <10){
                    Xguy.Focus +=1;
                }
        }

        public static void PhaseShift(){
            // if(CurrentPhase >=2){
            //     CurrentPhase = 0;
            // }else{
            //     CurrentPhase +=1;
            // }
            Arena.DrawArena();
            // Phaser(Fighter Oguy, enemy);
        }
    }
}