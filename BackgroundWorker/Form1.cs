using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

/* The problem is I duplicate all the methods for each thread. I need to use one method but be able to identify the thread
 * so that I can update the correct control
 */


namespace BackgroundWorkers
{
    public partial class Form1 : Form
    {
        BackgroundWorker workerA = null;
        BackgroundWorker workerB = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void startAButton_Click(object sender, EventArgs e)
        {
            workerA = new BackgroundWorker();
            workerA.WorkerSupportsCancellation = true;
            workerA.DoWork += new DoWorkEventHandler(DoCounterA);
            workerA.WorkerReportsProgress = true;
            workerA.ProgressChanged += new ProgressChangedEventHandler(OnProgressA);
            workerA.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnCompletedA);
            workerA.RunWorkerAsync();
        }

        private void startBButton_Click(object sender, EventArgs e)
        {
            workerB = new BackgroundWorker();
            workerB.WorkerSupportsCancellation = true;
            workerB.DoWork += new DoWorkEventHandler(DoCounterB);
            workerB.WorkerReportsProgress = true;
            workerB.ProgressChanged += new ProgressChangedEventHandler(OnProgressB);
            workerB.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnCompletedB);
            workerB.RunWorkerAsync();

        }

        private void DoCounterA(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker thisWorker = sender as BackgroundWorker;

            for (int counterA = 1; counterA <= 200; counterA++)
            {
                // check to see if operation has been calcelled
                if (thisWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Thread.Sleep(50); // Slow down so that I can see the counting
                thisWorker.ReportProgress(counterA);
            }

            e.Result = "Complete";
        }

        // This is called on UI thread. Use it to update UI.
        void OnProgressA(object sender, ProgressChangedEventArgs e)
        {
            counterATextbox.Text = e.ProgressPercentage.ToString(); // not a percentage in this case but an int
        }

        // Called on UI thread. Get results from operation
        void OnCompletedA(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                counterATextbox.Text = e.Result.ToString();
            }
            workerA.Dispose();
            workerA = null;
        }

        private void DoCounterB(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker thisWorker = sender as BackgroundWorker;

            for (int counterB = 1; counterB <= 200; counterB++)
            {
                // check to see if operation has been calcelled
                if (thisWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Thread.Sleep(50);
                thisWorker.ReportProgress(counterB);
            }

            e.Result = "Complete";
        }

        // This is called on UI thread. Use it to update UI.
        void OnProgressB(object sender, ProgressChangedEventArgs e)
        {
            counterBTextbox.Text = e.ProgressPercentage.ToString(); // not a percentage in this case but an int
        }

        // Called on UI thread. Get results from operation
        void OnCompletedB(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                counterBTextbox.Text = e.Result.ToString();
                statusTextBox.Text = sender.ToString() + " " + e.ToString(); 
            }
            workerB.Dispose();
            workerB = null;
        }

    }
}
