using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        // declaration
        static int score;
        static int health;
        static void ShowHud()
        {
            Console.WriteLine("Health =" + health);
        }

        static void TakeDamage(int damage)
        {
            health = health - damage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Methods 2:");
            Console.WriteLine();

            // initialization
            score = 0;
            health = 100;

            ShowHud();
            TakeDamage(10);
            ShowHud();
            TakeDamage(35);
            ShowHud();
            TakeDamage(50);
            ShowHud();


            Console.ReadKey(true); // wait for exit...
        }
    }
}
