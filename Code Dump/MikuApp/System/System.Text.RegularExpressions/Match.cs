namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single regular expression match.</summary>
	[Serializable]
	public class Match : Group
	{
		private Regex regex;

		private IMachine machine;

		private int text_length;

		private GroupCollection groups;

		private static Match empty;

		/// <summary>Gets the empty group. All failed matches return this empty match.</summary>
		/// <returns>An empty <see cref="T:System.Text.RegularExpressions.Match" />.</returns>
		public static Match Empty => (Match)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a collection of groups matched by the regular expression.</summary>
		/// <returns>The character groups matched by the pattern.</returns>
		public virtual GroupCollection Groups => (GroupCollection)/*Error near IL_0001: Stack underflow*/;

		internal Regex Regex => (Regex)/*Error near IL_0001: Stack underflow*/;

		private Match()
		{
		}

		internal Match(Regex regex, IMachine machine, string text, int text_length, int n_groups, int index, int length)
		{
		}

		internal Match(Regex regex, IMachine machine, string text, int text_length, int n_groups, int index, int length, int n_caps)
		{
		}

		/// <summary>Returns a new <see cref="T:System.Text.RegularExpressions.Match" /> object with the results for the next match, starting at the position at which the last match ended (at the character after the last matched character).</summary>
		/// <returns>The next regular expression match.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		public Match NextMatch()
		{
			return (Match)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
