using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Describes objects that contain both a managed pointer to a location and a runtime representation of the type that may be stored at that location.</summary>
	/// <filterpriority>2</filterpriority>
	[ComVisible(true)]
	[CLSCompliant(false)]
	public struct TypedReference
	{
		private RuntimeTypeHandle type;

		private IntPtr value;

		private IntPtr klass;

		/// <summary>Checks if this object is equal to the specified object.</summary>
		/// <returns>true if this object is equal to the specified object; otherwise, false.</returns>
		/// <param name="o">The object with which to compare the current object. </param>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented. </exception>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object o)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns the hash code of this object.</summary>
		/// <returns>The hash code of this object.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified TypedReference to an Object.</summary>
		/// <returns>An <see cref="T:System.Object" /> converted from a TypedReference.</returns>
		/// <param name="value">The TypedReference to be converted. </param>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		public static extern object ToObject(TypedReference value);
	}
}
