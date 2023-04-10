using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterDemo
{
    public interface Draw
    {
        void Ve(Panel area, Pen pen, int x1, int y1, int x2, int y2);
    }
}
