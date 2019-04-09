namespace APPPInCSharp_AdapterPattern
{
    public class LightObjectFormAdapter : Switchable
    {
        private Light light = new Light();

        public void TurnOff()
        {
            light.TurnOff();
        }

        public void TurnOn()
        {
            light.TurnOn();
        }
    }
}