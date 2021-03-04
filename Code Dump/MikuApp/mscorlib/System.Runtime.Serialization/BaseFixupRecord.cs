namespace System.Runtime.Serialization
{
	internal abstract class BaseFixupRecord
	{
		protected internal ObjectRecord ObjectToBeFixed;

		protected internal ObjectRecord ObjectRequired;

		public BaseFixupRecord NextSameContainer;

		public BaseFixupRecord NextSameRequired;

		public BaseFixupRecord(ObjectRecord objectToBeFixed, ObjectRecord objectRequired)
		{
		}

		public bool DoFixup(ObjectManager manager, bool strict)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		protected abstract void FixupImpl(ObjectManager manager);
	}
}
