using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMWORLD.Models
{
    public class Tshirt:Product
    {
        public string Tshirtsize;
        public string Tshirtstyle;
        public string TshirtDesgin;
        public string Tshirtcolor;
    }
    enum Tshirtsize
    {
        small,
        medium,
        large
    }
    enum Tshirtstyle
    {
        None,
        full,
        half
    }
    enum TshirtDesgin
    {
        none,
        offshoulder,
        casual  
    }
    enum Tshirtcolor
    {
        pink,
        black,
        white,
        brown,
        blue,
        green,
        yellow
    }

}
