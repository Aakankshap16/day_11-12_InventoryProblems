namespace InventoryMangement
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Inventory Managment.");

            string path = "C:\\Users\\ASHISH PANDEY\\source\\repos\\InventoryMangement\\InventoryMangement\\StockInventory.json";
            ReadInventory obj = new ReadInventory();
            StockInventoryDetails data = obj.Read(path);

            Console.WriteLine("Stock 1");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.stock1.Count; i++)
            {
                Console.WriteLine(data.stock1[i].StockNames);
                Console.WriteLine(data.stock1[i].NumberofShare);
                Console.WriteLine(data.stock1[i].SharePrice);

                int val = data.stock1[i].NumberofShare * data.stock1[i].SharePrice;
                Console.WriteLine("The price of {0} for {1} stock is {2}Rs. ", data.stock1[i].StockNames, data.stock1[i].NumberofShare, val);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Stock 2");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.stock2.Count; i++)
            {
                Console.WriteLine(data.stock2[i].StockNames);
                Console.WriteLine(data.stock2[i].NumberofShare);
                Console.WriteLine(data.stock2[i].SharePrice);

                int val = data.stock2[i].NumberofShare * data.stock2[i].SharePrice;
                Console.WriteLine("The price of {0} for {1} stock is {2}Rs. ", data.stock2[i].StockNames, data.stock2[i].NumberofShare, val);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Stock 3");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.stock2.Count; i++)
            {
                Console.WriteLine(data.stock3[i].StockNames);
                Console.WriteLine(data.stock3[i].NumberofShare);
                Console.WriteLine(data.stock3[i].SharePrice);

                int val = data.stock3[i].NumberofShare * data.stock3[i].SharePrice;
                Console.WriteLine("The price of {0} for {1} stock is {2}Rs. ", data.stock3[i].StockNames, data.stock3[i].NumberofShare, val);
            }
            Console.WriteLine("-------------------------------------");
        }

    }
}