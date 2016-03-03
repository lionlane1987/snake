using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VertecalLine
    {
        List<Point> pList;

        public VertecalLine(int x, int ytop, int ydown, char sym)
        {
            pList = new List<Point>();
            for (int y = ytop; y <= ydown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drop()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }

        }
    }
}
