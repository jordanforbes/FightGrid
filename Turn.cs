using System;
using fightgrid.Models;

namespace fightgrid
{
    public class Turn {
        public static int CurrentPhase = 1;
        //0 = start turn 
        //1 = player phase
        //2 = enemy phase
        public static void IncreFocus(Fighter o, Fighter x){
            if(o.Focus <10){
                    o.Focus +=1;
                }
            if(x.Focus <10){
                    x.Focus +=1;
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