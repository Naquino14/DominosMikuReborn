namespace System.Runtime.Remoting.Activation
{
	internal class RemoteActivator : MarshalByRefObject, IActivator
	{
		public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			return (IConstructionReturnMessage)/*Error near IL_0001: Stack underflow*/;
		}

		public override object InitializeLifetimeService()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
