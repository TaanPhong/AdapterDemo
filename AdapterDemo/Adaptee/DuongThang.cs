using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterDemo.Adaptee
{
    public class DuongThang
    {
        public void veDuongThang(Panel panel, Pen pen, Point point1, Point point2)
        {
            Graphics graphics = panel.CreateGraphics();
            graphics.DrawLine(pen, point1, point2);
            graphics.Dispose();
            pen.Dispose();
        }
    }
}
