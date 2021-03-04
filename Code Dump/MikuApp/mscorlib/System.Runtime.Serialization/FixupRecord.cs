using System.Reflection;

namespace System.Runtime.Serialization
{
	internal class FixupRecord : BaseFixupRecord
	{
		public MemberInfo _member;

		public FixupRecord(ObjectRecord objectToBeFixed, MemberInfo member, ObjectRecord objectRequired)
		{
		}

		protected override void FixupImpl(ObjectManager manager)
		{
		}
	}
}
