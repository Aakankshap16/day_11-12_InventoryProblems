using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryMangement
{
      //GIVE STRUCTURE TO JSON FILE
    public class StockInventoryDetails
    {
        public List<Stock1> stock1;
        public List<Stock2> stock2;
        public List<Stock3> stock3;
    }

    public class Stock1
    {
        public string StockNames;
        public int NumberofShare;
        public int SharePrice;
    }

    public class Stock2
    {
        public string StockNames;
        public int NumberofShare;
        public int SharePrice;
    }

    public class Stock3
    {
        public string StockNames;
        public int NumberofShare;
        public int SharePrice;
    }
}
