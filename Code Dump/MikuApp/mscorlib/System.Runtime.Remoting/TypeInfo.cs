namespace System.Runtime.Remoting
{
	[Serializable]
	internal class TypeInfo : IRemotingTypeInfo
	{
		private string serverType;

		private string[] serverHierarchy;

		private string[] interfacesImplemented;

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

		public TypeInfo(Type type)
		{
		}

		public bool CanCastTo(Type fromType, object o)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
