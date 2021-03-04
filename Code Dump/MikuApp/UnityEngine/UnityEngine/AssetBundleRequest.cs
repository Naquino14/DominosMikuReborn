using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[StructLayout(0)]
	public sealed class AssetBundleRequest : AsyncOperation
	{
		private AssetBundle m_AssetBundle;

		private string m_Path;

		private Type m_Type;
	}
}
