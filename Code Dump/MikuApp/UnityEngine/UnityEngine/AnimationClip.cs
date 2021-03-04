using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class AnimationClip : Motion
	{
		public float length
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		internal float startTime
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		internal float stopTime
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public float frameRate
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public WrapMode wrapMode
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
		private static extern void Internal_CreateAnimationClip([Writable] AnimationClip self);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve);

		public void EnsureQuaternionContinuity()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_EnsureQuaternionContinuity(AnimationClip self);

		public void ClearCurves()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_ClearCurves(AnimationClip self);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void AddEvent(AnimationEvent evt);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_localBounds(out Bounds value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_localBounds(ref Bounds value);
	}
}
