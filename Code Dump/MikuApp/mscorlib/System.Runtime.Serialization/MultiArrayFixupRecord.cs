namespace System.Runtime.Serialization
{
	internal class MultiArrayFixupRecord : BaseFixupRecord
	{
		private int[] _indices;

		public MultiArrayFixupRecord(ObjectRecord objectToBeFixed, int[] indices, ObjectRecord objectRequired)
		{
		}

		protected override void FixupImpl(ObjectManager manager)
		{
		}
	}
}
