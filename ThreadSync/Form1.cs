using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ThreadSync
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);
        delegate void SetCounterCallback();
        private Thread threadA = null;
        private Thread threadB = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoCounterA(string text)
        {
            if (this.counterATextbox.InvokeRequired)
            {
                SetTextCallback callbackA = new SetTextCallback(DoCounterA);
                this.Invoke(callbackA, new object[] { text });
            }
            else
            {
                this.counterATextbox.Text = text;
            }
        }

        private void DoCounterB(string text)
        {
            if (this.counterBTextbox.InvokeRequired)
            {
                SetTextCallback callbackB = new SetTextCallback(DoCounterB);
                this.Invoke(callbackB, new object[] { text });
            }
            else
            {
                this.counterBTextbox.Text = text;
            }
        }

        private void counterAStartButton_Click(object sender, EventArgs e)
        {
            this.threadA = new Thread(new ThreadStart(this.CounterADelegateMethod));
            this.threadA.Start();
        }

        private void counterBStartButton_Click(object sender, EventArgs e)
        {
            this.threadB = new Thread(new ThreadStart(this.CounterBDelegateMethod));
            this.threadB.Start();
        }

        private void CounterADelegateMethod()
        {
            for (int counterA = 1; counterA <= 200; counterA++)
            {
                this.DoCounterA(counterA.ToString());
                Thread.Sleep(50);
            }
        }

        private void CounterBDelegateMethod()
        {
            for (int counterB = 1; counterB <= 200; counterB++)
            {
                this.DoCounterB(counterB.ToString());
                Thread.Sleep(50);
            }
        }

        private void SetTextB(string text)
        {
            if (this.counterBTextbox.InvokeRequired)
            {
                SetTextCallback callbackB = new SetTextCallback(SetTextB);
                this.Invoke(callbackB, new object[] { text });
            }
            else
            {
                counterBTextbox.Text = text;
            }
        }
        
    }
}
