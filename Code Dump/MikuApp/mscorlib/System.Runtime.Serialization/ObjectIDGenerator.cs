using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Generates IDs for objects.</summary>
	[Serializable]
	[ComVisible(true)]
	[MonoTODO("Serialization format not compatible with.NET")]
	public class ObjectIDGenerator
	{
		private class InstanceComparer : IComparer, IHashCodeProvider
		{
			int IComparer.Compare(object o1, object o2)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			int IHashCodeProvider.GetHashCode(object o)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
		}

		private Hashtable table;

		private long current;

		private static InstanceComparer comparer;

		internal long NextId => (long)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" /> class.</summary>
		public ObjectIDGenerator()
		{
		}

		/// <summary>Returns the ID for the specified object, generating a new ID if the specified object has not already been identified by the <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />.</summary>
		/// <returns>The object's ID is used for serialization. <paramref name="firstTime" /> is set to true if this is the first time the object has been identified; otherwise, it is set to false.</returns>
		/// <param name="obj">The object you want an ID for. </param>
		/// <param name="firstTime">true if <paramref name="obj" /> was not previously known to the <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" /> has been asked to keep track of too many objects. </exception>
		public virtual long GetId(object obj, out bool firstTime)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
