using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200004F RID: 79
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Update Manager")]
public class UpdateManager : MonoBehaviour
{
	// Token: 0x0600023C RID: 572 RVA: 0x0000293C File Offset: 0x00000B3C
	private static int Compare(UpdateManager.UpdateEntry a, UpdateManager.UpdateEntry b)
	{
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00002940 File Offset: 0x00000B40
	private static void CreateInstance()
	{
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00002944 File Offset: 0x00000B44
	private void UpdateList(List<UpdateManager.UpdateEntry> list, float delta)
	{
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00002948 File Offset: 0x00000B48
	private void Start()
	{
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000294C File Offset: 0x00000B4C
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00002950 File Offset: 0x00000B50
	private void Update()
	{
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00002954 File Offset: 0x00000B54
	private void LateUpdate()
	{
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00002958 File Offset: 0x00000B58
	private bool CoroutineUpdate()
	{
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0000295C File Offset: 0x00000B5C
	[DebuggerHidden]
	private IEnumerator CoroutineFunction()
	{
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00002960 File Offset: 0x00000B60
	private void Add(MonoBehaviour mb, int updateOrder, UpdateManager.OnUpdate func, List<UpdateManager.UpdateEntry> list)
	{
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00002964 File Offset: 0x00000B64
	public static void AddUpdate(MonoBehaviour mb, int updateOrder, UpdateManager.OnUpdate func)
	{
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00002968 File Offset: 0x00000B68
	public static void AddLateUpdate(MonoBehaviour mb, int updateOrder, UpdateManager.OnUpdate func)
	{
	}

	// Token: 0x06000248 RID: 584 RVA: 0x0000296C File Offset: 0x00000B6C
	public static void AddCoroutine(MonoBehaviour mb, int updateOrder, UpdateManager.OnUpdate func)
	{
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00002970 File Offset: 0x00000B70
	public static void AddDestroy(UnityEngine.Object obj, float delay)
	{
	}

	// Token: 0x040001F8 RID: 504
	private static UpdateManager mInst;

	// Token: 0x040001F9 RID: 505
	private List<UpdateManager.UpdateEntry> mOnUpdate;

	// Token: 0x040001FA RID: 506
	private List<UpdateManager.UpdateEntry> mOnLate;

	// Token: 0x040001FB RID: 507
	private List<UpdateManager.UpdateEntry> mOnCoro;

	// Token: 0x040001FC RID: 508
	private BetterList<UpdateManager.DestroyEntry> mDest;

	// Token: 0x040001FD RID: 509
	private float mTime;

	// Token: 0x02000050 RID: 80
	public class UpdateEntry
	{
		// Token: 0x040001FE RID: 510
		public int index;

		// Token: 0x040001FF RID: 511
		public UpdateManager.OnUpdate func;

		// Token: 0x04000200 RID: 512
		public MonoBehaviour mb;

		// Token: 0x04000201 RID: 513
		public bool isMonoBehaviour;
	}

	// Token: 0x02000051 RID: 81
	public class DestroyEntry
	{
		// Token: 0x04000202 RID: 514
		public UnityEngine.Object obj;

		// Token: 0x04000203 RID: 515
		public float time;
	}

	// Token: 0x0200015D RID: 349
	// (Invoke) Token: 0x06000B69 RID: 2921
	public delegate void OnUpdate(float delta);
}
