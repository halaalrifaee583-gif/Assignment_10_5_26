namespace Delivery_Service
{
    public abstract class Delivery : IDelivery
    {
        public double Distance { get; set; }

        public Delivery(double distance)
        {
            if (distance <= 0)
            {
                throw new Exception("Invalid distance.");
            }

            Distance = distance;
        }

        public abstract double CalculateTime();
    }
}
