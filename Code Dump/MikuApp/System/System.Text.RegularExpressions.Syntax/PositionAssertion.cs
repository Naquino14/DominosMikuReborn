namespace System.Text.RegularExpressions.Syntax
{
	internal class PositionAssertion : Expression
	{
		private Position pos;

		public PositionAssertion(Position pos)
		{
		}

		public override void Compile(ICompiler cmp, bool reverse)
		{
		}

		public override void GetWidth(out int min, out int max)
		{
		}

		public override bool IsComplex()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override AnchorInfo GetAnchorInfo(bool revers)
		{
			return (AnchorInfo)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
