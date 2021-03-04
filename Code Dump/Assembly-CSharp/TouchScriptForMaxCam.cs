using System;
using UnityEngine;

// Token: 0x02000101 RID: 257
public class TouchScriptForMaxCam : MonoBehaviour
{
	// Token: 0x17000134 RID: 308
	// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00003A1C File Offset: 0x00001C1C
	// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00003A20 File Offset: 0x00001C20
	public bool isActive
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00003A24 File Offset: 0x00001C24
	private void Start()
	{
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00003A28 File Offset: 0x00001C28
	public void destroy()
	{
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00003A2C File Offset: 0x00001C2C
	public void Reset()
	{
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00003A30 File Offset: 0x00001C30
	private void Update()
	{
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x00003A34 File Offset: 0x00001C34
	private void OnMouseDown2()
	{
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00003A38 File Offset: 0x00001C38
	private void OnMouseDrag()
	{
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00003A3C File Offset: 0x00001C3C
	private void OnMouseDrag2()
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00003A40 File Offset: 0x00001C40
	private void OnMouseUp()
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00003A44 File Offset: 0x00001C44
	private void OnPinchStart()
	{
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00003A48 File Offset: 0x00001C48
	private void OnPinch(float rate)
	{
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00003A4C File Offset: 0x00001C4C
	private void OnPinch2()
	{
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00003A50 File Offset: 0x00001C50
	private void doZoomWithMouse()
	{
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00003A54 File Offset: 0x00001C54
	private void doZoomWithTouch(float rate)
	{
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00003A58 File Offset: 0x00001C58
	private void doRotation()
	{
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00003A5C File Offset: 0x00001C5C
	private void doPan()
	{
	}

	// Token: 0x040004E0 RID: 1248
	public MaxCamera maxCam;

	// Token: 0x040004E1 RID: 1249
	private bool _isActive;

	// Token: 0x040004E2 RID: 1250
	private Quaternion targetRot;

	// Token: 0x040004E3 RID: 1251
	private float mouseXNow;

	// Token: 0x040004E4 RID: 1252
	private float mouseXPre;

	// Token: 0x040004E5 RID: 1253
	private float mouseYNow;

	// Token: 0x040004E6 RID: 1254
	private float mouseYPre;

	// Token: 0x040004E7 RID: 1255
	private float curRotY;

	// Token: 0x040004E8 RID: 1256
	private float curRotX;

	// Token: 0x040004E9 RID: 1257
	private float prePinch;

	// Token: 0x040004EA RID: 1258
	private bool isPinchReset;

	// Token: 0x040004EB RID: 1259
	private float curX;

	// Token: 0x040004EC RID: 1260
	private float curY;

	// Token: 0x040004ED RID: 1261
	private Quaternion zeroRot;

	// Token: 0x040004EE RID: 1262
	private Vector3 zeroPos;
}
