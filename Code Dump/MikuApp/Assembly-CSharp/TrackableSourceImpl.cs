using System;
using System.Runtime.CompilerServices;

public class TrackableSourceImpl : TrackableSource
{
	public unsafe IntPtr TrackableSourcePtr
	{
		[CompilerGenerated]
		get
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public TrackableSourceImpl(IntPtr trackableSourcePtr)
	{
	}
}
