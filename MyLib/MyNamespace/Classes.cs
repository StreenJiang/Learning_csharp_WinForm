using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNamespace {

    public class Vehicle {
        internal string Owner {
            get; set;
        }

        public virtual void Hi() {
            Console.WriteLine("Hi, I'm a Vehicle.");
        }

    }

    public class Car: Vehicle {
        public void PrintOwner() {
            Console.WriteLine("this car belongs to {0}.", Owner);
        }

        public override void Hi() {
            Console.WriteLine("Hi, I'm a car.");
        }
    }
}
