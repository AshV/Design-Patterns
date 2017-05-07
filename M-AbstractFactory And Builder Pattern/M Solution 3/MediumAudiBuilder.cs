using System;

namespace M_Solution_3
{
    public class MediumAudiBuilder : AbstractAudiBuilder
    {
        public override IGearBox getGearBox()
        {
            return new MGearBox();
        }

        public override IWheel getWheel()
        {
            return new MWheel();
        }

        public override IStereo getStereo()
        {
            return new MStereo();
        }
    }
}