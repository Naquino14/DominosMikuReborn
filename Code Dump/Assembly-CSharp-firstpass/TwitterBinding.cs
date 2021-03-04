using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x02000026 RID: 38
public class TwitterBinding
{
	// Token: 0x0600026C RID: 620
	[DllImport("__Internal")]
	private static extern void _twitterInit(string consumerKey, string consumerSecret);

	// Token: 0x0600026D RID: 621 RVA: 0x000028C4 File Offset: 0x00000AC4
	public static void init(string consumerKey, string consumerSecret)
	{
	}

	// Token: 0x0600026E RID: 622
	[DllImport("__Internal")]
	private static extern bool _twitterIsLoggedIn();

	// Token: 0x0600026F RID: 623 RVA: 0x000028C8 File Offset: 0x00000AC8
	public static bool isLoggedIn()
	{
	}

	// Token: 0x06000270 RID: 624
	[DllImport("__Internal")]
	private static extern string _twitterLoggedInUsername();

	// Token: 0x06000271 RID: 625 RVA: 0x000028CC File Offset: 0x00000ACC
	public static string loggedInUsername()
	{
	}

	// Token: 0x06000272 RID: 626
	[DllImport("__Internal")]
	private static extern void _twitterLogin(string username, string password);

	// Token: 0x06000273 RID: 627 RVA: 0x000028D0 File Offset: 0x00000AD0
	public static void login(string username, string password)
	{
	}

	// Token: 0x06000274 RID: 628
	[DllImport("__Internal")]
	private static extern void _twitterShowOauthLoginDialog();

	// Token: 0x06000275 RID: 629 RVA: 0x000028D4 File Offset: 0x00000AD4
	public static void showOauthLoginDialog()
	{
	}

	// Token: 0x06000276 RID: 630
	[DllImport("__Internal")]
	private static extern void _twitterLogout();

	// Token: 0x06000277 RID: 631 RVA: 0x000028D8 File Offset: 0x00000AD8
	public static void logout()
	{
	}

	// Token: 0x06000278 RID: 632 RVA: 0x000028DC File Offset: 0x00000ADC
	public static void postStatusUpdate(string status)
	{
	}

	// Token: 0x06000279 RID: 633
	[DllImport("__Internal")]
	private static extern void _twitterPostStatusUpdateWithImage(string status, string imagePath);

	// Token: 0x0600027A RID: 634 RVA: 0x000028E0 File Offset: 0x00000AE0
	public static void postStatusUpdate(string status, string pathToImage)
	{
	}

	// Token: 0x0600027B RID: 635 RVA: 0x000028E4 File Offset: 0x00000AE4
	public static void getHomeTimeline()
	{
	}

	// Token: 0x0600027C RID: 636
	[DllImport("__Internal")]
	private static extern void _twitterPerformRequest(string methodType, string path, string parameters);

	// Token: 0x0600027D RID: 637 RVA: 0x000028E8 File Offset: 0x00000AE8
	public static void performRequest(string methodType, string path, Dictionary<string, string> parameters)
	{
	}

	// Token: 0x0600027E RID: 638
	[DllImport("__Internal")]
	private static extern bool _twitterIsTweetSheetSupported();

	// Token: 0x0600027F RID: 639 RVA: 0x000028EC File Offset: 0x00000AEC
	public static bool isTweetSheetSupported()
	{
	}

	// Token: 0x06000280 RID: 640
	[DllImport("__Internal")]
	private static extern bool _twitterCanUserTweet();

	// Token: 0x06000281 RID: 641 RVA: 0x000028F0 File Offset: 0x00000AF0
	public static bool canUserTweet()
	{
	}

	// Token: 0x06000282 RID: 642
	[DllImport("__Internal")]
	private static extern void _twitterShowTweetComposer(string status, string imagePath, string url);

	// Token: 0x06000283 RID: 643 RVA: 0x000028F4 File Offset: 0x00000AF4
	public static void showTweetComposer(string status)
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x000028F8 File Offset: 0x00000AF8
	public static void showTweetComposer(string status, string pathToImage)
	{
	}

	// Token: 0x06000285 RID: 645 RVA: 0x000028FC File Offset: 0x00000AFC
	public static void showTweetComposer(string status, string pathToImage, string link)
	{
	}
}
