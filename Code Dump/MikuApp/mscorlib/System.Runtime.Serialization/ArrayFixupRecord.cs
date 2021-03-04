namespace System.Runtime.Serialization
{
	internal class ArrayFixupRecord : BaseFixupRecord
	{
		private int _index;

		public ArrayFixupRecord(ObjectRecord objectToBeFixed, int index, ObjectRecord objectRequired)
		{
		}

		protected override void FixupImpl(ObjectManager manager)
		{
		}
	}
}
