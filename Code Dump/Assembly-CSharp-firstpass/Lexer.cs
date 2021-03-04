using System;
using System.IO;
using System.Text;

namespace LitJson
{
	// Token: 0x0200001B RID: 27
	internal class Lexer
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x0000262C File Offset: 0x0000082C
		public Lexer(TextReader reader)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002634 File Offset: 0x00000834
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002638 File Offset: 0x00000838
		public bool AllowComments
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002640 File Offset: 0x00000840
		public bool AllowSingleQuotedStrings
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002644 File Offset: 0x00000844
		public bool EndOfInput
		{
			get
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002648 File Offset: 0x00000848
		public int Token
		{
			get
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000264C File Offset: 0x0000084C
		public string StringValue
		{
			get
			{
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002650 File Offset: 0x00000850
		private static int HexValue(int digit)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002654 File Offset: 0x00000854
		private static void PopulateFsmTables()
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002658 File Offset: 0x00000858
		private static char ProcessEscChar(int esc_char)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000265C File Offset: 0x0000085C
		private static bool State1(FsmContext ctx)
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002660 File Offset: 0x00000860
		private static bool State2(FsmContext ctx)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002664 File Offset: 0x00000864
		private static bool State3(FsmContext ctx)
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002668 File Offset: 0x00000868
		private static bool State4(FsmContext ctx)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000266C File Offset: 0x0000086C
		private static bool State5(FsmContext ctx)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002670 File Offset: 0x00000870
		private static bool State6(FsmContext ctx)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002674 File Offset: 0x00000874
		private static bool State7(FsmContext ctx)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002678 File Offset: 0x00000878
		private static bool State8(FsmContext ctx)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000267C File Offset: 0x0000087C
		private static bool State9(FsmContext ctx)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002680 File Offset: 0x00000880
		private static bool State10(FsmContext ctx)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002684 File Offset: 0x00000884
		private static bool State11(FsmContext ctx)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002688 File Offset: 0x00000888
		private static bool State12(FsmContext ctx)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000268C File Offset: 0x0000088C
		private static bool State13(FsmContext ctx)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002690 File Offset: 0x00000890
		private static bool State14(FsmContext ctx)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002694 File Offset: 0x00000894
		private static bool State15(FsmContext ctx)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002698 File Offset: 0x00000898
		private static bool State16(FsmContext ctx)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000269C File Offset: 0x0000089C
		private static bool State17(FsmContext ctx)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000026A0 File Offset: 0x000008A0
		private static bool State18(FsmContext ctx)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000026A4 File Offset: 0x000008A4
		private static bool State19(FsmContext ctx)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000026A8 File Offset: 0x000008A8
		private static bool State20(FsmContext ctx)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000026AC File Offset: 0x000008AC
		private static bool State21(FsmContext ctx)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000026B0 File Offset: 0x000008B0
		private static bool State22(FsmContext ctx)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000026B4 File Offset: 0x000008B4
		private static bool State23(FsmContext ctx)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000026B8 File Offset: 0x000008B8
		private static bool State24(FsmContext ctx)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000026BC File Offset: 0x000008BC
		private static bool State25(FsmContext ctx)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000026C0 File Offset: 0x000008C0
		private static bool State26(FsmContext ctx)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000026C4 File Offset: 0x000008C4
		private static bool State27(FsmContext ctx)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000026C8 File Offset: 0x000008C8
		private static bool State28(FsmContext ctx)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000026CC File Offset: 0x000008CC
		private bool GetChar()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000026D0 File Offset: 0x000008D0
		private int NextChar()
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000026D4 File Offset: 0x000008D4
		public bool NextToken()
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000026D8 File Offset: 0x000008D8
		private void UngetChar()
		{
		}

		// Token: 0x040000A5 RID: 165
		private static int[] fsm_return_table;

		// Token: 0x040000A6 RID: 166
		private static Lexer.StateHandler[] fsm_handler_table;

		// Token: 0x040000A7 RID: 167
		private bool allow_comments;

		// Token: 0x040000A8 RID: 168
		private bool allow_single_quoted_strings;

		// Token: 0x040000A9 RID: 169
		private bool end_of_input;

		// Token: 0x040000AA RID: 170
		private FsmContext fsm_context;

		// Token: 0x040000AB RID: 171
		private int input_buffer;

		// Token: 0x040000AC RID: 172
		private int input_char;

		// Token: 0x040000AD RID: 173
		private TextReader reader;

		// Token: 0x040000AE RID: 174
		private int state;

		// Token: 0x040000AF RID: 175
		private StringBuilder string_buffer;

		// Token: 0x040000B0 RID: 176
		private string string_value;

		// Token: 0x040000B1 RID: 177
		private int token;

		// Token: 0x040000B2 RID: 178
		private int unichar;

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000340 RID: 832
		private delegate bool StateHandler(FsmContext ctx);
	}
}
