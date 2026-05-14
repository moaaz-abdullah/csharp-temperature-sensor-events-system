namespace TemperatureSensor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sensor sensor = new Sensor();
            Display display = new Display();
            Alarm alarm = new Alarm();

            // Subscribtion
            sensor.TemperatureChanged += display.ShowTemperature;
            sensor.TemperatureChanged += alarm.CheckTemperature;

            while (true)
            {
                Console.WriteLine("Modern Temperature System");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1 - Set the temprature  :");
                Console.WriteLine("2 - Set the alarm value :");
                Console.WriteLine("3 - Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Temperature value?");
                        int.TryParse(Console.ReadLine(), out var temperature);
                        sensor.ChangeTemperature(temperature);
                        break;
                    case "2":
                        Console.WriteLine("Alarm value?");
                        int.TryParse(Console.ReadLine(), out var alarmValue);
                        alarm.SetAlarmValue(alarmValue);
                        break;
                    case "3":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Choise, Try once more");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}
