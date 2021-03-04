using System;
using UnityEngine;

// Token: 0x020000F6 RID: 246
public class Popup
{
	// Token: 0x06000793 RID: 1939 RVA: 0x0000394C File Offset: 0x00001B4C
	public static bool List(Rect position, ref bool showList, ref int listEntry, GUIContent buttonContent, object[] list, GUIStyle listStyle, Popup.ListCallBack callBack)
	{
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00003950 File Offset: 0x00001B50
	public static bool List(Rect position, ref bool showList, ref int listEntry, GUIContent buttonContent, object[] list, GUIStyle buttonStyle, GUIStyle boxStyle, GUIStyle listStyle, Popup.ListCallBack callBack)
	{
	}

	// Token: 0x040004CB RID: 1227
	private static int popupListHash;

	// Token: 0x02000162 RID: 354
	// (Invoke) Token: 0x06000B7D RID: 2941
	public delegate void ListCallBack();
}
