using System;

namespace UnityEngineInternal
{
	[Serializable]
	[AttributeUsage(AttributeTargets.Method)]
	public class TypeInferenceRuleAttribute : Attribute
	{
		private readonly string _rule;

		public TypeInferenceRuleAttribute(TypeInferenceRules rule)
		{
		}

		public TypeInferenceRuleAttribute(string rule)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
