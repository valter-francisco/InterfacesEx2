using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEx2
{
    class Animal : IAnimal
    {
        public string species { get; set; }

        public string talk { get; set; }

        public void Talk()
        {
            Console.WriteLine("The {0} goes {1}!", this.species, this.talk);
        }
    }
}
