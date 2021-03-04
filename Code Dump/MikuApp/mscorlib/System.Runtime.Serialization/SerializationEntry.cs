using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Holds the value, <see cref="T:System.Type" />, and name of a serialized object. </summary>
	[ComVisible(true)]
	public struct SerializationEntry
	{
		private string name;

		private Type objectType;

		private object value;

		/// <summary>Gets the name of the object.</summary>
		/// <returns>The name of the object.</returns>
		public string Name => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.Type" /> of the object.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the object.</returns>
		public Type ObjectType => (Type)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the value contained in the object.</summary>
		/// <returns>The value contained in the object.</returns>
		public object Value => (object)/*Error near IL_0001: Stack underflow*/;

		internal SerializationEntry(string name, Type type, object value)
		{
		}
	}
}
