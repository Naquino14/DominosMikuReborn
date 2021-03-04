namespace System.Text.RegularExpressions.Syntax
{
	internal abstract class Expression
	{
		public abstract void Compile(ICompiler cmp, bool reverse);

		public abstract void GetWidth(out int min, out int max);

		public int GetFixedWidth()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public virtual AnchorInfo GetAnchorInfo(bool reverse)
		{
			return (AnchorInfo)/*Error near IL_0001: Stack underflow*/;
		}

		public abstract bool IsComplex();
	}
}
