using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterDemo.Adapter
{
    public class HinhChuNhat
    {
        public void hinhChuNhatDaw(Panel area, Pen pen, int x, int y, int width, int height)
        {
            Graphics formGraphic = area.CreateGraphics();
            formGraphic.DrawRectangle(pen, x, y, width, height);
            formGraphic.Dispose();
            pen.Dispose();
        }
    }
}
