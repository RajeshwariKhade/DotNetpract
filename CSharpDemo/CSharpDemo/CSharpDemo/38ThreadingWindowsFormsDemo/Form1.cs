using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38ThreadingWindowsFormsDemo
{
    public partial class Form1 : Form
    {
        Thread t1 = null;
        Thread t2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        public void Increase()
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        public void Decrease()
        {
            for (int i = 10; i < 0; i--)
            {
                listBox2.Items.Add(i.ToString());
            }
        }

        private void btnStartT1_Click(object sender, EventArgs e)
        {
            t1 = new Thread(new ThreadStart(Increase));
            t1.Start();
        }

        private void btnStartT2_Click(object sender, EventArgs e)
        {
            t2 = new Thread(new ThreadStart(Decrease));
            t2.Start();
        }

        private void btnPauseT1_Click(object sender, EventArgs e)
        {
            t1.Suspend();
        }

        private void btnPauseT2_Click(object sender, EventArgs e)
        {
            t2.Suspend();
        }

        private void btnResumeT1_Click(object sender, EventArgs e)
        {
            t1.Resume();
        }

        private void btnResumeT2_Click(object sender, EventArgs e)
        {
            t2.Resume();
        }

        private void btnStopT1_Click(object sender, EventArgs e)
        {
            t1.Abort();
        }

        private void btnStopT2_Click(object sender, EventArgs e)
        {
            t2.Abort();
        }
    }
}
