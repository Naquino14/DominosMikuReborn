using System.Collections;

namespace System.Text.RegularExpressions
{
	internal class PatternCompiler : ICompiler
	{
		private class PatternLinkStack : LinkStack
		{
			private struct Link
			{
				public int base_addr;

				public int offset_addr;
			}

			private Link link;

			public int BaseAddress
			{
				set
				{
				}
			}

			public int OffsetAddress
			{
				get
				{
					return (int)/*Error near IL_0001: Stack underflow*/;
				}
				set
				{
				}
			}

			public int GetOffset(int target_addr)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			protected override object GetCurrent()
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}

			protected override void SetCurrent(object l)
			{
			}
		}

		private ArrayList pgm;

		private int CurrentAddress => (int)/*Error near IL_0001: Stack underflow*/;

		public static ushort EncodeOp(OpCode op, OpFlags flags)
		{
			return (ushort)/*Error near IL_0001: Stack underflow*/;
		}

		public IMachineFactory GetMachineFactory()
		{
			return (IMachineFactory)/*Error near IL_0001: Stack underflow*/;
		}

		public void EmitFalse()
		{
		}

		public void EmitTrue()
		{
		}

		private void EmitCount(int count)
		{
		}

		public void EmitCharacter(char c, bool negate, bool ignore, bool reverse)
		{
		}

		public void EmitCategory(Category cat, bool negate, bool reverse)
		{
		}

		public void EmitNotCategory(Category cat, bool negate, bool reverse)
		{
		}

		public void EmitRange(char lo, char hi, bool negate, bool ignore, bool reverse)
		{
		}

		public void EmitSet(char lo, BitArray set, bool negate, bool ignore, bool reverse)
		{
		}

		public void EmitString(string str, bool ignore, bool reverse)
		{
		}

		public void EmitPosition(Position pos)
		{
		}

		public void EmitOpen(int gid)
		{
		}

		public void EmitClose(int gid)
		{
		}

		public void EmitBalanceStart(int gid, int balance, bool capture, LinkRef tail)
		{
		}

		public void EmitBalance()
		{
		}

		public void EmitReference(int gid, bool ignore, bool reverse)
		{
		}

		public void EmitIfDefined(int gid, LinkRef tail)
		{
		}

		public void EmitSub(LinkRef tail)
		{
		}

		public void EmitTest(LinkRef yes, LinkRef tail)
		{
		}

		public void EmitBranch(LinkRef next)
		{
		}

		public void EmitJump(LinkRef target)
		{
		}

		public void EmitRepeat(int min, int max, bool lazy, LinkRef until)
		{
		}

		public void EmitUntil(LinkRef repeat)
		{
		}

		public void EmitFastRepeat(int min, int max, bool lazy, LinkRef tail)
		{
		}

		public void EmitIn(LinkRef tail)
		{
		}

		public void EmitAnchor(bool reverse, int offset, LinkRef tail)
		{
		}

		public void EmitInfo(int count, int min, int max)
		{
		}

		public LinkRef NewLink()
		{
			return (LinkRef)/*Error near IL_0001: Stack underflow*/;
		}

		public void ResolveLink(LinkRef lref)
		{
		}

		public void EmitBranchEnd()
		{
		}

		public void EmitAlternationEnd()
		{
		}

		private static OpFlags MakeFlags(bool negate, bool ignore, bool reverse, bool lazy)
		{
			return (OpFlags)/*Error near IL_0001: Stack underflow*/;
		}

		private void Emit(OpCode op)
		{
		}

		private void Emit(OpCode op, OpFlags flags)
		{
		}

		private void Emit(ushort word)
		{
		}

		private void BeginLink(LinkRef lref)
		{
		}

		private void EmitLink(LinkRef lref)
		{
		}
	}
}
