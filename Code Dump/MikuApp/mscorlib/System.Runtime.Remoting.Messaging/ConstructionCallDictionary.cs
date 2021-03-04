using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Messaging
{
	internal class ConstructionCallDictionary : MethodDictionary
	{
		public static string[] InternalKeys;

		public ConstructionCallDictionary(IConstructionCallMessage message)
		{
		}

		protected override object GetMethodProperty(string key)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		protected override void SetMethodProperty(string key, object value)
		{
		}
	}
}
