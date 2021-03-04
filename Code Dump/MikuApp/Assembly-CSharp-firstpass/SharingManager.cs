using System;
using System.Runtime.CompilerServices;
using Prime31;

public class SharingManager : AbstractManager
{
	public static event Action<string> sharingFinishedWithActivityTypeEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	public static event Action sharingCancelledEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	static SharingManager()
	{
	}

	private void sharingFinishedWithActivityType(string activityType)
	{
	}

	private void sharingCancelled(string empty)
	{
	}
}
