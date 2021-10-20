using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_CSharp_Translation
{
    class Dog : Pet, ITalkable
    {
        private bool Friendly { get; set; }

        public Dog(bool friendly, String name):base(name)
        {
            this.Friendly = friendly;
        }

        public bool IsFriendly()
        {
            return Friendly;
        }

        
    public String Talk()
        {
            return "Bark";
        }

        
    override public String ToString()
        {
            return "Dog: " + "name=" + Name + " friendly=" + Friendly;
        }
    }
}
