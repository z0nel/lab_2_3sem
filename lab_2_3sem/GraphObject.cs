
using System.Drawing;
using System.Security.Cryptography.Xml;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace lab_2_3sem
{
    public class GraphObject
    {
        Random rand = new Random();
        int x, y,xx,yy;
        protected Color c;

        protected bool selected = false;
        public int X
        {
            get => x; set => x = value;
        }
        
        public void render(Graphics g) 
        {
            g.DrawEllipse(Pens.Black, x, y, xx, yy);
        }
        public int Y
        {
            get => y; set => y = value;
        }

        void SetX(int value)
        {
            x = value;
        }


        public GraphObject()
        {
            x = rand.Next(400);
            y = rand.Next(300);
            xx = rand.Next(100);
            yy=rand.Next(100);


        }

        public bool Selected
        {
            get => selected;
            set { selected = value; }
        }



    }
}
