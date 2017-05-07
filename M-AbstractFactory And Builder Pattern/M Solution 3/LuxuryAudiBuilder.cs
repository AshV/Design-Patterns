namespace M_Solution_3
{
   public class LuxuryAudiBuilder:AbstractAudiBuilder
    {
        public override IGearBox getGearBox()
        {
            return new LGearBox();
        }

        public override IWheel getWheel()
        {
            return new LWheel();
        }

        public override IStereo getStereo()
        {
            return new LStereo();
        }
    }
}