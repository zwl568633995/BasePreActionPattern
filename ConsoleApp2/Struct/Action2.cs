using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Struct
{
    public class Action2 : BaseAction<string>
    {
        public Action2()
            :base(new Action1())
        {
        }

        protected override bool DoSomething(BaseAction<string> myBase, string request)
        {
            Console.WriteLine("Action2");

            return true;
        }
    }
}
