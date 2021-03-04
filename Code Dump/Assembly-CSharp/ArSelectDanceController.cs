using System;
using UnityEngine;

// Token: 0x02000127 RID: 295
public class ArSelectDanceController : MonoBehaviour
{
	// Token: 0x0600094D RID: 2381 RVA: 0x00004030 File Offset: 0x00002230
	private void Awake()
	{
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00004034 File Offset: 0x00002234
	private void Start()
	{
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00004038 File Offset: 0x00002238
	private void SelectDanceType()
	{
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x0000403C File Offset: 0x0000223C
	public void Show()
	{
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00004040 File Offset: 0x00002240
	public void Hide()
	{
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00004044 File Offset: 0x00002244
	private void OnEverGreenClick()
	{
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00004048 File Offset: 0x00002248
	private void OnLuv4NightClick()
	{
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x0000404C File Offset: 0x0000224C
	private void OnBackClick()
	{
	}

	// Token: 0x040005FF RID: 1535
	[SerializeField]
	public Transform[] _panels;

	// Token: 0x04000600 RID: 1536
	[HideInInspector]
	public static ArSelectDanceController.DanceType danceType;

	// Token: 0x04000601 RID: 1537
	[SerializeField]
	private GameObject newMark;

	// Token: 0x04000602 RID: 1538
	private bool isClicked;

	// Token: 0x02000128 RID: 296
	public enum DanceType
	{
		// Token: 0x04000604 RID: 1540
		EVER_GREEN,
		// Token: 0x04000605 RID: 1541
		LUV_4_NIGHT
	}
}
