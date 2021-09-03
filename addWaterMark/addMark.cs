using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addWaterMark
{
    public class addMark
    {
        public void watermark()
        {
            
            Console.WriteLine("Enter Water Mark Image Name");
            string markName = Console.ReadLine();

            Console.WriteLine($"You enter : {markName}");
        }
    }
}
