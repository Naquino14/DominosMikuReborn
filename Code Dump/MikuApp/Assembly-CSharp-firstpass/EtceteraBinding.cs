using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class EtceteraBinding
{
	[DebuggerHidden]
	public static IEnumerator takeScreenShot(string filename)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DllImport("__Internal")]
	private static extern bool _etceteraApplicationCanOpenUrl(string url);

	public static bool applicationCanOpenUrl(string url)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	[DllImport("__Internal")]
	private static extern string _etceteraGetCurrentLanguage();

	public static string getCurrentLanguage()
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	[DllImport("__Internal")]
	private static extern string _etceteraGetLocalizedString(string key, string defaultValue);

	public static string getLocalizedString(string key, string defaultValue)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	[Obsolete("Use the _etceteraShowAlertWithTitleMessageAndButtons. This method will be removed.")]
	public static void showAlertWithTitleMessageAndButton(string title, string message, string buttonTitle)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowAlertWithTitleMessageAndButtons(string title, string message, string buttons);

	public static void showAlertWithTitleMessageAndButtons(string title, string message, string[] buttons)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSetPromptColors(uint borderColor, uint gradientStopOne, uint gradientStopTwo);

	public static void setPromptColors(uint borderColor, uint gradientStopOne, uint gradientStopTwo)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowPromptWithOneField(string title, string message, string placeHolder, bool autocomplete);

	public static void showPromptWithOneField(string title, string message, string placeHolder, bool autocomplete)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowPromptWithTwoFields(string title, string message, string placeHolder1, string placeHolder2, bool autocomplete);

	public static void showPromptWithTwoFields(string title, string message, string placeHolder1, string placeHolder2, bool autocomplete)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowWebPage(string url, bool showControls);

	public static void showWebPage(string url, bool showControls)
	{
	}

	[DllImport("__Internal")]
	private static extern bool _etceteraIsEmailAvailable();

	public static bool isEmailAvailable()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	[DllImport("__Internal")]
	private static extern bool _etceteraIsSMSAvailable();

	public static bool isSMSAvailable()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowMailComposer(string toAddress, string subject, string body, bool isHTML);

	public static void showMailComposer(string toAddress, string subject, string body, bool isHTML)
	{
	}

	[DebuggerHidden]
	public static IEnumerator showMailComposerWithScreenshot(MonoBehaviour mono, string toAddress, string subject, string body, bool isHTML)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowMailComposerWithAttachment(string filePathToAttachment, string attachementMimeType, string attachmentFilename, string toAddress, string subject, string body, bool isHTML);

	public static void showMailComposerWithAttachment(string filePathToAttachment, string attachmentMimeType, string attachmentFilename, string toAddress, string subject, string body, bool isHTML)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowSMSComposer(string recipients, string body);

	public static void showSMSComposer(string body)
	{
	}

	public static void showSMSComposer(string[] recipients, string body)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowActivityView();

	public static void showActivityView()
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraHideActivityView();

	public static void hideActivityView()
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowBezelActivityViewWithLabel(string label);

	public static void showBezelActivityViewWithLabel(string label)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowBezelActivityViewWithImage(string label, string imagePath);

	public static void showBezelActivityViewWithImage(string label, string imagePath)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraAskForReview(int launchCount, float hoursBetweenPrompts, string title, string message, string iTunesAppId);

	public static void askForReview(int launchCount, float hoursBetweenPrompts, string title, string message, string iTunesAppId)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraAskForReviewImmediately(string title, string message, string iTunesAppId);

	public static void askForReview(string title, string message, string iTunesAppId)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSetPopoverPoint(float xPos, float yPos);

	public static void setPopoverPoint(float xPos, float yPos)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraPromptForPhoto(float scaledToSize, int promptType, float jpegCompression, bool allowsEditing);

	public static void promptForPhoto(float scaledToSize)
	{
	}

	public static void promptForPhoto(float scaledToSize, PhotoPromptType promptType)
	{
	}

	public static void promptForPhoto(float scaledToSize, PhotoPromptType promptType, float jpegCompression, bool allowsEditing)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraResizeImageAtPath(string filePath, float width, float height);

	public static void resizeImageAtPath(string filePath, float width, float height)
	{
	}

	[DllImport("__Internal")]
	private static extern string _etceteraGetImageSize(string filePath);

	public static Vector2 getImageSize(string filePath)
	{
		return (Vector2)/*Error near IL_0001: Stack underflow*/;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSaveImageToPhotoAlbum(string filePath);

	public static void saveImageToPhotoAlbum(string filePath)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSetUrbanAirshipCredentials(string appKey, string appSecret, string alias);

	public static void setUrbanAirshipCredentials(string appKey, string appSecret)
	{
	}

	public static void setUrbanAirshipCredentials(string appKey, string appSecret, string alias)
	{
	}

	public static void setPushIOCredentials(string apiKey)
	{
	}

	public static void setPushIOCredentials(string apiKey, string[] categories)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraRegisterForRemoteNotifications(int types);

	public static void registerForRemoteNotifcations(P31RemoteNotificationType types)
	{
	}

	[DllImport("__Internal")]
	private static extern int _etceteraGetEnabledRemoteNotificationTypes();

	public static P31RemoteNotificationType getEnabledRemoteNotificationTypes()
	{
		return (P31RemoteNotificationType)/*Error near IL_0001: Stack underflow*/;
	}

	[DllImport("__Internal")]
	private static extern int _etceteraGetBadgeCount();

	public static int getBadgeCount()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSetBadgeCount(int badgeCount);

	public static void setBadgeCount(int badgeCount)
	{
	}

	[DllImport("__Internal")]
	private static extern int _etceteraGetStatusBarOrientation();

	public static UIInterfaceOrientation getStatusBarOrientation()
	{
		return (UIInterfaceOrientation)/*Error near IL_0001: Stack underflow*/;
	}

	[DllImport("__Internal")]
	private static extern string _etceteraUniqueDeviceIdentifier();

	public static string uniqueDeviceIdentifier()
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	[DllImport("__Internal")]
	private static extern string _etceteraUniqueGlobalDeviceIdentifier();

	public static string uniqueGlobalDeviceIdentifier()
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewShow(int x, int y, int width, int height);

	public static void inlineWebViewShow(int x, int y, int width, int height)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewClose();

	public static void inlineWebViewClose()
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewSetUrl(string url);

	public static void inlineWebViewSetUrl(string url)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewSetFrame(int x, int y, int width, int height);

	public static void inlineWebViewSetFrame(int x, int y, int width, int height)
	{
	}
}
