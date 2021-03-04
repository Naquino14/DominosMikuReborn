using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Services
{
	/// <summary>Provides a way to register, unregister, and obtain a list of tracking handlers.</summary>
	[ComVisible(true)]
	public class TrackingServices
	{
		private static ArrayList _handlers;

		internal static void NotifyMarshaledObject(object obj, ObjRef or)
		{
		}

		internal static void NotifyUnmarshaledObject(object obj, ObjRef or)
		{
		}

		internal static void NotifyDisconnectedObject(object obj)
		{
		}
	}
}
