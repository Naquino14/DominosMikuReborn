namespace System.Runtime.Serialization
{
	internal class DelayedFixupRecord : BaseFixupRecord
	{
		public string _memberName;

		public DelayedFixupRecord(ObjectRecord objectToBeFixed, string memberName, ObjectRecord objectRequired)
		{
		}

		protected override void FixupImpl(ObjectManager manager)
		{
		}
	}
}
