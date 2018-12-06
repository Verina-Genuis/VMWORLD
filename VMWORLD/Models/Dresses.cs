using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMWORLD.Models
{
    public class Dresses:Product
    {
        public string Dressessize;
        public string Dressesstyle;
        public string Dressesdesgin;
        public string Dressescolor;
    }
    enum Dressessize
    {
        small,
        medium,
        large
    }
    enum Dressesstyle
    {
        none,
        shortdress,
        longdress
    }
    enum Dressesdesgin
    {
        offshoulder,
        promdress,
        eveningdress
    }
    enum Dressescolor
    {
        purple,
        pink,
        white,
        black,
        brown,
        blue,
        babyblue
    }

}
