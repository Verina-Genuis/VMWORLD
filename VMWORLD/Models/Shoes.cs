using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace VMWORLD.Models
{
    public class Shoes:Product
    {
        public  Shoessize Shoessize;
        public  Shoesstyle shoesstyle;
        public  Shoesdesgin Shoesdesgin;
        public Color Shoescolor;
    }
    public enum Shoessize
    {
        none,
        small,
        large
    }
     public enum Shoesstyle
    {
        none,
        heels,
        flat
    }
     public enum Shoesdesgin
    {
        none,
        sneakers,
        formalshoes
    }
   public  enum Shoescolor
    {
        pink,
        blue,
        black,
        brown,
        white
    }
}
