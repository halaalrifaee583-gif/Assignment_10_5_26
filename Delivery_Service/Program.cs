using Delivery_Service;

Console.WriteLine("Enter Delivery Type (1 - Drone, 2 - Car, 3 - Bike):");

int choice = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Distance (Km): ");
double distance = Convert.ToDouble(Console.ReadLine());

Delivery delivery;

switch (choice)
{
    case 1:
        delivery = new Drone(distance);
        break;

    case 2:
        delivery = new Car(distance);
        break;

    case 3:
        delivery = new Bike(distance);
        break;

    default:
        Console.WriteLine("Invalid delivery type.");
        return;
}

double EstimatedTime = delivery.CalculateTime();

TimeSpan time = TimeSpan.FromHours(EstimatedTime);

Console.WriteLine($"Delivery Estimated Time is: {time.ToString(@"hh\:mm")}");