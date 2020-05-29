using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Struct
{
    public class Action3 : BaseAction<string>
    {
        public Action3()
            :base(new Action2())
        {
            
        }

        protected override bool DoSomething(BaseAction<string> myBase, string request)
        {
            Console.WriteLine("Action3");
            return true;
        }
    }
}
