using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents a variable-length argument list; that is, the parameters of a function that takes a variable number of arguments.</summary>
	/// <filterpriority>2</filterpriority>
	[StructLayout(3)]
	public struct ArgIterator
	{
		private IntPtr sig;

		private IntPtr args;

		private int next_arg;

		private int num_args;

		/// <summary>Initializes a new instance of the <see cref="T:System.ArgIterator" /> structure using the specified argument list.</summary>
		/// <param name="arglist">An argument list consisting of mandatory and optional arguments. </param>
		public ArgIterator(RuntimeArgumentHandle arglist)
		{
		}

		[MethodImpl(4096)]
		private extern void Setup(IntPtr argsp, IntPtr start);

		/// <summary>This method is not supported, and always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>This comparison is not supported. No value is returned.</returns>
		/// <param name="o">An object to be compared to this instance. </param>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object o)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns the hash code of this object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the next argument in a variable-length argument list.</summary>
		/// <returns>The next argument as a <see cref="T:System.TypedReference" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">An attempt was made to read beyond the end of the list. </exception>
		/// <filterpriority>2</filterpriority>
		[CLSCompliant(false)]
		public TypedReference GetNextArg()
		{
			return (TypedReference)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private extern TypedReference IntGetNextArg();

		/// <summary>Returns the number of arguments remaining in the argument list.</summary>
		/// <returns>The number of remaining arguments.</returns>
		/// <filterpriority>2</filterpriority>
		public int GetRemainingCount()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
