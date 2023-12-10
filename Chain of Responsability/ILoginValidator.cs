using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.ChainofResponsability;

    public interface ILoginValidator
    {
        void SetNext(ILoginValidator validator);
        void Execute(Login login);
    }
