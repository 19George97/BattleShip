using System.Collections.Generic;

namespace BlueC_Battle
{
    public abstract class BattleShip
    {
        protected IFitInSocket Slot1;
        protected IFitInSocket Slot2;
        protected IFitInSocket Slot3;
        protected IFitInSocket Slot4;
        protected IFitInSocket Slot5;

        protected IEnumerable<ICoordinate> GetCoordinates()
        {
            return new List<ICoordinate>();
        }

        protected int GetMaxX()
        {
            return 100;
        }

        protected int GetMaxY()
        {
            return 100;
        }
    }
}
