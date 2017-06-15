using System;
using System.IO;
using System.Linq;

namespace TestEightFold
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Test();
            Console.WriteLine("Process end");
            Console.Read();
        }

        static void Test()
        {
            var test = new TestResult();
            var oldList =test.GetDataSet();
            var newList = test.GetDataSet(1);

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "test.txt"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "test.txt");

            foreach(var item in newList)
            {
                var findIt = oldList.Where(x=>x.Portfolio.Equals(item.Portfolio) && x.Pool.Equals(item.Pool) && x.Investor.Equals(item.Investor) && x.SubInvestor.Equals(item.SubInvestor) && x.RowItemKey.Equals(item.RowItemKey)).FirstOrDefault();
                if (findIt == null)
                    continue;

                if(findIt.Column1!=item.Column1)
                {
                    var info = $"ID {item.Investor}, Category {item.RowItemKey}, Col1 oldVal {findIt.Column1} newVal {item.Column1}";
                    Console.WriteLine(info);
                    test.WriteLog(info);
                }

                if (findIt.Column2 != item.Column2)
                {
                    var info = $"ID {item.Investor}, Category {item.RowItemKey}, Col2 oldVal {findIt.Column2} newVal {item.Column2}";
                    Console.WriteLine(info);
                    test.WriteLog(info);
                }

                if (findIt.Column3 != item.Column3)
                {
                    var info = $"ID {item.Investor}, Category {item.RowItemKey}, Col3 oldVal {findIt.Column3} newVal {item.Column3}";
                    Console.WriteLine(info);
                    test.WriteLog(info);
                }

            }
        }
    }
}
