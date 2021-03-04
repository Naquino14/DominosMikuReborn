using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class AnimationState : TrackedReference
	{
		public WrapMode wrapMode
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float time
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float speed
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float length
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public int layer
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public AnimationClip clip
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public string name
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public AnimationBlendMode blendMode
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void AddMixingTransform(Transform mix, bool recursive);
	}
}
