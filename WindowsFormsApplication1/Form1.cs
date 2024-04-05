using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //定时禁用计时器并且清空文本框，清空后启用计时器
        private void T_AutoFocus_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            textBox1.Clear();

            timer1.Enabled = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Enabled = true;
            //当文本框内容达到一定长度执行你想要的操作
            if (textBox1.Text.Length==8)
                {
                    MessageBox.Show(textBox1.Text.ToString());
                    return;
                }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
      
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //按下enter执行你想要的操作
            if ((int)e.KeyChar == 13)
            {

                if (textBox1.Text.Length == 8)
                {
                    MessageBox.Show(textBox1.Text.ToString());
                    return;
                }

            }
        }

    }
}
