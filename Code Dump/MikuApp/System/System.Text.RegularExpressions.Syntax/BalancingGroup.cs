namespace System.Text.RegularExpressions.Syntax
{
	internal class BalancingGroup : CapturingGroup
	{
		private CapturingGroup balance;

		public CapturingGroup Balance
		{
			set
			{
			}
		}

		public override void Compile(ICompiler cmp, bool reverse)
		{
		}
	}
}
