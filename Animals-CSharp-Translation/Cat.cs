using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_CSharp_Translation
{
    class Cat : Pet, ITalkable
    {
        private int MousesKilled { get; set; }


        public Cat(int mousesKilled, string name):base(name)
        {
            this.MousesKilled = mousesKilled;
        }

        public int GetMousesKilled()
        {
            return MousesKilled;
        }

        public void AddMouse()
        {
            MousesKilled++;
        }

    public String Talk()
        {
            return "Meow";
        }

    override public String ToString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + MousesKilled;
        }
    }
}
