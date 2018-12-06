using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMWORLD.Models
{
    public class Shoes:Product
    {
        public string Shoessize;
        public string Shoesstyle;
        public string Shoesdesgin;
        public string Shoescolor;
    }
    enum Shoessize
    {
        none,
        small,
        large
    }
    enum Shoesstyle
    {
        none,
        heels,
        flat
    }
    enum Shoesdesgin
    {
        none,
        sneakers,
        formalshoes
    }
    enum Shoescolor
    {
        pink,
        blue,
        black,
        brown,
        white
    }
}
