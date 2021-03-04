namespace System.Text.RegularExpressions.Syntax
{
	internal abstract class Assertion : CompositeExpression
	{
		public Expression TrueExpression
		{
			get
			{
				return (Expression)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Expression FalseExpression
		{
			get
			{
				return (Expression)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Assertion()
		{
		}

		public override void GetWidth(out int min, out int max)
		{
		}
	}
}
