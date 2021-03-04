using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Animation : Behaviour, IEnumerable
	{
		private sealed class Enumerator : IEnumerator
		{
			private Animation m_Outer;

			private int m_CurrentIndex;

			public object Current => (object)/*Error near IL_0001: Stack underflow*/;

			internal Enumerator(Animation outer)
			{
			}

			public bool MoveNext()
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public void Reset()
			{
			}
		}

		public AnimationClip clip
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool playAutomatically
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
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

		public bool isPlaying
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public AnimationState this[string name] => (AnimationState)/*Error near IL_0001: Stack underflow*/;

		public bool animatePhysics
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		[Obsolete("Use cullingType instead")]
		public bool animateOnlyIfVisible
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public AnimationCullingType cullingType
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

		public void Stop()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Stop(Animation self);

		public void Stop(string name)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Internal_StopByName(string name);

		public void Rewind(string name)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Internal_RewindByName(string name);

		public void Rewind()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Rewind(Animation self);

		public void Sample()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Sample(Animation self);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern bool IsPlaying(string name);

		public bool Play()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool Play(PlayMode mode)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern bool Play(string animation, PlayMode mode);

		public bool Play(string animation)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void CrossFade(string animation, float fadeLength, PlayMode mode);

		public void CrossFade(string animation, float fadeLength)
		{
		}

		public void CrossFade(string animation)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Blend(string animation, float targetWeight, float fadeLength);

		public void Blend(string animation, float targetWeight)
		{
		}

		public void Blend(string animation)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode);

		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue)
		{
			return (AnimationState)/*Error near IL_0001: Stack underflow*/;
		}

		public AnimationState CrossFadeQueued(string animation, float fadeLength)
		{
			return (AnimationState)/*Error near IL_0001: Stack underflow*/;
		}

		public AnimationState CrossFadeQueued(string animation)
		{
			return (AnimationState)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode);

		public AnimationState PlayQueued(string animation, QueueMode queue)
		{
			return (AnimationState)/*Error near IL_0001: Stack underflow*/;
		}

		public AnimationState PlayQueued(string animation)
		{
			return (AnimationState)/*Error near IL_0001: Stack underflow*/;
		}

		public void AddClip(AnimationClip clip, string newName)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame);

		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void RemoveClip(AnimationClip clip);

		public void RemoveClip(string clipName)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern int GetClipCount();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void RemoveClip2(string clipName);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern bool PlayDefaultAnimation(PlayMode mode);

		public bool Play(AnimationPlayMode mode)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool Play(string animation, AnimationPlayMode mode)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void SyncLayer(int layer)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_SyncLayer(Animation self, int layer);

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern AnimationState GetState(string name);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern AnimationState GetStateAtIndex(int index);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern int GetStateCount();

		public AnimationClip GetClip(string name)
		{
			return (AnimationClip)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_localBounds(out Bounds value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_localBounds(ref Bounds value);
	}
}
