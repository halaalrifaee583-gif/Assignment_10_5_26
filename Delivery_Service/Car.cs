namespace Delivery_Service
{
    public class Car : Delivery
    {
        public Car(double distance) : base(distance)
        {
        }

        public override double CalculateTime()
        {
            return Distance * 0.09;
        }
    }
}
