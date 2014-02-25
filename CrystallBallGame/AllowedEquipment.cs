using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystallBallGame
{
    public class AllowedEquipment
    {
        public static AllowedEquipment Elf()
        {
            return new AllowedEquipment(){
                Daggers = true,
                Swords = true,
                Shields = false,
                Armor = true
            };
        }

        public static AllowedEquipment Hobbit()
        {
            return new AllowedEquipment(){
                Daggers = true,
                Swords = false,
                Shields = true,
                Armor = true,
            };
        }

        public static AllowedEquipment Orc()
        {
            return new AllowedEquipment()
            {
                Daggers = false,
                Swords = true,
                Shields = false,
                Armor = true
            };
        }

        public static AllowedEquipment Human()
        {
            return new AllowedEquipment()
            {
                Daggers = true,
                Swords = true,
                Shields = true,
                Armor = true
            };
        }

        public static AllowedEquipment Balrog()
        {
            return new AllowedEquipment()
            {
                Daggers = false,
                Swords = false,
                Shields = false,
                Armor = false
            };
        }

        public bool Daggers { get; set; }
        public bool Swords { get; set; }
        public bool Shields { get; set; }
        public bool Armor { get; set; }
    }
}
