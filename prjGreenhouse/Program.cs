namespace prjGreenhouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating all the devices linked in the network
            Network mainHub = new Network("GreenHouse Hub");

            Network gHouse1 = new Network("FlowerHouse 1");
            Network gHouse2 = new Network("LettuceHouse 2");

            Network tent1 = new Network("Tent A");
            Network tent2 = new Network("Tent B");

            Network ph_Sensor = new Network("ph_Sensor");
            Network temp = new Network("Temp");

            //operator Overload
            mainHub = mainHub + gHouse1;
            mainHub = mainHub + gHouse2;

            gHouse1 = gHouse1 + tent1;
            gHouse2 = gHouse2 + tent2;

            tent1 = tent1 + ph_Sensor;
            tent2 = tent2 + ph_Sensor;

            Console.WriteLine("Search for: ph_sensor, Temp and Tent A");

            while (true)
            {
                Console.WriteLine("\nEnter the name of the device to validate (or type 'exit' to quit): ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    break;
                }
                Console.WriteLine($"\nSearching for '{userInput}'....");
                bool isFound = SearchDevice(mainHub, userInput, " ");

                if (isFound == false)
                {
                    Console.WriteLine($"This {userInput} is nowhere to be found...");
                }
            }
        }
        static bool SearchDevice(Network currentDevice, string targetDeviceName, string currentPath)
        {
            string fullPath = "";

            if (string.IsNullOrEmpty(currentPath))
            {
                fullPath = currentDevice.deviceName;
            }
            else
            {
                fullPath = currentPath + " : " + currentDevice.deviceName;
            }

            if (currentDevice.deviceName.Equals(targetDeviceName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\nDevice Validated");
                Console.WriteLine($"Safe Configuration Path: {fullPath}");

                return true;
            }

            foreach (Network connectedDevice in currentDevice.ConnectedDevices)
            {
                bool foundInConnected = SearchDevice(connectedDevice, targetDeviceName, fullPath);
                if (foundInConnected == false)
                {
                    return true;
                }
            }
            return false;


        }
    }
}
