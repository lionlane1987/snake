using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0,78,24, '+');
            VertecalLine leftline = new VertecalLine(0, 24, 0, '+');
            VertecalLine rightline = new VertecalLine(0,24,78, '+');
            upLine.Drow();
            downLine.Drow();
            leftline.Drow();
            rightline.Drow();
            
            
            Point p = new Point(4, 5, '#');
            p.Draw();


            Emploee e = new Emploee();
            e.age = 42;
            e.pay = 30000;

            /*HorizontalLine line = new HorizontalLine(5, 10 , 8 , '+');
            line.Drow();

            VertecalLine line1 = new VertecalLine(12, 6, 16, '+');
            line1.Drop();
                       
            Console.ReadLine();*/
        }

        
    }
}
