namespace System.Text.RegularExpressions.Syntax
{
	internal class Repetition : CompositeExpression
	{
		private int min;

		private int max;

		private bool lazy;

		public Expression Expression
		{
			get
			{
				return (Expression)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public int Minimum => (int)/*Error near IL_0001: Stack underflow*/;

		public Repetition(int min, int max, bool lazy)
		{
		}

		public override void Compile(ICompiler cmp, bool reverse)
		{
		}

		public override void GetWidth(out int min, out int max)
		{
		}

		public override AnchorInfo GetAnchorInfo(bool reverse)
		{
			return (AnchorInfo)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
