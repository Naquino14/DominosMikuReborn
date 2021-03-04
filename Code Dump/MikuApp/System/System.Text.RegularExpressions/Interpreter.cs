namespace System.Text.RegularExpressions
{
	internal class Interpreter : BaseMachine
	{
		private struct IntStack
		{
			private int[] values;

			private int count;

			public int Count
			{
				get
				{
					return (int)/*Error near IL_0001: Stack underflow*/;
				}
				set
				{
				}
			}

			public int Pop()
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			public void Push(int value)
			{
			}
		}

		private enum Mode
		{
			Search,
			Match,
			Count
		}

		private class RepeatContext
		{
			private int start;

			private int min;

			private int max;

			private bool lazy;

			private int expr_pc;

			private RepeatContext previous;

			private int count;

			public int Count
			{
				get
				{
					return (int)/*Error near IL_0001: Stack underflow*/;
				}
				set
				{
				}
			}

			public int Start
			{
				get
				{
					return (int)/*Error near IL_0001: Stack underflow*/;
				}
				set
				{
				}
			}

			public bool IsMinimum => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

			public bool IsMaximum => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

			public bool IsLazy => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

			public int Expression => (int)/*Error near IL_0001: Stack underflow*/;

			public RepeatContext Previous => (RepeatContext)/*Error near IL_0001: Stack underflow*/;

			public RepeatContext(RepeatContext previous, int min, int max, bool lazy, int expr_pc)
			{
			}
		}

		private ushort[] program;

		private int program_start;

		private string text;

		private int text_end;

		private int group_count;

		private int match_min;

		private QuickSearch qs;

		private int scan_ptr;

		private RepeatContext repeat;

		private RepeatContext fast;

		private IntStack stack;

		private RepeatContext deep;

		private Mark[] marks;

		private int mark_start;

		private int mark_end;

		private int[] groups;

		public Interpreter(ushort[] program)
		{
		}

		private int ReadProgramCount(int ptr)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override Match Scan(Regex regex, string text, int start, int end)
		{
			return (Match)/*Error near IL_0001: Stack underflow*/;
		}

		private void Reset()
		{
		}

		private bool Eval(Mode mode, ref int ref_ptr, int pc)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private bool EvalChar(Mode mode, ref int ptr, ref int pc, bool multi)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private bool TryMatch(ref int ref_ptr, int pc)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private bool IsPosition(Position pos, int ptr)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private bool IsWordChar(char c)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private string GetString(int pc)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private void Open(int gid, int ptr)
		{
		}

		private void Close(int gid, int ptr)
		{
		}

		private bool Balance(int gid, int balance_gid, bool capture, int ptr)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private int Checkpoint()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private void Backtrack(int cp)
		{
		}

		private void ResetGroups()
		{
		}

		private int GetLastDefined(int gid)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int CreateMark(int previous)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private void GetGroupInfo(int gid, out int first_mark_index, out int n_caps)
		{
		}

		private void PopulateGroup(Group g, int first_mark_index, int n_caps)
		{
		}

		private Match GenerateMatch(Regex regex)
		{
			return (Match)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
