using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Attaches a modifier to parameters so that binding can work with parameter signatures in which the types have been modified.</summary>
	[Serializable]
	[ComVisible(true)]
	[DefaultMember("Item")]
	public struct ParameterModifier
	{
		private bool[] _byref;
	}
}
