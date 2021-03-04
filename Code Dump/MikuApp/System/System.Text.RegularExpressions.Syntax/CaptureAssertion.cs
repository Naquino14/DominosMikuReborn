namespace System.Text.RegularExpressions.Syntax
{
	internal class CaptureAssertion : Assertion
	{
		private ExpressionAssertion alternate;

		private CapturingGroup group;

		private Literal literal;

		public CapturingGroup CapturingGroup
		{
			set
			{
			}
		}

		private ExpressionAssertion Alternate => (ExpressionAssertion)/*Error near IL_0001: Stack underflow*/;

		public CaptureAssertion(Literal l)
		{
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
