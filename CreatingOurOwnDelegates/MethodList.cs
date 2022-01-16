using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingOurOwnDelegates
{
    class MethodList
    {

        public static void Greet()
        {
            Console.WriteLine($"Greetings from the MethodList!");
        }

        public static void Discuss()
        {
            Console.WriteLine($"The MethodList holds the methods.");
        }

        public static void Dance()
        {
            Console.WriteLine($"Dance to the computer store.");
        }

        //This method makes a reference to the above methods and will be called in the main
        public static void CallMethods()
        {
            List<Action> actions = new List<Action>();

            actions.Add(() => MethodList.Greet());
            actions.Add(() => MethodList.Discuss());
            actions.Add(() => MethodList.Dance());

            foreach (var action in actions)
            {
                action();
            }

            Console.ReadLine();
        }

        
    }
}
