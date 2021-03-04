using System;
using UnityEngine;

// Token: 0x0200007E RID: 126
[AddComponentMenu("NGUI/UI/Texture")]
[ExecuteInEditMode]
public class UITexture : UIWidget
{
	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000398 RID: 920 RVA: 0x00002EA8 File Offset: 0x000010A8
	// (set) Token: 0x06000399 RID: 921 RVA: 0x00002EAC File Offset: 0x000010AC
	public Rect uvRect
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x0600039A RID: 922 RVA: 0x00002EB0 File Offset: 0x000010B0
	// (set) Token: 0x0600039B RID: 923 RVA: 0x00002EB4 File Offset: 0x000010B4
	public Shader shader
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x0600039C RID: 924 RVA: 0x00002EB8 File Offset: 0x000010B8
	public bool hasDynamicMaterial
	{
		get
		{
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x0600039D RID: 925 RVA: 0x00002EBC File Offset: 0x000010BC
	public override bool keepMaterial
	{
		get
		{
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x0600039E RID: 926 RVA: 0x00002EC0 File Offset: 0x000010C0
	// (set) Token: 0x0600039F RID: 927 RVA: 0x00002EC4 File Offset: 0x000010C4
	public override Material material
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x060003A0 RID: 928 RVA: 0x00002EC8 File Offset: 0x000010C8
	// (set) Token: 0x060003A1 RID: 929 RVA: 0x00002ECC File Offset: 0x000010CC
	public override Texture mainTexture
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00002ED0 File Offset: 0x000010D0
	private void OnDestroy()
	{
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00002ED4 File Offset: 0x000010D4
	public override void MakePixelPerfect()
	{
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00002ED8 File Offset: 0x000010D8
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	// Token: 0x0400035D RID: 861
	[SerializeField]
	[HideInInspector]
	private Rect mRect;

	// Token: 0x0400035E RID: 862
	[SerializeField]
	[HideInInspector]
	private Shader mShader;

	// Token: 0x0400035F RID: 863
	[HideInInspector]
	[SerializeField]
	private Texture mTexture;

	// Token: 0x04000360 RID: 864
	private Material mDynamicMat;

	// Token: 0x04000361 RID: 865
	private bool mCreatingMat;
}
