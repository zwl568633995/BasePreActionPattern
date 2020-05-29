using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Struct
{
    public class Action1 : BaseAction<string>
    {
        public Action1()
            :base(null)
        {
            
        }

        protected override bool DoSomething(BaseAction<string> myBase, string request)
        {
            Console.WriteLine("Action1");

            return true;
        }
    }
}
