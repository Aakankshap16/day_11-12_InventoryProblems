using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangement
{
    public class ReadInventory
    {
        public StockInventoryDetails Read(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string json = file.ReadToEnd();      ///read file and store in json///

                    return JsonConvert.DeserializeObject<StockInventoryDetails>(json); ////convert stream of bytes in object///
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
