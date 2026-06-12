using System.Runtime.CompilerServices;
using System.Threading;

namespace System.ComponentModel
{
	[DefaultEvent("DoWork")]
	public class BackgroundWorker : Component
	{
		private bool _canCancelWorker;

		private bool _workerReportsProgress;

		private bool _cancellationPending;

		private bool _isRunning;

		private AsyncOperation _asyncOperation;

		private readonly SendOrPostCallback _operationCompleted;

		private readonly SendOrPostCallback _progressReporter;

		public bool CancellationPending => false;

		public bool IsBusy => false;

		public bool WorkerReportsProgress
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool WorkerSupportsCancellation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event DoWorkEventHandler DoWork
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event ProgressChangedEventHandler ProgressChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event RunWorkerCompletedEventHandler RunWorkerCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void AsyncOperationCompleted(object arg)
		{
		}

		public void CancelAsync()
		{
		}

		protected virtual void OnDoWork(DoWorkEventArgs e)
		{
		}

		protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
		{
		}

		protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
		{
		}

		private void ProgressReporter(object arg)
		{
		}

		public void ReportProgress(int percentProgress)
		{
		}

		public void ReportProgress(int percentProgress, object userState)
		{
		}

		public void RunWorkerAsync()
		{
		}

		public void RunWorkerAsync(object argument)
		{
		}

		private void WorkerThreadStart(object argument)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
