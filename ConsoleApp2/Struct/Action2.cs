using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Struct
{
    public class Action2 : BaseAction<string>
    {
        public int RecordID = 0;
        public Action2()
            :base(new Action1())
        {
        }

        protected override bool DoSomething(BaseAction<string> myBase, string request)
        {
            if (myBase is Action1 action1)
            {
                RecordID=action1.RecordID;
            }

            Console.WriteLine("Action2");

            return true;
        }
    }
}
