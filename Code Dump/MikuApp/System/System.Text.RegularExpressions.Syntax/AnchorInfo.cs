namespace System.Text.RegularExpressions.Syntax
{
	internal class AnchorInfo
	{
		private Expression expr;

		private Position pos;

		private int offset;

		private string str;

		private int width;

		private bool ignore;

		public int Offset => (int)/*Error near IL_0001: Stack underflow*/;

		public int Width => (int)/*Error near IL_0001: Stack underflow*/;

		public int Length => (int)/*Error near IL_0001: Stack underflow*/;

		public bool IsUnknownWidth => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsComplete => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public string Substring => (string)/*Error near IL_0001: Stack underflow*/;

		public bool IgnoreCase => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public Position Position => (Position)/*Error near IL_0001: Stack underflow*/;

		public bool IsSubstring => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsPosition => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public AnchorInfo(Expression expr, int width)
		{
		}

		public AnchorInfo(Expression expr, int offset, int width, string str, bool ignore)
		{
		}

		public AnchorInfo(Expression expr, int offset, int width, Position pos)
		{
		}

		public Interval GetInterval(int start)
		{
			return (Interval)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
