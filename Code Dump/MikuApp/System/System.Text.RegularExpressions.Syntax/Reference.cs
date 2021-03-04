namespace System.Text.RegularExpressions.Syntax
{
	internal class Reference : Expression
	{
		private CapturingGroup group;

		private bool ignore;

		public CapturingGroup CapturingGroup
		{
			get
			{
				return (CapturingGroup)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public bool IgnoreCase => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public Reference(bool ignore)
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
	}
}
