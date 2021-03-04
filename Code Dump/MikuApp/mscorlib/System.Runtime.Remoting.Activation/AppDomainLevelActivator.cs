namespace System.Runtime.Remoting.Activation
{
	internal class AppDomainLevelActivator : IActivator
	{
		private string _activationUrl;

		private IActivator _next;

		public AppDomainLevelActivator(string activationUrl, IActivator next)
		{
		}

		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			return (IConstructionReturnMessage)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
