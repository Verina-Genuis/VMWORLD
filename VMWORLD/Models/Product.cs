using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMWORLD.Models
{
    public class Product
    {
        int ID;
        string title;
        double price;
        double taxprice;
        public double stock;
        enum Tshirtstyle 
      {
            None ,
            full ,
            half 

}
        enum Shoesstyle
        {
            none,
            heels,
            flat

        }
        enum Dressesstyle
        {
            none,
            promdress,
            eveningdress


        }
    }
    
}
