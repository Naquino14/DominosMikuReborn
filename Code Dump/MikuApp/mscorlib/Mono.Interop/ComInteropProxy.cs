using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace Mono.Interop
{
	internal class ComInteropProxy : RealProxy, IRemotingTypeInfo
	{
		private __ComObject com_object;

		private int ref_count;

		private string type_name;

		public string TypeName
		{
			get
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		private ComInteropProxy(IntPtr pUnk)
		{
		}

		internal ComInteropProxy(IntPtr pUnk, Type t)
		{
		}

		[MethodImpl(4096)]
		private static extern void AddProxy(IntPtr pItf, ComInteropProxy proxy);

		[MethodImpl(4096)]
		internal static extern ComInteropProxy FindProxy(IntPtr pItf);

		private void CacheProxy()
		{
		}

		internal static ComInteropProxy GetProxy(IntPtr pItf, Type t)
		{
			return (ComInteropProxy)/*Error near IL_0001: Stack underflow*/;
		}

		public override IMessage Invoke(IMessage msg)
		{
			return (IMessage)/*Error near IL_0001: Stack underflow*/;
		}

		public bool CanCastTo(Type fromType, object o)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
