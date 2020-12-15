using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmoTest
{
    class DoubleBufferedTreeView: TreeView
    {
        protected override bool DoubleBuffered { get => base.DoubleBuffered; set => base.DoubleBuffered = value; }

        public DoubleBufferedTreeView()
        {
            DoubleBuffered = true;
        }
    }
}
