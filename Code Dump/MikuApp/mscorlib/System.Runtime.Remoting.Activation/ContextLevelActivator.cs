namespace System.Runtime.Remoting.Activation
{
	[Serializable]
	internal class ContextLevelActivator : IActivator
	{
		private IActivator m_NextActivator;

		public ContextLevelActivator(IActivator next)
		{
		}

		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			return (IConstructionReturnMessage)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
