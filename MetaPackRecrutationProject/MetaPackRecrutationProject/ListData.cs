using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPackRecrutationProject
{
    public class ListData
    {
        public static List<string> MaineGroupData = new List<string>() {"Pizza" ,"Dodatki Do Pizzy", "Dania Glowne", "Dodatki Do Dan Glownych", "Zupy", "Napoje" };
      
    }
    public class ProductData
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public override string ToString()
        {
            return ProductName + ProductPrice +"zl";
        }

    }
   
        
    
}
