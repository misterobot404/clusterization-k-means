using System.Drawing;

namespace K_means
{
    class Data
    {
        public static Color Color = Color.Black; // цвет точки по умолчанию
        public static int Brush = 3;
        public static bool Finish = false; // флаг окончания работы алгоритма
        public static bool ToStep1 = false; // необходимо вернуться к шагу 1
        public static Pen Pen = new Pen(Color);
        public static int NumbKernel; // количество кластеров
        public static int NumbPoints; // количество точек

        

        public struct element
        {
            public Point Pt;
            public int IsKernel;
            public int InClass;
            public Color Pcolor;
            public int numInElements;
            
        }
        
        //----------------------------//
        public static Bitmap Img = new Bitmap(800, 400);
        //------------------------------//
        

       //===========================================//
        
       
        public void Draw(element str) //Draw point
        {
            Graphics g = Graphics.FromImage(Img);
            Pen.Color = Color;
            Pen.Width = Brush;
            
            Point tmp;
            tmp = str.Pt;
            tmp.X += 1;
            g.DrawEllipse(Pen, str.Pt.X,str.Pt.Y,1,1);
        }
        public void Fill()
        {
            Graphics g = Graphics.FromImage(Img);
            Brush b = new SolidBrush(Color.White);
            g.FillRectangle(b, 0, 0, 800, 400);
        }      
    }
}
