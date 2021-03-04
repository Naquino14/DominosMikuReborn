using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public class SkinnedMeshRenderer : Renderer
	{
		public Transform[] bones
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Transform rootBone
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public SkinQuality quality
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Mesh sharedMesh
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		[Obsolete("Has no effect.")]
		public bool skinNormals
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public bool updateWhenOffscreen
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Bounds localBounds
		{
			get
			{
				return (Bounds)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_localBounds(out Bounds value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_localBounds(ref Bounds value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void BakeMesh(Mesh mesh);
	}
}
