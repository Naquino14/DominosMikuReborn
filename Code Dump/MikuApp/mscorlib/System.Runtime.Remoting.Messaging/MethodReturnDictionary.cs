namespace System.Runtime.Remoting.Messaging
{
	internal class MethodReturnDictionary : MethodDictionary
	{
		public static string[] InternalReturnKeys;

		public static string[] InternalExceptionKeys;

		public MethodReturnDictionary(IMethodReturnMessage message)
		{
		}
	}
}
