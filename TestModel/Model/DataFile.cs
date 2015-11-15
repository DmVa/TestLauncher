using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModel;

namespace TestModel.Model
{
    public class DataFile : BasePropertyChanged, ICommandContainer
    {
        private string _fileName;
        private List<DataSheet> _dataSheets;
        private string _fileFullName;
        private bool _checked;

        public DataFile()
        {
            _dataSheets = new List<DataSheet>();
        }
        public bool Checked
        {
            get
            {
                return _checked;
            }

            set
            {
                _checked = value;
                RaisePropertyChanged("Checked");
                SyncChildrenSelection();
            }
        }

        private void SyncChildrenSelection()
        {
            foreach(var child in _dataSheets)
            {
                child.Checked = _checked;
            }
        }

        public List<ICommandContainer> ChildContainers
        {
            get
            {
                return _dataSheets.Cast<ICommandContainer>().ToList();
            }
            set
            {
                if (value != null)
                    _dataSheets = value.Cast<DataSheet>().ToList();
                else
                    _dataSheets = null;
                RaisePropertyChanged("ChildContainers");
                RaisePropertyChanged("DataSheets");

            }
        }
        public List<DataSheet> DataSheets
        {
            get
            {
                return _dataSheets;
            }
            set
            {
                
                    _dataSheets = value;
                
                RaisePropertyChanged("DataSheets");
                RaisePropertyChanged("ChildContainers");

            }
        }

        public string Label
        {
            get
            {
                return _fileName;
            }

            set
            {
                _fileName = value;RaisePropertyChanged("Label");
            }
        }
    }
}
