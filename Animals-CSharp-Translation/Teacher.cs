using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_CSharp_Translation
{
    class Teacher: Person, ITalkable
    {
        private int Age { get; set; }

        public Teacher(int age, String name):base(name)
        {
            
            this.Age = age;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            this.Age = age;
        }


    public String Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}
