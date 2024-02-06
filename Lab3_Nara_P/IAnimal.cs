using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Nara_P
{
    public interface IAnimal
    {
        public string IName { get; set; }
        public string IColour { get; set; }  
        public double IHeight { get; set; }
        public int IAge { get; set; }


        void Cry();

    }
}
