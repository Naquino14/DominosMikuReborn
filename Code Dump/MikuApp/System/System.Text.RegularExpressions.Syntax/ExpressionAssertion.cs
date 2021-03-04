namespace System.Text.RegularExpressions.Syntax
{
	internal class ExpressionAssertion : Assertion
	{
		private bool reverse;

		private bool negate;

		public bool Reverse
		{
			set
			{
			}
		}

		public bool Negate
		{
			set
			{
			}
		}

		public Expression TestExpression
		{
			get
			{
				return (Expression)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public override void Compile(ICompiler cmp, bool reverse)
		{
		}

		public override bool IsComplex()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
