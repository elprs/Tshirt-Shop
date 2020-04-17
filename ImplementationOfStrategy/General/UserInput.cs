using System;

namespace ImplementationOfStrategy.GeneralUseItems
{
    class UserInput
    {
        public static int AskNumber()
        {
            //Ask an int from a user
            return Convert.ToInt32(Console.ReadLine());

            //Try catch and negative checks are purposely eliminated for the scope of this assignment.
        }
    }
}
