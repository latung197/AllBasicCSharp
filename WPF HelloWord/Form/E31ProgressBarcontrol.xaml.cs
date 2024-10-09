using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace WPF_HelloWord.Form
{
    /// <summary>
    /// Interaction logic for E31ProgressBarcontrol.xaml
    /// </summary>
    public partial class E31ProgressBarcontrol : Window
    {
        public E31ProgressBarcontrol()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        public void worker_DoWork(Object sender, DoWorkEventArgs e)
        {
            for(int i = 0;i < 100;i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        public void worker_ProgressChanged(Object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value = e.ProgressPercentage;
        }
    }
}
