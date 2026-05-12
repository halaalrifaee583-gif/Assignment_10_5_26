namespace Delivery_Service
{
    public class Bike : Delivery
    {
        public Bike(double distance) : base(distance) { }

        public override double CalculateTime()
        {
            return Distance * 0.07;
        }
    }
}
