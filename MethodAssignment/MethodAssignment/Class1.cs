using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
   public class Math
    {
// Create three methods that take one integer paramater and return an integer //
        public static int Heal(int health)
        {
            int hitpoints = health + 30;
            return hitpoints;
        }
        public static int Defense(int defense)
        {
            int enemy = 30;
            int enemy_str = 15;
            int gun_sm = 7;
            int knife = 2;
            int damage = (enemy_str + (gun_sm + knife) - enemy);
            return damage;
        }
        public static int Attack(int strength)
        {
            int enemy = 30;
            int enemy_def = 8;
            int gun_def = 10;
            int damage = (strength + (gun_def + enemy) - enemy_def);
            return damage;
        }
    }
}
