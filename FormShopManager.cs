using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;



namespace shopManager
{
    public partial class Form1 : Form
    {
        StackDataList dataList;
        public Form1()
        {
            InitializeComponent();
            dataList = new StackDataList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameTextBox.Focus();
        }

    }
}