namespace System.Text.RegularExpressions.Syntax
{
	internal class NonBacktrackingGroup : Group
	{
		public override void Compile(ICompiler cmp, bool reverse)
		{
		}

		public override bool IsComplex()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
