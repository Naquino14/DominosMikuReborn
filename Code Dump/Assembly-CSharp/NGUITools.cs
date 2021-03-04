using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000046 RID: 70
public static class NGUITools
{
	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060001BE RID: 446 RVA: 0x00002744 File Offset: 0x00000944
	// (set) Token: 0x060001BF RID: 447 RVA: 0x00002748 File Offset: 0x00000948
	public static float soundVolume
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000274C File Offset: 0x0000094C
	public static bool fileAccess
	{
		get
		{
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00002750 File Offset: 0x00000950
	public static AudioSource PlaySound(AudioClip clip)
	{
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002754 File Offset: 0x00000954
	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00002758 File Offset: 0x00000958
	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000275C File Offset: 0x0000095C
	public static WWW OpenURL(string url)
	{
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00002760 File Offset: 0x00000960
	public static WWW OpenURL(string url, WWWForm form)
	{
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00002764 File Offset: 0x00000964
	public static int RandomRange(int min, int max)
	{
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00002768 File Offset: 0x00000968
	public static string GetHierarchy(GameObject obj)
	{
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0000276C File Offset: 0x0000096C
	public static Color ParseColor(string text, int offset)
	{
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002770 File Offset: 0x00000970
	public static string EncodeColor(Color c)
	{
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00002774 File Offset: 0x00000974
	public static int ParseSymbol(string text, int index, List<Color> colors)
	{
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00002778 File Offset: 0x00000978
	public static string StripSymbols(string text)
	{
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0000277C File Offset: 0x0000097C
	public static T[] FindActive<T>() where T : Component
	{
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00002780 File Offset: 0x00000980
	public static Camera FindCameraForLayer(int layer)
	{
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00002784 File Offset: 0x00000984
	public static BoxCollider AddWidgetCollider(GameObject go)
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00002788 File Offset: 0x00000988
	public static string GetName<T>() where T : Component
	{
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0000278C File Offset: 0x0000098C
	public static GameObject AddChild(GameObject parent)
	{
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00002790 File Offset: 0x00000990
	public static GameObject AddChild(GameObject parent, GameObject prefab)
	{
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00002794 File Offset: 0x00000994
	public static int CalculateNextDepth(GameObject go)
	{
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00002798 File Offset: 0x00000998
	public static T AddChild<T>(GameObject parent) where T : Component
	{
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0000279C File Offset: 0x0000099C
	public static T AddWidget<T>(GameObject go) where T : UIWidget
	{
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x000027A0 File Offset: 0x000009A0
	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
	{
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x000027A4 File Offset: 0x000009A4
	public static T FindInParents<T>(GameObject go) where T : Component
	{
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x000027A8 File Offset: 0x000009A8
	public static void Destroy(UnityEngine.Object obj)
	{
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x000027AC File Offset: 0x000009AC
	public static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x000027B0 File Offset: 0x000009B0
	public static void Broadcast(string funcName)
	{
	}

	// Token: 0x060001DA RID: 474 RVA: 0x000027B4 File Offset: 0x000009B4
	public static void Broadcast(string funcName, object param)
	{
	}

	// Token: 0x060001DB RID: 475 RVA: 0x000027B8 File Offset: 0x000009B8
	public static bool IsChild(Transform parent, Transform child)
	{
	}

	// Token: 0x060001DC RID: 476 RVA: 0x000027BC File Offset: 0x000009BC
	private static void Activate(Transform t)
	{
	}

	// Token: 0x060001DD RID: 477 RVA: 0x000027C0 File Offset: 0x000009C0
	private static void Deactivate(Transform t)
	{
	}

	// Token: 0x060001DE RID: 478 RVA: 0x000027C4 File Offset: 0x000009C4
	public static void SetActive(GameObject go, bool state)
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x000027C8 File Offset: 0x000009C8
	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x000027CC File Offset: 0x000009CC
	public static bool GetActive(GameObject go)
	{
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x000027D0 File Offset: 0x000009D0
	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x000027D4 File Offset: 0x000009D4
	public static void SetLayer(GameObject go, int layer)
	{
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x000027D8 File Offset: 0x000009D8
	public static Vector3 Round(Vector3 v)
	{
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x000027DC File Offset: 0x000009DC
	public static void MakePixelPerfect(Transform t)
	{
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x000027E0 File Offset: 0x000009E0
	public static bool Save(string fileName, byte[] bytes)
	{
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x000027E4 File Offset: 0x000009E4
	public static byte[] Load(string fileName)
	{
	}

	// Token: 0x040001A7 RID: 423
	private static AudioListener mListener;

	// Token: 0x040001A8 RID: 424
	private static bool mLoaded;

	// Token: 0x040001A9 RID: 425
	private static float mGlobalVolume;
}
