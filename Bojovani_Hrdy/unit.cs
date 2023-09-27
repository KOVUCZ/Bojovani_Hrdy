using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Bojovani_Hrdy
{
    public class unit
    {
        //private int hp;
        //public int HP
        //{
        //    get => hp;
        //    private set => Math.Max(Math.Min(value,1000),0);
        //}

        public int HP { get; private set; }
        public int DMG { get; internal set; } = 10;
        public int Angle { get; set; } = 0;
        public int Speed { get; set; } = 0;
        public Rectangle HitBox { get; set; } = new Rectangle();

        public unit(int hp, int dmg)
        {
            HP = hp;
            DMG = dmg;
        }
    }
}
