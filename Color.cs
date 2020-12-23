using System.Data;
using System.Reflection.Emit;
// using Internal;
using System;

namespace fightgrid {
    public class Color {
        public static void Blue (string text) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine (text);
            Console.ResetColor ();
        }

        public static void BlueWord (string text) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write (text);
            Console.ResetColor ();
        }
        public static void BlueBackWord (string text) {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write (text);
            Console.ResetColor ();
        }

        public static void Cyan (string text) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine (text);
            Console.ResetColor ();
        }

        public static void CyanWord (string text) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write (text);
            Console.ResetColor ();
        }
        public static void CyanBackWord (string text) {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write (text);
            Console.ResetColor ();
        }

        public static void Red (string text) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine (text);
            Console.ResetColor ();
        }

        public static void RedWord (string text) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write (text);
            Console.ResetColor ();
        }

        public static void EnemyName (string text) {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write (text);
            Console.ResetColor ();
        }

        public static void PlayerName (string text) {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write (text);
            Console.ResetColor ();
        }

        public static void EnemyHPColor (string text) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine (text);
            Console.ResetColor ();
        }

        public static void Yellow (string text) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine (text);
            Console.ResetColor ();
        }
        public static void YellowWord (string text) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write (text);
            Console.ResetColor ();
        }

        public static void Green (string text) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine (text);
            Console.ResetColor ();
        }
        public static void GreenWord (string text) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write (text);
            Console.ResetColor ();
        }

    }
}