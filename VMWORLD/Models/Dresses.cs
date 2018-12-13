using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace VMWORLD.Models
{
    public class Dresses:Product
    {
        public Dressessize Dressessize;
        public  Dressesstyle Dressesstyle;
        public  Dressesdesgin Dressesdesgin;
        public Color Dressescolor;
    }

    public enum Dressessize
    {
        small,
        medium,
        large
    }
    public enum Dressesstyle
    {
        none,
        shortdress,
        longdress
    }
   public enum Dressesdesgin
    {
        offshoulder,
        promdress,
        eveningdress
    }
   public enum Dressescolor
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
