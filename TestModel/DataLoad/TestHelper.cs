using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModel.Model;

namespace TestModel.DataLoad
{
    public class TestHelper
    {
        public List<DataFile> CreateFiles()
        {
            var result = new List<DataFile>();
            var file = new DataFile() { Label = "TestFile" };
            var sheet = new DataSheet { Label = "Sheet" };
            var cmd = new TestCommand { CommandName = "testCommand", ParamsString = "1;2;3;" };
            sheet.Commands.Add(cmd);
            file.DataSheets.Add(sheet);
            result.Add(file);
            return result;
        }
    }
}
