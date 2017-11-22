using System;
using System.Collections.Generic;
using System.Text;
using BlueC_Battle;

namespace jozi0012
{
    public class Ship: BattleShip
    {
        public Ship()
        {
            this.Slot1 = new DingesFireDragonn();
            this.Slot2 = new DingesFireDragonn();
            this.Slot3 = new Goalkeeper();
        }
    }
}
