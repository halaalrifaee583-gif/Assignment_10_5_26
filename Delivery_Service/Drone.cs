namespace Delivery_Service
{
    public class Drone : Delivery
    {
        public Drone(double distance) : base(distance )
        {
        }

        public override double CalculateTime()
        {
            return Distance * 0.05;
        }
    }
}
