using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	internal abstract class Identity
	{
		protected string _objectUri;

		protected IMessageSink _channelSink;

		protected IMessageSink _envoySink;

		private DynamicPropertyCollection _clientDynamicProperties;

		private DynamicPropertyCollection _serverDynamicProperties;

		protected ObjRef _objRef;

		private bool _disposed;

		public IMessageSink ChannelSink
		{
			get
			{
				return (IMessageSink)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public IMessageSink EnvoySink => (IMessageSink)/*Error near IL_0001: Stack underflow*/;

		public string ObjectUri
		{
			get
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public bool IsConnected => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool Disposed
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public Identity(string objectUri)
		{
		}

		public abstract ObjRef CreateObjRef(Type requestedType);

		public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
		}
	}
}
