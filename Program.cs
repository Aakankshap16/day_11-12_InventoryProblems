namespace InventoryMangement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\ASHISH PANDEY\\source\\repos\\InventoryMangement\\InventoryMangement\\Inventory.json";
            ReadInventory obj = new ReadInventory();
            InventoryDetails data = obj.Read(path);

            Console.WriteLine("Type of Rice");
            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine(" ------------------------------");
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);
                int val = data.typeOfRice[i].weight * data.typeOfRice[i].price;
               

                Console.Write(" ------------------------------");
            }

            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            Console.WriteLine("Type of Wheat");
            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            for (int i = 0; i < data.typeOfWheat.Count; i++)
            {
                Console.WriteLine(" ------------------------------");
                Console.WriteLine(data.typeOfWheat[i].name);
                Console.WriteLine(data.typeOfWheat[i].weight);
                Console.WriteLine(data.typeOfWheat[i].price);
                int val = data.typeOfWheat[i].weight * data.typeOfWheat[i].price;
                
                Console.WriteLine(" ------------------------------");
            }

            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            Console.WriteLine("Type of Pulses");
            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            for (int i = 0; i < data.typeOfPulses.Count; i++)
            {
                Console.WriteLine(" ------------------------------");
                Console.WriteLine(data.typeOfPulses[i].name);
                Console.WriteLine(data.typeOfPulses[i].weight);
                Console.WriteLine(data.typeOfPulses[i].price);
                int val = data.typeOfPulses[i].weight * data.typeOfPulses[i].price;
                
                Console.WriteLine(" ------------------------------");
            }

        }
    }
}