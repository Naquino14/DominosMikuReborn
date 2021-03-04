using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	internal class DynamicPropertyCollection
	{
		private class DynamicPropertyReg
		{
			public IDynamicProperty Property;

			public IDynamicMessageSink Sink;
		}

		private ArrayList _properties;

		public bool HasProperties => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async)
		{
		}
	}
}
