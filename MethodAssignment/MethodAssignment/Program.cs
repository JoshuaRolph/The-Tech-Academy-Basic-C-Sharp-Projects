using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have run into the German elite!");
            Console.WriteLine("Enter your defense.");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = Math.Defense(defense);
            Console.WriteLine("The enemy hit you with " + enemy_damage + "HP of damage.");
            Console.WriteLine("The medics go on a hunt to find you.");
            Console.WriteLine("Enter your health:");
            int health = Convert.ToInt32(Console.ReadLine());
            int hitpoints = Math.Heal(health);
            Console.WriteLine("The medic found you and healed you for " + hitpoints + "HP.");
            Console.WriteLine("Give 'em Hell Soldier!");
            Console.WriteLine("Enter your strength:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = Math.Attack(strength);
            Console.WriteLine("You struck the enemy with a barrage of bullets and dealt " + damage + " HP to him, \nknocking his helmet off of his head and causing him to lose his balance.");
            Console.ReadLine();
        }
    }
}
