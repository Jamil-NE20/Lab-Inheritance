using System;
using System.Collections.Generic;
using System.Text;

namespace RandomList
{

    public class RandomList : List<string>
    {
        private Random random;

        public string RandomSting()
        {

            int index = random.Next(0, this.Count);
            string element = this[index];
            this.RemoveAt(index);
            return element;

        }
    }
}
