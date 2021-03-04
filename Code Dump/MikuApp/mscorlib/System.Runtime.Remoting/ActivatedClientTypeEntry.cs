using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
	/// <summary>Holds values for an object type registered on the client end as a type that can be activated on the server.</summary>
	[ComVisible(true)]
	public class ActivatedClientTypeEntry : TypeEntry
	{
		private string applicationUrl;

		private Type obj_type;

		/// <summary>Gets the URL of the application to activate the type in.</summary>
		/// <returns>The URL of the application to activate the type in.</returns>
		public string ApplicationUrl => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the context attributes for the client-activated type.</summary>
		/// <returns>The context attributes for the client activated type.</returns>
		public IContextAttribute[] ContextAttributes => (IContextAttribute[])/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.Type" /> of the client-activated type.</summary>
		/// <returns>Gets the <see cref="T:System.Type" /> of the client-activated type.</returns>
		public Type ObjectType => (Type)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Returns the type name, assembly name, and application URL of the client-activated type as a <see cref="T:System.String" />.</summary>
		/// <returns>The type name, assembly name, and application URL of the client-activated type as a <see cref="T:System.String" />.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
