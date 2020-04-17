using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy.GeneralUseItems
{
    class UserInput
    {
        public static int AskNumber()
        {
            //Try catch and negative checks are purposely eliminate for the scope of this assignment 

            //Ask an int from a user
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
