using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModel;
using TestModel.DataLoad;
using TestModel.Model;

namespace TestModel.ViewModels
{
    public class MainViewModel : BasePropertyChanged
    {
        private bool _checkAll;
        private List<DataFile> _dataFiles;
        public MainViewModel()
        {
            Init(); 
        }
        public bool CheckAll
        {
            get { return _checkAll; }
            set {  _checkAll = value; RaisePropertyChanged("CheckAll"); SyncChildrenSelection();  }
        }

        private void SyncChildrenSelection()
        {
            foreach (var child in _dataFiles)
            {
                child.Checked = _checkAll;
            }
        }

        public List<DataFile> Files
        {
            get { return _dataFiles; }
            set {  _dataFiles = value; RaisePropertyChanged("Files"); }
        }

        private void Init()
        {
            var testHelper = new TestHelper();
            _dataFiles = testHelper.CreateFiles();
            CheckAll = true;
        }
    }
}
