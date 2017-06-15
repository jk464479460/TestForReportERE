using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace TestEightFold
{
    public class TestResult
    {
        const string _OldJsonPath = "Old.json";
        const string _NewJsonPath = "New.json";

        public IList<ReportInvestorStatement> GetDataSet(int old = 0)
        {
            var path = old == 0 ? _OldJsonPath : _NewJsonPath;
            var result = new List<ReportInvestorStatement>();

            using (var read=new StreamReader(path))
            {
                var json = read.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<ReportInvestorStatement>>(json);
            }

            return result;
        }

        public void WriteLog(string log)
        {
            using (var w=new StreamWriter("test.txt",true, Encoding.UTF8))
            {
                w.WriteLine(log);
            }
        }
    }
}
