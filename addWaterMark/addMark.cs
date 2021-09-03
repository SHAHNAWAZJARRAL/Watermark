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

            Parallel.ForEach(Directory.GetFiles(@"" + Environment.CurrentDirectory + "\\img"), img =>
            {
                Image baseimg = Image.FromFile(img);
                Graphics graphics = Graphics.FromImage(baseimg);
                Image watermark = Image.FromFile(@"" + Environment.CurrentDirectory + "\\watermark\\" + markName + ".png");
                decimal de_w = (decimal)baseimg.Width / watermark.Width * 100;
                int i_w = (int)de_w;
                var resized = new Bitmap(watermark, (watermark.Width * i_w) / 100, (watermark.Height * i_w) / 100);
                graphics.DrawImage(resized, new Point(0, Convert.ToInt32((baseimg.Height / 2) - (resized.Height / 2))));
                baseimg.Save(Path.GetDirectoryName(@"" + Environment.CurrentDirectory + "\\addwatermark\\") + "\\" + Path.GetFileNameWithoutExtension(img) + ".jpg");
            });
        }
    }
}
