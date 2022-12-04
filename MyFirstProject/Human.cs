using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    //this class is a blueprint for a datatype
    internal class Human
    {


        public string Fullname(string firstName, string lastName)
        {
            return $"{firstName}\t{lastName}";
        }

    }
}
