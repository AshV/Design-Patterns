namespace M_Solution_1
{
    public class AudiCar
    {
        private IGearBox gearBox;
        private IWheel wheels;
        private IStereo stereo;

        public void setGearBox(IGearBox gearBox)
        {
            this.gearBox = gearBox;
        }

        public void setWheels(IWheel wheels)
        {
            this.wheels = wheels;
        }

        public void setStereo(IStereo stereo)
        {
            this.stereo = stereo;
        }

        public override string ToString()
        {
            return "AudiCar [gearBox=" + gearBox + ", wheels=" + wheels + ", stereo=" + stereo + "]";
        }
    }
}