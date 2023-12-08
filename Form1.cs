using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;



namespace shopManager
{
    public partial class Form1 : Form
    {

        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           GraphicsPath P = new GraphicsPath();
            P.AddEllipse(1,1,deleteButton.Width-3,deleteButton.Height-3);
            deleteButton.Region = new Region(P);
            GraphicsPath P2= new GraphicsPath();
            P2.AddEllipse(1,1,updateButton.Width-3,updateButton.Height-3);
            updateButton.Region = new Region(P2);
        }

        private void costLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void profitLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}