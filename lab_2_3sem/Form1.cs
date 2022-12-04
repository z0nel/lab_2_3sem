using System.Collections.Generic;

namespace lab_2_3sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть окно?","подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Отменили выход из программы";
            }
        }

        GraphObject o;
        private void PaintPanel(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (GraphObject obj in list)
            {
                obj.render(g);
            }


        }

        List<GraphObject> list = new List<GraphObject>();


      


        private void AddFigure(object sender, EventArgs e)
        {
            GraphObject o = new GraphObject();
            list.Add(o);
            panel1.Invalidate();
        }


       
        private void MoveRight(object sender, EventArgs e)
        {
            if (o!= null) 
            {
                o.X = o.X + 25;
                panel1.Invalidate();
            }
        }

        private void MoveLeft(object sender, EventArgs e)
        {
            if (o != null)
            {
                o.X = o.X - 25;
                panel1.Invalidate();
            }
        }

        private void DoubleAdd(object sender, EventArgs e)
        {
            GraphObject o = new GraphObject();
            list.Add(o);
            panel1.Invalidate();
        }

        private void DeleteAll(object sender, EventArgs e)
        {

            list = new List<GraphObject>();
            panel1.Refresh();

            

        }



        GraphObject savedObject;


       

    }
}