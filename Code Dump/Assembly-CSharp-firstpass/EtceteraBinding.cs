using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class EtceteraBinding
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
	[DebuggerHidden]
	public static IEnumerator takeScreenShot(string filename)
	{
	}

	// Token: 0x06000003 RID: 3
	[DllImport("__Internal")]
	private static extern bool _etceteraApplicationCanOpenUrl(string url);

	// Token: 0x06000004 RID: 4 RVA: 0x00002058 File Offset: 0x00000258
	public static bool applicationCanOpenUrl(string url)
	{
	}

	// Token: 0x06000005 RID: 5
	[DllImport("__Internal")]
	private static extern string _etceteraGetCurrentLanguage();

	// Token: 0x06000006 RID: 6 RVA: 0x0000205C File Offset: 0x0000025C
	public static string getCurrentLanguage()
	{
	}

	// Token: 0x06000007 RID: 7
	[DllImport("__Internal")]
	private static extern string _etceteraGetLocalizedString(string key, string defaultValue);

	// Token: 0x06000008 RID: 8 RVA: 0x00002060 File Offset: 0x00000260
	public static string getLocalizedString(string key, string defaultValue)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002064 File Offset: 0x00000264
	[Obsolete("Use the _etceteraShowAlertWithTitleMessageAndButtons. This method will be removed.")]
	public static void showAlertWithTitleMessageAndButton(string title, string message, string buttonTitle)
	{
	}

	// Token: 0x0600000A RID: 10
	[DllImport("__Internal")]
	private static extern void _etceteraShowAlertWithTitleMessageAndButtons(string title, string message, string buttons);

	// Token: 0x0600000B RID: 11 RVA: 0x00002068 File Offset: 0x00000268
	public static void showAlertWithTitleMessageAndButtons(string title, string message, string[] buttons)
	{
	}

	// Token: 0x0600000C RID: 12
	[DllImport("__Internal")]
	private static extern void _etceteraSetPromptColors(uint borderColor, uint gradientStopOne, uint gradientStopTwo);

	// Token: 0x0600000D RID: 13 RVA: 0x0000206C File Offset: 0x0000026C
	public static void setPromptColors(uint borderColor, uint gradientStopOne, uint gradientStopTwo)
	{
	}

	// Token: 0x0600000E RID: 14
	[DllImport("__Internal")]
	private static extern void _etceteraShowPromptWithOneField(string title, string message, string placeHolder, bool autocomplete);

	// Token: 0x0600000F RID: 15 RVA: 0x00002070 File Offset: 0x00000270
	public static void showPromptWithOneField(string title, string message, string placeHolder, bool autocomplete)
	{
	}

	// Token: 0x06000010 RID: 16
	[DllImport("__Internal")]
	private static extern void _etceteraShowPromptWithTwoFields(string title, string message, string placeHolder1, string placeHolder2, bool autocomplete);

	// Token: 0x06000011 RID: 17 RVA: 0x00002074 File Offset: 0x00000274
	public static void showPromptWithTwoFields(string title, string message, string placeHolder1, string placeHolder2, bool autocomplete)
	{
	}

	// Token: 0x06000012 RID: 18
	[DllImport("__Internal")]
	private static extern void _etceteraShowWebPage(string url, bool showControls);

	// Token: 0x06000013 RID: 19 RVA: 0x00002078 File Offset: 0x00000278
	public static void showWebPage(string url, bool showControls)
	{
	}

	// Token: 0x06000014 RID: 20
	[DllImport("__Internal")]
	private static extern bool _etceteraIsEmailAvailable();

	// Token: 0x06000015 RID: 21 RVA: 0x0000207C File Offset: 0x0000027C
	public static bool isEmailAvailable()
	{
	}

	// Token: 0x06000016 RID: 22
	[DllImport("__Internal")]
	private static extern bool _etceteraIsSMSAvailable();

	// Token: 0x06000017 RID: 23 RVA: 0x00002080 File Offset: 0x00000280
	public static bool isSMSAvailable()
	{
	}

	// Token: 0x06000018 RID: 24
	[DllImport("__Internal")]
	private static extern void _etceteraShowMailComposer(string toAddress, string subject, string body, bool isHTML);

	// Token: 0x06000019 RID: 25 RVA: 0x00002084 File Offset: 0x00000284
	public static void showMailComposer(string toAddress, string subject, string body, bool isHTML)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002088 File Offset: 0x00000288
	[DebuggerHidden]
	public static IEnumerator showMailComposerWithScreenshot(MonoBehaviour mono, string toAddress, string subject, string body, bool isHTML)
	{
	}

	// Token: 0x0600001B RID: 27
	[DllImport("__Internal")]
	private static extern void _etceteraShowMailComposerWithAttachment(string filePathToAttachment, string attachementMimeType, string attachmentFilename, string toAddress, string subject, string body, bool isHTML);

	// Token: 0x0600001C RID: 28 RVA: 0x0000208C File Offset: 0x0000028C
	public static void showMailComposerWithAttachment(string filePathToAttachment, string attachmentMimeType, string attachmentFilename, string toAddress, string subject, string body, bool isHTML)
	{
	}

	// Token: 0x0600001D RID: 29
	[DllImport("__Internal")]
	private static extern void _etceteraShowSMSComposer(string recipients, string body);

	// Token: 0x0600001E RID: 30 RVA: 0x00002090 File Offset: 0x00000290
	public static void showSMSComposer(string body)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002094 File Offset: 0x00000294
	public static void showSMSComposer(string[] recipients, string body)
	{
	}

	// Token: 0x06000020 RID: 32
	[DllImport("__Internal")]
	private static extern void _etceteraShowActivityView();

	// Token: 0x06000021 RID: 33 RVA: 0x00002098 File Offset: 0x00000298
	public static void showActivityView()
	{
	}

	// Token: 0x06000022 RID: 34
	[DllImport("__Internal")]
	private static extern void _etceteraHideActivityView();

	// Token: 0x06000023 RID: 35 RVA: 0x0000209C File Offset: 0x0000029C
	public static void hideActivityView()
	{
	}

	// Token: 0x06000024 RID: 36
	[DllImport("__Internal")]
	private static extern void _etceteraShowBezelActivityViewWithLabel(string label);

	// Token: 0x06000025 RID: 37 RVA: 0x000020A0 File Offset: 0x000002A0
	public static void showBezelActivityViewWithLabel(string label)
	{
	}

	// Token: 0x06000026 RID: 38
	[DllImport("__Internal")]
	private static extern void _etceteraShowBezelActivityViewWithImage(string label, string imagePath);

	// Token: 0x06000027 RID: 39 RVA: 0x000020A4 File Offset: 0x000002A4
	public static void showBezelActivityViewWithImage(string label, string imagePath)
	{
	}

	// Token: 0x06000028 RID: 40
	[DllImport("__Internal")]
	private static extern void _etceteraAskForReview(int launchCount, float hoursBetweenPrompts, string title, string message, string iTunesAppId);

	// Token: 0x06000029 RID: 41 RVA: 0x000020A8 File Offset: 0x000002A8
	public static void askForReview(int launchCount, float hoursBetweenPrompts, string title, string message, string iTunesAppId)
	{
	}

	// Token: 0x0600002A RID: 42
	[DllImport("__Internal")]
	private static extern void _etceteraAskForReviewImmediately(string title, string message, string iTunesAppId);

	// Token: 0x0600002B RID: 43 RVA: 0x000020AC File Offset: 0x000002AC
	public static void askForReview(string title, string message, string iTunesAppId)
	{
	}

	// Token: 0x0600002C RID: 44
	[DllImport("__Internal")]
	private static extern void _etceteraSetPopoverPoint(float xPos, float yPos);

	// Token: 0x0600002D RID: 45 RVA: 0x000020B0 File Offset: 0x000002B0
	public static void setPopoverPoint(float xPos, float yPos)
	{
	}

	// Token: 0x0600002E RID: 46
	[DllImport("__Internal")]
	private static extern void _etceteraPromptForPhoto(float scaledToSize, int promptType, float jpegCompression, bool allowsEditing);

	// Token: 0x0600002F RID: 47 RVA: 0x000020B4 File Offset: 0x000002B4
	public static void promptForPhoto(float scaledToSize)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000020B8 File Offset: 0x000002B8
	public static void promptForPhoto(float scaledToSize, PhotoPromptType promptType)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000020BC File Offset: 0x000002BC
	public static void promptForPhoto(float scaledToSize, PhotoPromptType promptType, float jpegCompression, bool allowsEditing)
	{
	}

	// Token: 0x06000032 RID: 50
	[DllImport("__Internal")]
	private static extern void _etceteraResizeImageAtPath(string filePath, float width, float height);

	// Token: 0x06000033 RID: 51 RVA: 0x000020C0 File Offset: 0x000002C0
	public static void resizeImageAtPath(string filePath, float width, float height)
	{
	}

	// Token: 0x06000034 RID: 52
	[DllImport("__Internal")]
	private static extern string _etceteraGetImageSize(string filePath);

	// Token: 0x06000035 RID: 53 RVA: 0x000020C4 File Offset: 0x000002C4
	public static Vector2 getImageSize(string filePath)
	{
	}

	// Token: 0x06000036 RID: 54
	[DllImport("__Internal")]
	private static extern void _etceteraSaveImageToPhotoAlbum(string filePath);

	// Token: 0x06000037 RID: 55 RVA: 0x000020C8 File Offset: 0x000002C8
	public static void saveImageToPhotoAlbum(string filePath)
	{
	}

	// Token: 0x06000038 RID: 56
	[DllImport("__Internal")]
	private static extern void _etceteraSetUrbanAirshipCredentials(string appKey, string appSecret, string alias);

	// Token: 0x06000039 RID: 57 RVA: 0x000020CC File Offset: 0x000002CC
	public static void setUrbanAirshipCredentials(string appKey, string appSecret)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000020D0 File Offset: 0x000002D0
	public static void setUrbanAirshipCredentials(string appKey, string appSecret, string alias)
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000020D4 File Offset: 0x000002D4
	public static void setPushIOCredentials(string apiKey)
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000020D8 File Offset: 0x000002D8
	public static void setPushIOCredentials(string apiKey, string[] categories)
	{
	}

	// Token: 0x0600003D RID: 61
	[DllImport("__Internal")]
	private static extern void _etceteraRegisterForRemoteNotifications(int types);

	// Token: 0x0600003E RID: 62 RVA: 0x000020DC File Offset: 0x000002DC
	public static void registerForRemoteNotifcations(P31RemoteNotificationType types)
	{
	}

	// Token: 0x0600003F RID: 63
	[DllImport("__Internal")]
	private static extern int _etceteraGetEnabledRemoteNotificationTypes();

	// Token: 0x06000040 RID: 64 RVA: 0x000020E0 File Offset: 0x000002E0
	public static P31RemoteNotificationType getEnabledRemoteNotificationTypes()
	{
	}

	// Token: 0x06000041 RID: 65
	[DllImport("__Internal")]
	private static extern int _etceteraGetBadgeCount();

	// Token: 0x06000042 RID: 66 RVA: 0x000020E4 File Offset: 0x000002E4
	public static int getBadgeCount()
	{
	}

	// Token: 0x06000043 RID: 67
	[DllImport("__Internal")]
	private static extern void _etceteraSetBadgeCount(int badgeCount);

	// Token: 0x06000044 RID: 68 RVA: 0x000020E8 File Offset: 0x000002E8
	public static void setBadgeCount(int badgeCount)
	{
	}

	// Token: 0x06000045 RID: 69
	[DllImport("__Internal")]
	private static extern int _etceteraGetStatusBarOrientation();

	// Token: 0x06000046 RID: 70 RVA: 0x000020EC File Offset: 0x000002EC
	public static UIInterfaceOrientation getStatusBarOrientation()
	{
	}

	// Token: 0x06000047 RID: 71
	[DllImport("__Internal")]
	private static extern string _etceteraUniqueDeviceIdentifier();

	// Token: 0x06000048 RID: 72 RVA: 0x000020F0 File Offset: 0x000002F0
	public static string uniqueDeviceIdentifier()
	{
	}

	// Token: 0x06000049 RID: 73
	[DllImport("__Internal")]
	private static extern string _etceteraUniqueGlobalDeviceIdentifier();

	// Token: 0x0600004A RID: 74 RVA: 0x000020F4 File Offset: 0x000002F4
	public static string uniqueGlobalDeviceIdentifier()
	{
	}

	// Token: 0x0600004B RID: 75
	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewShow(int x, int y, int width, int height);

	// Token: 0x0600004C RID: 76 RVA: 0x000020F8 File Offset: 0x000002F8
	public static void inlineWebViewShow(int x, int y, int width, int height)
	{
	}

	// Token: 0x0600004D RID: 77
	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewClose();

	// Token: 0x0600004E RID: 78 RVA: 0x000020FC File Offset: 0x000002FC
	public static void inlineWebViewClose()
	{
	}

	// Token: 0x0600004F RID: 79
	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewSetUrl(string url);

	// Token: 0x06000050 RID: 80 RVA: 0x00002100 File Offset: 0x00000300
	public static void inlineWebViewSetUrl(string url)
	{
	}

	// Token: 0x06000051 RID: 81
	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewSetFrame(int x, int y, int width, int height);

	// Token: 0x06000052 RID: 82 RVA: 0x00002104 File Offset: 0x00000304
	public static void inlineWebViewSetFrame(int x, int y, int width, int height)
	{
	}
}
