using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.ChainofResponsability;

    public abstract class LoginValidatorBase : ILoginValidator
    {
        protected ILoginValidator next;
        public void SetNext(ILoginValidator validator){
            next = validator;
        }

        public abstract void Execute(Login login);
    }
