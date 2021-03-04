using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TwitterManager : MonoBehaviour
{
	public static event Action loginSucceededEvent
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

	public static event Action<string> loginFailedEvent
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

	public static event Action postSucceededEvent
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

	public static event Action<string> postFailedEvent
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

	public static event Action<List<object>> homeTimelineReceivedEvent
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

	public static event Action<string> homeTimelineFailedEvent
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

	public static event Action<object> requestDidFinishEvent
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

	public static event Action<string> requestDidFailEvent
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

	public static event Action<bool> tweetSheetCompletedEvent
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

	static TwitterManager()
	{
	}

	public void twitterLoginSucceeded(string empty)
	{
	}

	public void twitterLoginDidFail(string error)
	{
	}

	public void twitterPostSucceeded(string empty)
	{
	}

	public void twitterPostDidFail(string error)
	{
	}

	public void twitterHomeTimelineDidFail(string error)
	{
	}

	public void twitterHomeTimelineDidFinish(string results)
	{
	}

	public void twitterRequestDidFinish(string results)
	{
	}

	public void twitterRequestDidFail(string error)
	{
	}

	public void tweetSheetCompleted(string oneOrZero)
	{
	}
}
