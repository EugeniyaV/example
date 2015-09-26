using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch2
{
    public class SpCar : Car
    {
        public string GetPetName()
        {
            petName = "Fred";
            return petName;
        }
    }
}
