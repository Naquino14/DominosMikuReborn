using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Provides a formatter-friendly mechanism for parsing the data in <see cref="T:System.Runtime.Serialization.SerializationInfo" />. This class cannot be inherited.</summary>
	[ComVisible(true)]
	public sealed class SerializationInfoEnumerator : IEnumerator
	{
		private IEnumerator enumerator;

		/// <summary>Gets the current item in the collection.</summary>
		/// <returns>A <see cref="T:System.Runtime.Serialization.SerializationEntry" /> that contains the current serialization data.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumeration has not started or has already ended. </exception>
		object IEnumerator.Current => (object)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the item currently being examined.</summary>
		/// <returns>The item currently being examined.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
		public SerializationEntry Current => (SerializationEntry)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the name for the item currently being examined.</summary>
		/// <returns>The item name.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
		public string Name => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the type of the item currently being examined.</summary>
		/// <returns>The type of the item currently being examined.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
		public Type ObjectType => (Type)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the value of the item currently being examined.</summary>
		/// <returns>The value of the item currently being examined.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
		public object Value => (object)/*Error near IL_0001: Stack underflow*/;

		internal SerializationInfoEnumerator(ArrayList list)
		{
		}

		/// <summary>Updates the enumerator to the next item.</summary>
		/// <returns>true if a new element is found; otherwise, false.</returns>
		public bool MoveNext()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Resets the enumerator to the first item.</summary>
		public void Reset()
		{
		}
	}
}
