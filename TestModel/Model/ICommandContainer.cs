using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel.Model
{
    public interface ICommandContainer
    {
        string Label { get; }
        bool Checked { get; set; }
        List<ICommandContainer> ChildContainers { get; }
    }
}
