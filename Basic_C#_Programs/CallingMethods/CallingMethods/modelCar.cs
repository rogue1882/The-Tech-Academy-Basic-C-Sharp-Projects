using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class modelCar
    {
        public modelCar()
        {
            BlueCarPacks = 10;
            StickerPacks = 20;
            Gluepacks = 2;
        }
        public int BlueCarPacks { get; set; }
        public int StickerPacks { get; set; }
        public int Gluepacks { get; set; }
    }
   
}
