using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModel;

namespace TestModel.Model
{
    public class DataSheet : BasePropertyChanged, ICommandContainer
    {
        private string _sheetName;
        private bool _checked;
        private List<TestCommand> _commands;
        public DataSheet()
        {
            _commands = new List<TestCommand>();
        }
        public bool Checked
        {
            get
            {
                return _checked;
            }

            set
            {
                _checked = value; RaisePropertyChanged("Checked");
            }
        }

        public List<ICommandContainer> ChildContainers
        {
            get
            {
                return null;
            }
        }

        public List<TestCommand> Commands
        {
            get
            {
                return _commands;
            }
            set
            {
                _commands = value;
            }
        }

        public string Label
        {
            get
            {
                return _sheetName;
            }

            set
            {
                _sheetName = value; RaisePropertyChanged("Label");
            }
        }
    }
}
