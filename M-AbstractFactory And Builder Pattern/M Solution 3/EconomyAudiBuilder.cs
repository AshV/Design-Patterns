namespace M_Solution_3
{
  public  class EconomyAudiBuilder:AbstractAudiBuilder
    {
        public override IGearBox getGearBox()
        {
            return new EGearBox();
        }

        public override IWheel getWheel()
        {
            return new EWheel();
        }

        public override IStereo getStereo()
        {
            return new EStereo();
        }
    }
}