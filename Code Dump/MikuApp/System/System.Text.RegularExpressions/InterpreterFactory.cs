using System.Collections;

namespace System.Text.RegularExpressions
{
	internal class InterpreterFactory : IMachineFactory
	{
		private IDictionary mapping;

		private ushort[] pattern;

		private string[] namesMapping;

		private int gap;

		public int GroupCount => (int)/*Error near IL_0001: Stack underflow*/;

		public int Gap
		{
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public IDictionary Mapping
		{
			get
			{
				return (IDictionary)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public string[] NamesMapping
		{
			get
			{
				return (string[])/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public InterpreterFactory(ushort[] pattern)
		{
		}

		public IMachine NewInstance()
		{
			return (IMachine)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
