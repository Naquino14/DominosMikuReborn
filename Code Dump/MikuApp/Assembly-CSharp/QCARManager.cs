using UnityEngine;

public abstract class QCARManager
{
	private static QCARManager sInstance;

	public static QCARManager Instance => (QCARManager)/*Error near IL_0001: Stack underflow*/;

	public abstract QCARBehaviour.WorldCenterMode WorldCenterMode
	{
		get;
		set;
	}

	public abstract TrackableBehaviour WorldCenter
	{
		get;
		set;
	}

	public abstract Camera ARCamera
	{
		get;
		set;
	}

	public abstract bool DrawVideoBackground
	{
		get;
		set;
	}

	public abstract bool Initialized
	{
		get;
	}

	public abstract bool Init();

	public abstract void Deinit();
}
