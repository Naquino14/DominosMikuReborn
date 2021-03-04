using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200013A RID: 314
public class PoOpeningController : MonoBehaviour
{
	// Token: 0x06000A70 RID: 2672 RVA: 0x000044BC File Offset: 0x000026BC
	private void Awake()
	{
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x000044C0 File Offset: 0x000026C0
	[DebuggerHidden]
	private IEnumerator Start()
	{
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x000044C4 File Offset: 0x000026C4
	[DebuggerHidden]
	private IEnumerator Download()
	{
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x000044C8 File Offset: 0x000026C8
	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x000044CC File Offset: 0x000026CC
	private void OnOKClick()
	{
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x000044D0 File Offset: 0x000026D0
	private bool isCachedAll()
	{
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x000044D4 File Offset: 0x000026D4
	private void Set()
	{
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x000044D8 File Offset: 0x000026D8
	private void Show()
	{
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x000044DC File Offset: 0x000026DC
	private void OnCloseClick()
	{
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x000044E0 File Offset: 0x000026E0
	private void DestroyScene()
	{
	}

	// Token: 0x040006BA RID: 1722
	private const string OPENING_URL = "Texture/Portrait/OpeningAtlas";

	// Token: 0x040006BB RID: 1723
	public GameObject _root;

	// Token: 0x040006BC RID: 1724
	[SerializeField]
	private Material _poOpeningMat;

	// Token: 0x040006BD RID: 1725
	private bool _isInited;

	// Token: 0x040006BE RID: 1726
	private bool _isClosed;
}
