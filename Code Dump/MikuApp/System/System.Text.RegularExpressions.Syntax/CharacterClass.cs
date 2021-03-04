using System.Collections;

namespace System.Text.RegularExpressions.Syntax
{
	internal class CharacterClass : Expression
	{
		private const int distance_between_upper_and_lower_case = 32;

		private static Interval upper_case_characters;

		private bool negate;

		private bool ignore;

		private BitArray pos_cats;

		private BitArray neg_cats;

		private IntervalCollection intervals;

		public CharacterClass(bool negate, bool ignore)
		{
		}

		public CharacterClass(Category cat, bool negate)
		{
		}

		public void AddCategory(Category cat, bool negate)
		{
		}

		public void AddCharacter(char c)
		{
		}

		public void AddRange(char lo, char hi)
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

		private static double GetIntervalCost(Interval i)
		{
			return (double)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
