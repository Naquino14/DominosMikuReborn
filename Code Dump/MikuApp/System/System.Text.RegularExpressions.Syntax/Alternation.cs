namespace System.Text.RegularExpressions.Syntax
{
	internal class Alternation : CompositeExpression
	{
		public ExpressionCollection Alternatives => (ExpressionCollection)/*Error near IL_0001: Stack underflow*/;

		public void AddAlternative(Expression e)
		{
		}

		public override void Compile(ICompiler cmp, bool reverse)
		{
		}

		public override void GetWidth(out int min, out int max)
		{
		}
	}
}
