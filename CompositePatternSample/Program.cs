using CompositePatternSample.Implements;
using System;
using CompositePatternSample.Enums;
using Newtonsoft.Json;

namespace CompositePatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 樹葉層
            var Beck = new Leaf("Beck", Position.FrontendRD);
            var Minerh = new Leaf("Minerh", Position.Intern);
            var Richard = new Leaf("Richard", Position.DBA);
            var Daniel = new Leaf("Daniel", Position.DBA);

            // 樹枝層
            var Albert = new Composite("Albert", Position.HeadFrontend);
            var Duke = new Composite("Duke", Position.BackendRD);
            var Frank = new Composite("Frank", Position.BackendRD);
            var Max = new Composite("Max", Position.HeadBackend);
            var Alan = new Composite("Alan", Position.HeadDatabase);
            var Teddy = new Composite("Teddy", Position.ProductManager);

            // 前端團隊分支
            Albert.Add(Beck);

            // 後端團隊分支
            Duke.Add(Minerh);
            Frank.Add(Minerh);
            Max.Add(Duke);
            Max.Add(Frank);

            // 資料庫團隊分支
            Alan.Add(Richard);
            Alan.Add(Daniel);

            // 技術主管分支
            Teddy.Add(Albert);
            Teddy.Add(Max);
            Teddy.Add(Alan);

            var result = JsonConvert.SerializeObject(Teddy);
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
