using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModel;

namespace TestModel.Model
{
    public class TestCommand : BasePropertyChanged
    {
        private string _commandName;
        private string[] _commandParams;
        private CommandState _commandState;
        private string _errorText;
        private bool _checked;
        
        public string CommandName
        {
            get { return _commandName; }
            set { _commandName = value;  RaisePropertyChanged("CommandName"); }
        }
        public string[] CommandParams
        {
            get { return _commandParams; }
            set { _commandParams = value; RaisePropertyChanged("CommandParams"); }
        }
        public CommandState CommandState
        {
            get { return _commandState; }
            set { _commandState = value; RaisePropertyChanged("CommandState"); }
        }
        public string ErrorText
        {
            get { return _errorText; }
            set { _errorText = value; RaisePropertyChanged("ErrorText"); }
        }
        public bool Checked
        {
            get { return _checked; }
            set { _checked = value; RaisePropertyChanged("Checked"); }
        }

        public string ParamsString { get; internal set; }

        public void Execute(params string[] commands)
        {

        }
    }
}
