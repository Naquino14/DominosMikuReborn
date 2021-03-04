namespace System.Runtime.CompilerServices
{
	/// <summary>Provides a set of static methods and properties that provide support for compilers. This class cannot be inherited. </summary>
	public static class RuntimeHelpers
	{
		/// <summary>Gets the offset in bytes to the data in the given string.</summary>
		/// <returns>The byte offset, from the start of the <see cref="T:System.String" /> object to the first character in the string.</returns>
		public static int OffsetToStringData
		{
			[MethodImpl(4096)]
			get;
		}

		[MethodImpl(4096)]
		private static extern void InitializeArray(Array array, IntPtr fldHandle);

		/// <summary>Provides a fast way to initialize an array from data stored in a module.</summary>
		/// <param name="array">The array to be initialized. </param>
		/// <param name="fldHandle">A <see cref="T:System.RuntimeFieldHandle" /> specifying the location of the data used to initialize the array. </param>
		public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
		}
	}
}
