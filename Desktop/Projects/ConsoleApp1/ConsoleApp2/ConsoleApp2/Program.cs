using ConsoleApp2.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Object;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpService service = new EmpService();
            service.SaveEmp();
        }
    }
}
