using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000075 RID: 117
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Root")]
public class UIRoot : MonoBehaviour
{
	// Token: 0x1700008C RID: 140
	// (get) Token: 0x0600035B RID: 859 RVA: 0x00002DB4 File Offset: 0x00000FB4
	public static List<UIRoot> list
	{
		get
		{
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x0600035C RID: 860 RVA: 0x00002DB8 File Offset: 0x00000FB8
	public int activeHeight
	{
		get
		{
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x0600035D RID: 861 RVA: 0x00002DBC File Offset: 0x00000FBC
	public float pixelSizeAdjustment
	{
		get
		{
		}
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00002DC0 File Offset: 0x00000FC0
	private void Awake()
	{
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00002DC4 File Offset: 0x00000FC4
	private void OnDestroy()
	{
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00002DC8 File Offset: 0x00000FC8
	private void Start()
	{
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00002DCC File Offset: 0x00000FCC
	private void Update()
	{
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00002DD0 File Offset: 0x00000FD0
	public static void Broadcast(string funcName)
	{
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00002DD4 File Offset: 0x00000FD4
	public static void Broadcast(string funcName, object param)
	{
	}

	// Token: 0x04000326 RID: 806
	private static List<UIRoot> mRoots;

	// Token: 0x04000327 RID: 807
	private Transform mTrans;

	// Token: 0x04000328 RID: 808
	public bool automatic;

	// Token: 0x04000329 RID: 809
	public int manualHeight;

	// Token: 0x0400032A RID: 810
	public int minimumHeight;

	// Token: 0x0400032B RID: 811
	public int maximumHeight;
}
