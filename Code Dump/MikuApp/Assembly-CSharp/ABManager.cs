using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ABManager : MonoBehaviour
{
	public enum ABServer
	{
		RELEASE,
		DEV,
		DEV_PREVIEW,
		DOMINO_TEST
	}

	public static bool UseAssetBundleCache;

	public ABServer aBServer;

	public int assetVersion;

	public string domain;

	public string domainTest;

	public string domainDevPreview;

	public string domainDev;

	private Dictionary<string, AssetBundle> assetBundleList;

	private static ABManager instance;

	private AssetBundle assetBundle;

	private WWW downloadWWW;

	private string url;

	private int countLoaded;

	private int totalLoad;

	private bool downloading;

	private string currentDomain;

	public static ABManager Instance => (ABManager)/*Error near IL_0001: Stack underflow*/;

	public bool Downloading
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected void Init()
	{
	}

	protected void SetServer()
	{
	}

	private void SetTotal(int total)
	{
	}

	public float GetProgress()
	{
		return (float)/*Error near IL_0001: Stack underflow*/;
	}

	public string GetStringProgress()
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public bool ContainsItem(string item)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public Object GetItem(string item)
	{
		return (Object)/*Error near IL_0001: Stack underflow*/;
	}

	public Object GetItemChild(string item, string name)
	{
		return (Object)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	public IEnumerator Download(List<string> stringList)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	public IEnumerator Download(string[] stringList)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	public IEnumerator Download(string str)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	public IEnumerator DownloadAbsolutely(string str)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	public void FreeAllAssets()
	{
	}

	public void FreeAsset(string item)
	{
	}

	public void FreeAssets(List<string> items)
	{
	}

	public void FreeAssets(string[] items)
	{
	}

	public bool IsDownloaded(string str)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private void SetUrl(string str)
	{
	}

	private void LoadItemsBegin(string str)
	{
	}

	private void LoadItemsEnd(string str)
	{
	}
}
