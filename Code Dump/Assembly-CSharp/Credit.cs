using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000114 RID: 276
public class Credit : MonoBehaviour
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000846 RID: 2118 RVA: 0x00003C14 File Offset: 0x00001E14
	// (remove) Token: 0x06000847 RID: 2119 RVA: 0x00003C18 File Offset: 0x00001E18
	public event Action onCreditFinish
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00003C1C File Offset: 0x00001E1C
	private void Awake()
	{
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00003C20 File Offset: 0x00001E20
	private void Update()
	{
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00003C24 File Offset: 0x00001E24
	private void ToX(Transform t, float x)
	{
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00003C28 File Offset: 0x00001E28
	public void Run()
	{
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00003C2C File Offset: 0x00001E2C
	[DebuggerHidden]
	private IEnumerator IERun()
	{
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00003C30 File Offset: 0x00001E30
	[DebuggerHidden]
	private IEnumerator IEShow()
	{
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00003C34 File Offset: 0x00001E34
	[DebuggerHidden]
	private IEnumerator IEHide()
	{
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00003C38 File Offset: 0x00001E38
	public Coroutine Sync()
	{
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00003C3C File Offset: 0x00001E3C
	[DebuggerHidden]
	public IEnumerator PauseRoutine()
	{
	}

	// Token: 0x0400053D RID: 1341
	public UISprite title;

	// Token: 0x0400053E RID: 1342
	public UISprite content;

	// Token: 0x0400053F RID: 1343
	public UISprite content2;

	// Token: 0x04000540 RID: 1344
	[HideInInspector]
	public bool isRunning;
}
