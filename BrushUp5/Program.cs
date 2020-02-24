using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUp5
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWorker worker = new StringWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
