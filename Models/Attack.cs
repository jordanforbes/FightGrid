using System;

namespace fightgrid.Models {
    public class Attack {
        public static void Hit (Fighter target, int Dmg){
            target.Focus -=Dmg;
            Arena.Debug("Player damaged");
        }

        public void Kick (int x, int y, Fighter l, Fighter r, Fighter enemy) {
            if (l.Position[x] > r.Position[x] && l.Position[y] == r.Position[y]) {
                Console.WriteLine ("Kick Connected!");
                enemy.Focus -= 1;
            } else {
                Console.WriteLine ("Missed Kick!");
            }
        }
        public void Punch (int x, int y, Fighter l, Fighter r, Fighter enemy) {
            if (l.Position[x] == r.Position[x] + 1) {
                if (l.Position[y] - 1 <= r.Position[y] && l.Position[y] + 1 >= r.Position[y]) {
                    Arena.Debug ("Punch Connected!");
                    enemy.Focus -= 1;
                } else {
                    Arena.Debug ("Missed Punch!");
                }
            } else {
                Arena.Debug ("Missed Punch!");
            }

        }

    }
}