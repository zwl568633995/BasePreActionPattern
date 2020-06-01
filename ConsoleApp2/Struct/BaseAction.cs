using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Struct
{
    public abstract class BaseAction<T>
    {
        private readonly BaseAction<T> _preAction;
        public BaseAction(BaseAction<T> preAction)
        {
            _preAction = preAction;
        }

        public virtual bool DoAction(T request)
        {
            if (_preAction == null)
            {
                return DoSomething(_preAction, request);
            }

            //递归调用
            return _preAction.DoAction(request) && DoSomething(_preAction, request);
        }

        protected abstract bool DoSomething(BaseAction<T> myBase, T request);
    }
}
 