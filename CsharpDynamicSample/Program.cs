using System;
using System.Dynamic;

namespace EasyCsharpDynamic
{
    class Program2
    {
        static void Main1(string[] args)
        {
            dynamic a = 10;
            dynamic b = 20;
            dynamic c = 30; // 数値かと思いきや
            c = "hello";
            dynamic d = new ExpandoObject();
            d.hoge = 99;
            d.fuga = "world";
            dynamic e = a + b + c + d.hoge + d.fuga;
            Console.WriteLine(e); // 結果: 30hello99world
        }
        
    }
}
