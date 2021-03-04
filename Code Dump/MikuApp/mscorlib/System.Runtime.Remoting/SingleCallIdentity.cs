using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
	internal class SingleCallIdentity : ServerIdentity
	{
		public SingleCallIdentity(string objectUri, Context context, Type objectType)
		{
		}
	}
}
