namespace System.Reflection
{
	[Flags]
	internal enum PInfo
	{
		Attributes = 0x1,
		GetMethod = 0x2,
		SetMethod = 0x4,
		ReflectedType = 0x8,
		DeclaringType = 0x10,
		Name = 0x20
	}
}
