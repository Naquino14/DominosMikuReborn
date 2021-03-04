using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>A platform-specific type that is used to represent a pointer or a handle.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	[CLSCompliant(false)]
	public struct UIntPtr : ISerializable
	{
		/// <summary>A read-only field that represents a pointer or handle that has been initialized to zero.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly UIntPtr Zero;

		private unsafe void* _pointer;

		/// <summary>Gets the size of this instance.</summary>
		/// <returns>The size of a pointer or handle on this platform, measured in bytes. The value of this property is 4 on a 32-bit platform, and 8 on a 64-bit platform.</returns>
		/// <filterpriority>1</filterpriority>
		public static int Size => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of <see cref="T:System.UIntPtr" /> using the specified 64-bit pointer or handle.</summary>
		/// <param name="value">A pointer or handle contained in a 64-bit unsigned integer. </param>
		/// <exception cref="T:System.OverflowException">On a 32-bit platform, <paramref name="value" /> is too large to represent as an <see cref="T:System.UIntPtr" />. </exception>
		public UIntPtr(ulong value)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UIntPtr" /> structure using the specified 32-bit pointer or handle.</summary>
		/// <param name="value">A pointer or handle contained in a 32-bit unsigned integer. </param>
		public UIntPtr(uint value)
		{
		}

		/// <summary>Initializes a new instance of <see cref="T:System.UIntPtr" /> using the specified pointer to an unspecified type.</summary>
		/// <param name="value">A pointer to an unspecified type. </param>
		[CLSCompliant(false)]
		public unsafe UIntPtr(void* value)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize the current <see cref="T:System.UIntPtr" /> object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data. </param>
		/// <param name="context">The destination for this serialization. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null.</exception>
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.UIntPtr" /> and equals the value of this instance; otherwise, false.</returns>
		/// <param name="obj">An object to compare with this instance or null. </param>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of this instance to a 32-bit unsigned integer.</summary>
		/// <returns>A 32-bit unsigned integer equal to the value of this instance.</returns>
		/// <exception cref="T:System.OverflowException">On a 64-bit platform, the value of this instance is too large to represent as a 32-bit unsigned integer. </exception>
		/// <filterpriority>1</filterpriority>
		public uint ToUInt32()
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of this instance to a 64-bit unsigned integer.</summary>
		/// <returns>A 64-bit unsigned integer equal to the value of this instance.</returns>
		/// <filterpriority>1</filterpriority>
		public ulong ToUInt64()
		{
			return (ulong)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of this instance to a pointer to an unspecified type.</summary>
		/// <returns>A pointer to <see cref="T:System.Void" />; that is, a pointer to memory containing data of an unspecified type.</returns>
		/// <filterpriority>1</filterpriority>
		[CLSCompliant(false)]
		public unsafe void* ToPointer()
		{
			return (void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation.</summary>
		/// <returns>The string representation of the value of this instance.</returns>
		/// <filterpriority>1</filterpriority>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.UIntPtr" /> are equal.</summary>
		/// <returns>true if <paramref name="value1" /> equals <paramref name="value2" />; otherwise, false.</returns>
		/// <param name="value1">A <see cref="T:System.UIntPtr" />. </param>
		/// <param name="value2">A <see cref="T:System.UIntPtr" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator ==(UIntPtr value1, UIntPtr value2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.UIntPtr" /> are not equal.</summary>
		/// <returns>true if <paramref name="value1" /> does not equal <paramref name="value2" />; otherwise, false.</returns>
		/// <param name="value1">A <see cref="T:System.UIntPtr" />. </param>
		/// <param name="value2">A <see cref="T:System.UIntPtr" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator !=(UIntPtr value1, UIntPtr value2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Converts the value of the specified <see cref="T:System.UIntPtr" /> to a 64-bit unsigned integer.</summary>
		/// <returns>The contents of <paramref name="value" />.</returns>
		/// <param name="value">A <see cref="T:System.UIntPtr" />. </param>
		/// <filterpriority>3</filterpriority>
		public static explicit operator ulong(UIntPtr value)
		{
			return (ulong)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of the specified <see cref="T:System.UIntPtr" /> to a 32-bit unsigned integer.</summary>
		/// <returns>The contents of <paramref name="value" />.</returns>
		/// <param name="value">A <see cref="T:System.UIntPtr" />. </param>
		/// <exception cref="T:System.OverflowException">On a 64-bit platform, the value of <paramref name="value" /> is too large to represent as a 32-bit unsigned integer. </exception>
		/// <filterpriority>3</filterpriority>
		public static explicit operator uint(UIntPtr value)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of a 64-bit unsigned integer to an <see cref="T:System.UIntPtr" />.</summary>
		/// <returns>A new instance of <see cref="T:System.UIntPtr" /> initialized to <paramref name="value" />.</returns>
		/// <param name="value">A 64-bit unsigned integer. </param>
		/// <exception cref="T:System.OverflowException">On a 32-bit platform, <paramref name="value" /> is too large to represent as an <see cref="T:System.UIntPtr" />. </exception>
		/// <filterpriority>3</filterpriority>
		public unsafe static explicit operator UIntPtr(ulong value)
		{
			return (UIntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified pointer to an unspecified type to a <see cref="T:System.UIntPtr" />.</summary>
		/// <returns>A new instance of <see cref="T:System.UIntPtr" /> initialized to <paramref name="value" />.</returns>
		/// <param name="value">A pointer to an unspecified type. </param>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public unsafe static explicit operator UIntPtr(void* value)
		{
			return (UIntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of the specified <see cref="T:System.UIntPtr" /> to a pointer to an unspecified type.</summary>
		/// <returns>The contents of <paramref name="value" />.</returns>
		/// <param name="value">A <see cref="T:System.UIntPtr" />. </param>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public unsafe static explicit operator void*(UIntPtr value)
		{
			return (void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of a 32-bit unsigned integer to an <see cref="T:System.UIntPtr" />.</summary>
		/// <returns>A new instance of <see cref="T:System.UIntPtr" /> initialized to <paramref name="value" />.</returns>
		/// <param name="value">A 32-bit unsigned integer. </param>
		/// <filterpriority>3</filterpriority>
		public unsafe static explicit operator UIntPtr(uint value)
		{
			return (UIntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
