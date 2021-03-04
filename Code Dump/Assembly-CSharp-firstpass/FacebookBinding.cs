using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x0200001F RID: 31
public class FacebookBinding
{
	// Token: 0x060001DF RID: 479
	[DllImport("__Internal")]
	private static extern void _facebookInit();

	// Token: 0x060001E0 RID: 480 RVA: 0x000026E4 File Offset: 0x000008E4
	public static void init()
	{
	}

	// Token: 0x060001E1 RID: 481
	[DllImport("__Internal")]
	private static extern string _facebookGetAppLaunchUrl();

	// Token: 0x060001E2 RID: 482 RVA: 0x000026E8 File Offset: 0x000008E8
	public static string getAppLaunchUrl()
	{
	}

	// Token: 0x060001E3 RID: 483
	[DllImport("__Internal")]
	private static extern void _facebookSetSessionLoginBehavior(int behavior);

	// Token: 0x060001E4 RID: 484 RVA: 0x000026EC File Offset: 0x000008EC
	public static void setSessionLoginBehavior(FacebookSessionLoginBehavior loginBehavior)
	{
	}

	// Token: 0x060001E5 RID: 485
	[DllImport("__Internal")]
	private static extern void _facebookEnableFrictionlessRequests();

	// Token: 0x060001E6 RID: 486 RVA: 0x000026F0 File Offset: 0x000008F0
	public static void enableFrictionlessRequests()
	{
	}

	// Token: 0x060001E7 RID: 487
	[DllImport("__Internal")]
	private static extern void _facebookRenewCredentialsForAllFacebookAccounts();

	// Token: 0x060001E8 RID: 488 RVA: 0x000026F4 File Offset: 0x000008F4
	public static void renewCredentialsForAllFacebookAccounts()
	{
	}

	// Token: 0x060001E9 RID: 489
	[DllImport("__Internal")]
	private static extern bool _facebookIsLoggedIn();

	// Token: 0x060001EA RID: 490 RVA: 0x000026F8 File Offset: 0x000008F8
	public static bool isSessionValid()
	{
	}

	// Token: 0x060001EB RID: 491
	[DllImport("__Internal")]
	private static extern string _facebookGetFacebookAccessToken();

	// Token: 0x060001EC RID: 492 RVA: 0x000026FC File Offset: 0x000008FC
	public static string getAccessToken()
	{
	}

	// Token: 0x060001ED RID: 493
	[DllImport("__Internal")]
	private static extern string _facebookGetSessionPermissions();

	// Token: 0x060001EE RID: 494 RVA: 0x00002700 File Offset: 0x00000900
	public static List<object> getSessionPermissions()
	{
	}

	// Token: 0x060001EF RID: 495
	[DllImport("__Internal")]
	private static extern void _facebookLoginUsingDeprecatedAuthorizationFlowWithRequestedPermissions(string perms, string urlSchemeSuffix);

	// Token: 0x060001F0 RID: 496 RVA: 0x00002704 File Offset: 0x00000904
	[Obsolete("Note that this auth flow has been deprecated by Facebook and could be removed at any time at Facebook's discretion")]
	public static void loginUsingDeprecatedAuthorizationFlowWithRequestedPermissions(string[] permissions)
	{
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00002708 File Offset: 0x00000908
	[Obsolete("Note that this auth flow has been deprecated by Facebook and could be removed at any time at Facebook's discretion")]
	public static void loginUsingDeprecatedAuthorizationFlowWithRequestedPermissions(string[] permissions, string urlSchemeSuffix)
	{
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x0000270C File Offset: 0x0000090C
	public static void login()
	{
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00002710 File Offset: 0x00000910
	public static void loginWithReadPermissions(string[] permissions)
	{
	}

	// Token: 0x060001F4 RID: 500
	[DllImport("__Internal")]
	private static extern void _facebookLoginWithRequestedPermissions(string perms, string urlSchemeSuffix);

	// Token: 0x060001F5 RID: 501 RVA: 0x00002714 File Offset: 0x00000914
	public static void loginWithReadPermissions(string[] permissions, string urlSchemeSuffix)
	{
	}

	// Token: 0x060001F6 RID: 502
	[DllImport("__Internal")]
	private static extern void _facebookReauthorizeWithReadPermissions(string perms);

	// Token: 0x060001F7 RID: 503 RVA: 0x00002718 File Offset: 0x00000918
	public static void reauthorizeWithReadPermissions(string[] permissions)
	{
	}

	// Token: 0x060001F8 RID: 504
	[DllImport("__Internal")]
	private static extern void _facebookReauthorizeWithPublishPermissions(string perms, int defaultAudience);

	// Token: 0x060001F9 RID: 505 RVA: 0x0000271C File Offset: 0x0000091C
	public static void reauthorizeWithPublishPermissions(string[] permissions, FacebookSessionDefaultAudience defaultAudience)
	{
	}

	// Token: 0x060001FA RID: 506
	[DllImport("__Internal")]
	private static extern void _facebookLogout();

	// Token: 0x060001FB RID: 507 RVA: 0x00002720 File Offset: 0x00000920
	public static void logout()
	{
	}

	// Token: 0x060001FC RID: 508
	[DllImport("__Internal")]
	private static extern void _facebookShowDialog(string dialogType, string json);

	// Token: 0x060001FD RID: 509 RVA: 0x00002724 File Offset: 0x00000924
	public static void showDialog(string dialogType, Dictionary<string, string> options)
	{
	}

	// Token: 0x060001FE RID: 510
	[DllImport("__Internal")]
	private static extern void _facebookRestRequest(string restMethod, string httpMethod, string jsonDict);

	// Token: 0x060001FF RID: 511 RVA: 0x00002728 File Offset: 0x00000928
	public static void restRequest(string restMethod, string httpMethod, Hashtable keyValueHash)
	{
	}

	// Token: 0x06000200 RID: 512
	[DllImport("__Internal")]
	private static extern void _facebookGraphRequest(string graphPath, string httpMethod, string jsonDict);

	// Token: 0x06000201 RID: 513 RVA: 0x0000272C File Offset: 0x0000092C
	public static void graphRequest(string graphPath, string httpMethod, Hashtable keyValueHash)
	{
	}

	// Token: 0x06000202 RID: 514
	[DllImport("__Internal")]
	private static extern bool _facebookIsFacebookComposerSupported();

	// Token: 0x06000203 RID: 515 RVA: 0x00002730 File Offset: 0x00000930
	public static bool isFacebookComposerSupported()
	{
	}

	// Token: 0x06000204 RID: 516
	[DllImport("__Internal")]
	private static extern bool _facebookCanUserUseFacebookComposer();

	// Token: 0x06000205 RID: 517 RVA: 0x00002734 File Offset: 0x00000934
	public static bool canUserUseFacebookComposer()
	{
	}

	// Token: 0x06000206 RID: 518
	[DllImport("__Internal")]
	private static extern void _facebookShowFacebookComposer(string message, string imagePath, string link);

	// Token: 0x06000207 RID: 519 RVA: 0x00002738 File Offset: 0x00000938
	public static void showFacebookComposer(string message)
	{
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0000273C File Offset: 0x0000093C
	public static void showFacebookComposer(string message, string imagePath, string link)
	{
	}

	// Token: 0x06000209 RID: 521
	[DllImport("__Internal")]
	private static extern void _facebookShowFacebookShareDialog(string json);

	// Token: 0x0600020A RID: 522 RVA: 0x00002740 File Offset: 0x00000940
	public static void showFacebookShareDialog(Dictionary<string, object> parameters)
	{
	}
}
