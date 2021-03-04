namespace System.Text.RegularExpressions.Syntax
{
	internal abstract class CompositeExpression : Expression
	{
		private ExpressionCollection expressions;

		protected ExpressionCollection Expressions => (ExpressionCollection)/*Error near IL_0001: Stack underflow*/;

		public CompositeExpression()
		{
		}

		protected void GetWidth(out int min, out int max, int count)
		{
		}

		public override bool IsComplex()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
