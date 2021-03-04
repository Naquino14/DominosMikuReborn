using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class AssetBundleCreateRequest : AsyncOperation
	{
		public AssetBundle assetBundle
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}
	}
}
