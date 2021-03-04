using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prime31;
using UnityEngine;

public class EtceteraManager : AbstractManager
{
	public delegate void EceteraTextureDelegate(Texture2D texture);

	public delegate void EceteraTextureFailedDelegate(string error);

	public static string pushIOApiKey;

	public static string[] pushIOCategories;

	public static string deviceToken
	{
		[CompilerGenerated]
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static event Action dismissingViewControllerEvent
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

	public static event Action imagePickerCancelledEvent
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

	public static event Action<string> imagePickerChoseImageEvent
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

	public static event Action saveImageToPhotoAlbumSucceededEvent
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

	public static event Action<string> saveImageToPhotoAlbumFailedEvent
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

	public static event Action<string> alertButtonClickedEvent
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

	public static event Action promptCancelledEvent
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

	public static event Action<string> singleFieldPromptTextEnteredEvent
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

	public static event Action<string, string> twoFieldPromptTextEnteredEvent
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

	public static event Action<string> remoteRegistrationSucceededEvent
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

	public static event Action<string> remoteRegistrationFailedEvent
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

	public static event Action urbanAirshipRegistrationSucceededEvent
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

	public static event Action<string> urbanAirshipRegistrationFailedEvent
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

	public static event Action<string> pushIORegistrationCompletedEvent
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

	public static event Action<IDictionary> remoteNotificationReceivedEvent
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

	public static event Action<IDictionary> remoteNotificationReceivedAtLaunchEvent
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

	public static event Action<IDictionary> localNotificationWasReceivedEvent
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

	public static event Action<IDictionary> localNotificationWasReceivedAtLaunchEvent
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

	public static event Action<string> mailComposerFinishedEvent
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

	public static event Action<string> smsComposerFinishedEvent
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

	static EtceteraManager()
	{
	}

	public void dismissingViewController()
	{
	}

	public void imagePickerDidCancel(string empty)
	{
	}

	public void imageSavedToDocuments(string filePath)
	{
	}

	public void saveImageToPhotoAlbumFailed(string error)
	{
	}

	public void saveImageToPhotoAlbumSucceeded(string empty)
	{
	}

	[DebuggerHidden]
	public static IEnumerator textureFromFileAtPath(string filePath, EceteraTextureDelegate del, EceteraTextureFailedDelegate errorDel)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	public void alertViewClickedButton(string buttonTitle)
	{
	}

	public void alertPromptCancelled(string empty)
	{
	}

	public void alertPromptEnteredText(string text)
	{
	}

	public void remoteRegistrationDidSucceed(string deviceToken)
	{
	}

	[DebuggerHidden]
	private IEnumerator registerDeviceWithPushIO()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	public void remoteRegistrationDidFail(string error)
	{
	}

	public void urbanAirshipRegistrationDidSucceed(string empty)
	{
	}

	public void urbanAirshipRegistrationDidFail(string error)
	{
	}

	public void remoteNotificationWasReceived(string json)
	{
	}

	public void remoteNotificationWasReceivedAtLaunch(string json)
	{
	}

	public void localNotificationWasReceived(string json)
	{
	}

	public void localNotificationWasReceivedAtLaunch(string json)
	{
	}

	public void mailComposerFinishedWithResult(string result)
	{
	}

	public void smsComposerFinishedWithResult(string result)
	{
	}
}
