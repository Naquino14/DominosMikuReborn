using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Provides data for the event that is raised when there is an exception that is not handled in any application domain.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public class UnhandledExceptionEventArgs : EventArgs
	{
		private object exception;

		private bool m_isTerminating;
	}
}
