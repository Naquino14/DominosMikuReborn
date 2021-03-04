namespace System.Runtime.Serialization.Formatters.Binary
{
	internal abstract class ClrTypeMetadata : TypeMetadata
	{
		public Type InstanceType;

		public override bool RequiresTypes => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public ClrTypeMetadata(Type instanceType)
		{
		}
	}
}
