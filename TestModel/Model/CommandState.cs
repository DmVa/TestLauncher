using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel.Model
{
    public enum CommandState
    {
        None,
        NotValid,
        InProgress,
        Error,
        Ok
    }
}
