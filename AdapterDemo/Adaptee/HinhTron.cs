using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterDemo.Adaptee
{
    public class HinhTron
    {
        public void veHinhTron(Panel area, Pen pen, int x1, int y1, int r)
        {
            Graphics graphics = area.CreateGraphics();
            graphics.DrawEllipse(pen, x1, y1, r, r);
            graphics.Dispose();
            pen.Dispose();
        }
    }
}
