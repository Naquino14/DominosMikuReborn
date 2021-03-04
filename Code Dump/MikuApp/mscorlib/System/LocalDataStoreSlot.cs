using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Encapsulates a memory slot to store local data. This class cannot be inherited.</summary>
	/// <filterpriority>2</filterpriority>
	[ComVisible(true)]
	public sealed class LocalDataStoreSlot
	{
		internal int slot;

		internal bool thread_local;

		private static object lock_obj;

		private static bool[] slot_bitmap_thread;

		private static bool[] slot_bitmap_context;

		internal LocalDataStoreSlot(bool in_thread)
		{
		}

		~LocalDataStoreSlot()
		{
		}
	}
}
