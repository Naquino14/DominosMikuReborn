using System.Collections;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Activation
{
	internal class RemoteActivationAttribute : Attribute, IContextAttribute
	{
		private IList _contextProperties;

		public RemoteActivationAttribute(IList contextProperties)
		{
		}

		public bool IsContextOK(Context ctx, IConstructionCallMessage ctor)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void GetPropertiesForNewContext(IConstructionCallMessage ctor)
		{
		}
	}
}
