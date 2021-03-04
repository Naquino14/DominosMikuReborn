using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Prime31;

public class FacebookManager : AbstractManager
{
	public static event Action sessionOpenedEvent
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

	public static event Action preLoginSucceededEvent
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

	public static event Action<string> dialogCompletedWithUrlEvent
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

	public static event Action<string> dialogFailedEvent
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

	public static event Action<object> graphRequestCompletedEvent
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

	public static event Action<string> graphRequestFailedEvent
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

	public static event Action<object> restRequestCompletedEvent
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

	public static event Action<string> restRequestFailedEvent
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

	public static event Action<bool> facebookComposerCompletedEvent
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

	public static event Action reauthorizationSucceededEvent
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

	public static event Action<string> reauthorizationFailedEvent
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

	public static event Action<string> shareDialogFailedEvent
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

	public static event Action<Dictionary<string, object>> shareDialogSucceededEvent
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

	static FacebookManager()
	{
	}

	public void sessionOpened(string accessToken)
	{
	}

	public void loginFailed(string error)
	{
	}

	public void dialogCompletedWithUrl(string url)
	{
	}

	public void dialogFailedWithError(string error)
	{
	}

	public void graphRequestCompleted(string json)
	{
	}

	public void graphRequestFailed(string error)
	{
	}

	public void restRequestCompleted(string json)
	{
	}

	public void restRequestFailed(string error)
	{
	}

	public void facebookComposerCompleted(string result)
	{
	}

	public void reauthorizationSucceeded(string empty)
	{
	}

	public void reauthorizationFailed(string error)
	{
	}

	public void shareDialogFailed(string error)
	{
	}

	public void shareDialogSucceeded(string json)
	{
	}
}
