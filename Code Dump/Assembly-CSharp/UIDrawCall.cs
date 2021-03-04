using System;
using UnityEngine;

// Token: 0x02000048 RID: 72
[AddComponentMenu("NGUI/Internal/Draw Call")]
[ExecuteInEditMode]
public class UIDrawCall : MonoBehaviour
{
	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060001EC RID: 492 RVA: 0x000027FC File Offset: 0x000009FC
	// (set) Token: 0x060001ED RID: 493 RVA: 0x00002800 File Offset: 0x00000A00
	public bool depthPass
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060001EE RID: 494 RVA: 0x00002804 File Offset: 0x00000A04
	public Transform cachedTransform
	{
		get
		{
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060001EF RID: 495 RVA: 0x00002808 File Offset: 0x00000A08
	// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000280C File Offset: 0x00000A0C
	public Material material
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060001F1 RID: 497 RVA: 0x00002810 File Offset: 0x00000A10
	public int triangles
	{
		get
		{
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002814 File Offset: 0x00000A14
	// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002818 File Offset: 0x00000A18
	public UIDrawCall.Clipping clipping
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000281C File Offset: 0x00000A1C
	// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002820 File Offset: 0x00000A20
	public Vector4 clipRange
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060001F6 RID: 502 RVA: 0x00002824 File Offset: 0x00000A24
	// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002828 File Offset: 0x00000A28
	public Vector2 clipSoftness
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0000282C File Offset: 0x00000A2C
	private Mesh GetMesh(ref bool rebuildIndices, int vertexCount)
	{
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00002830 File Offset: 0x00000A30
	private void UpdateMaterials()
	{
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00002834 File Offset: 0x00000A34
	public void Set(BetterList<Vector3> verts, BetterList<Vector3> norms, BetterList<Vector4> tans, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00002838 File Offset: 0x00000A38
	private void OnWillRenderObject()
	{
	}

	// Token: 0x060001FC RID: 508 RVA: 0x0000283C File Offset: 0x00000A3C
	private void OnDestroy()
	{
	}

	// Token: 0x040001B1 RID: 433
	private Transform mTrans;

	// Token: 0x040001B2 RID: 434
	private Material mSharedMat;

	// Token: 0x040001B3 RID: 435
	private Mesh mMesh0;

	// Token: 0x040001B4 RID: 436
	private Mesh mMesh1;

	// Token: 0x040001B5 RID: 437
	private MeshFilter mFilter;

	// Token: 0x040001B6 RID: 438
	private MeshRenderer mRen;

	// Token: 0x040001B7 RID: 439
	private UIDrawCall.Clipping mClipping;

	// Token: 0x040001B8 RID: 440
	private Vector4 mClipRange;

	// Token: 0x040001B9 RID: 441
	private Vector2 mClipSoft;

	// Token: 0x040001BA RID: 442
	private Material mClippedMat;

	// Token: 0x040001BB RID: 443
	private Material mDepthMat;

	// Token: 0x040001BC RID: 444
	private int[] mIndices;

	// Token: 0x040001BD RID: 445
	private bool mDepthPass;

	// Token: 0x040001BE RID: 446
	private bool mReset;

	// Token: 0x040001BF RID: 447
	private bool mEven;

	// Token: 0x02000049 RID: 73
	public enum Clipping
	{
		// Token: 0x040001C1 RID: 449
		None,
		// Token: 0x040001C2 RID: 450
		HardClip,
		// Token: 0x040001C3 RID: 451
		AlphaClip,
		// Token: 0x040001C4 RID: 452
		SoftClip
	}
}
