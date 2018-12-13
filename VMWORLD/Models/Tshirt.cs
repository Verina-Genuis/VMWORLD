using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace VMWORLD.Models
{
    public class Tshirt:Product
    {
        public  Tshirtsize Tshirtsize;
        public  Tshirtstyle Tshirtstyle;
        public  TshirtDesgin TshirtDesgin;
        public  Color Tshirtcolor;
    }
   public enum Tshirtsize
    {
        small,
        medium,
        large
    }
    public enum Tshirtstyle
    {
        None,
        full,
        half
    }
    public enum TshirtDesgin
    {
        none,
        offshoulder,
        casual  
    }
   public enum Tshirtcolor
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
