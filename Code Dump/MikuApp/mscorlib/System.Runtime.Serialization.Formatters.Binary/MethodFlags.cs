namespace System.Runtime.Serialization.Formatters.Binary
{
	internal enum MethodFlags
	{
		NoArguments = 1,
		PrimitiveArguments = 2,
		ArgumentsInSimpleArray = 4,
		ArgumentsInMultiArray = 8,
		ExcludeLogicalCallContext = 0x10,
		IncludesLogicalCallContext = 0x40,
		IncludesSignature = 0x80,
		FormatMask = 0xF,
		GenericArguments = 0x8000,
		NeedsInfoArrayMask = 32972
	}
}
