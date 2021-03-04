using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDual)]
	public class Object
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public Object()
		{
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.</summary>
		/// <returns>true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.</returns>
		/// <param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />. </param>
		/// <filterpriority>2</filterpriority>
		public virtual bool Equals(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> instances are considered equal.</summary>
		/// <returns>true if the instances are equal; otherwise false.</returns>
		/// <param name="objA">The first <see cref="T:System.Object" /> to compare. </param>
		/// <param name="objB">The second <see cref="T:System.Object" /> to compare. </param>
		/// <filterpriority>2</filterpriority>
		public static bool Equals(object objA, object objB)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		~Object()
		{
		}

		/// <summary>Serves as a hash function for a particular type. </summary>
		/// <returns>A hash code for the current <see cref="T:System.Object" />.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the type of the current instance.</summary>
		/// <returns>The exact runtime type of the current instance.</returns>
		/// <filterpriority>2</filterpriority>
		[MethodImpl(4096)]
		public extern Type GetType();

		/// <summary>Creates a shallow copy of the current <see cref="T:System.Object" />.</summary>
		/// <returns>A shallow copy of the current <see cref="T:System.Object" />.</returns>
		[MethodImpl(4096)]
		protected extern object MemberwiseClone();

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>A string that represents the current object.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> instances are the same instance.</summary>
		/// <returns>true if <paramref name="objA" /> is the same instance as <paramref name="objB" /> or if both are null references; otherwise, false.</returns>
		/// <param name="objA">The first object to compare. </param>
		/// <param name="objB">The second object to compare. </param>
		/// <filterpriority>2</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool ReferenceEquals(object objA, object objB)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		internal static extern int InternalGetHashCode(object o);

		[MethodImpl(4096)]
		internal extern IntPtr obj_address();

		private void FieldGetter(string typeName, string fieldName, ref object val)
		{
		}

		private void FieldSetter(string typeName, string fieldName, object val)
		{
		}
	}
}
