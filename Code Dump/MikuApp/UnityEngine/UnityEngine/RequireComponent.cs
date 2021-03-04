using System;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class RequireComponent : Attribute
	{
		public Type m_Type0;

		public Type m_Type1;

		public Type m_Type2;

		public RequireComponent(Type requiredComponent)
		{
		}
	}
}
