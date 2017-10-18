using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    class Program
    {
      
        static void Main(string[] args)
        {
            float a, b;
            Console.WriteLine("请输入运算数a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算数b");
            b = int.Parse(Console.ReadLine());
            string str = "请输入要进行的运算";
            Console.WriteLine(str);
           string m= Console.ReadLine();
            Yunsuan n = new Yunsuan();
            int i = m.IndexOf("+");
            if (i==0)
                n.Jiafa(a,b);
            int o = m.IndexOf("-");
            if (o == 0)
                n.Jianfa(a, b);
            int p = m.IndexOf("*");
            if (p == 0)
                n.Chengfa(a, b);
            int l = m.IndexOf("/");
            if (l == 0)
                n.Chufa(a, b);


        }
     }
    class Yunsuan
    {
        public float Jiafa(float a, float b)
        {
            Console.WriteLine("{0}+{1}={2}" ,a,b,a+b);
            return (a + b);
        }
        public float Jianfa(float a, float b)
        {
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            
            return (a - b);
        }
        public float Chengfa(float a, float b)
        {
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            
            return (a * b);
        }
        public float Chufa(float a, float b)
        {
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            
            return (a / b);
        }

        public bool Equals(int c, int d)
        {
            if (c == d)
                return true;
            else
                return false;
        }

    }
}
