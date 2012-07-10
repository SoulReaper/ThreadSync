using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SynchroContext
{
    public partial class Form1 : Form
    {
        SynchronizationContext ctx;
        Thread threadA;
        Thread threadB;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void DoCounterA()
        {
            SendOrPostCallback callback = new SendOrPostCallback(updateCounterATextbox);
            StringBuilder sb = new StringBuilder();
            for (int counterA = 1; counterA <= 200; counterA++)
            {
                sb.Append(counterA.ToString());
                ctx.Post(callback, sb.ToString());
                sb.Length = 0;
                Thread.Sleep(50);
            }
        }

        private void DoCounterB()
        {
            SendOrPostCallback callback = new SendOrPostCallback(updateCounterBTextbox);
            StringBuilder sb = new StringBuilder();
            for (int counterB = 1; counterB <= 200; counterB++)
            {
                sb.Append(counterB.ToString());
                ctx.Post(callback, sb.ToString());
                sb.Length = 0;
                Thread.Sleep(50);
            }
        }

        private void updateCounterATextbox(object state)
        {
            counterATextbox.Text = state as string;
        }

        private void updateCounterBTextbox(object state)
        {
            counterBTextbox.Text = state as string;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StartAButton_Click(object sender, EventArgs e)
        {
            ctx = SynchronizationContext.Current;
            threadA = new Thread(new ThreadStart(DoCounterA)); 
            threadA.Start();
        }

        private void StartBButton_Click(object sender, EventArgs e)
        {
            ctx = SynchronizationContext.Current;
            threadB = new Thread(new ThreadStart(DoCounterB));
            threadB.Start();
        }

    }
}
