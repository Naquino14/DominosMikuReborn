using System.Runtime.CompilerServices;

public abstract class TrackableImpl : Trackable
{
	public TrackableType Type
	{
		[CompilerGenerated]
		get
		{
			return (TrackableType)/*Error near IL_0001: Stack underflow*/;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public int ID
	{
		[CompilerGenerated]
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	protected TrackableImpl(string name, int id)
	{
	}
}
