using System;
using UnityEngine;

// Token: 0x0200002F RID: 47
[ExecuteInEditMode]
[AddComponentMenu("SysFont/Text")]
public class SysFontText : MonoBehaviour, ISysFontTexturable
{
	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060002F3 RID: 755 RVA: 0x00002A28 File Offset: 0x00000C28
	// (set) Token: 0x060002F4 RID: 756 RVA: 0x00002A2C File Offset: 0x00000C2C
	public string Text
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002A30 File Offset: 0x00000C30
	// (set) Token: 0x060002F6 RID: 758 RVA: 0x00002A34 File Offset: 0x00000C34
	public string AppleFontName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060002F7 RID: 759 RVA: 0x00002A38 File Offset: 0x00000C38
	// (set) Token: 0x060002F8 RID: 760 RVA: 0x00002A3C File Offset: 0x00000C3C
	public string AndroidFontName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002A40 File Offset: 0x00000C40
	// (set) Token: 0x060002FA RID: 762 RVA: 0x00002A44 File Offset: 0x00000C44
	public string FontName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x060002FB RID: 763 RVA: 0x00002A48 File Offset: 0x00000C48
	// (set) Token: 0x060002FC RID: 764 RVA: 0x00002A4C File Offset: 0x00000C4C
	public int FontSize
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x060002FD RID: 765 RVA: 0x00002A50 File Offset: 0x00000C50
	// (set) Token: 0x060002FE RID: 766 RVA: 0x00002A54 File Offset: 0x00000C54
	public bool IsBold
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x060002FF RID: 767 RVA: 0x00002A58 File Offset: 0x00000C58
	// (set) Token: 0x06000300 RID: 768 RVA: 0x00002A5C File Offset: 0x00000C5C
	public bool IsItalic
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000301 RID: 769 RVA: 0x00002A60 File Offset: 0x00000C60
	// (set) Token: 0x06000302 RID: 770 RVA: 0x00002A64 File Offset: 0x00000C64
	public SysFont.Alignment Alignment
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000303 RID: 771 RVA: 0x00002A68 File Offset: 0x00000C68
	// (set) Token: 0x06000304 RID: 772 RVA: 0x00002A6C File Offset: 0x00000C6C
	public bool IsMultiLine
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000305 RID: 773 RVA: 0x00002A70 File Offset: 0x00000C70
	// (set) Token: 0x06000306 RID: 774 RVA: 0x00002A74 File Offset: 0x00000C74
	public int MaxWidthPixels
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000307 RID: 775 RVA: 0x00002A78 File Offset: 0x00000C78
	// (set) Token: 0x06000308 RID: 776 RVA: 0x00002A7C File Offset: 0x00000C7C
	public int MaxHeightPixels
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000309 RID: 777 RVA: 0x00002A80 File Offset: 0x00000C80
	public int WidthPixels
	{
		get
		{
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x0600030A RID: 778 RVA: 0x00002A84 File Offset: 0x00000C84
	public int HeightPixels
	{
		get
		{
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x0600030B RID: 779 RVA: 0x00002A88 File Offset: 0x00000C88
	public int TextWidthPixels
	{
		get
		{
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x0600030C RID: 780 RVA: 0x00002A8C File Offset: 0x00000C8C
	public int TextHeightPixels
	{
		get
		{
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x0600030D RID: 781 RVA: 0x00002A90 File Offset: 0x00000C90
	public Texture Texture
	{
		get
		{
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x0600030E RID: 782 RVA: 0x00002A94 File Offset: 0x00000C94
	// (set) Token: 0x0600030F RID: 783 RVA: 0x00002A98 File Offset: 0x00000C98
	public Color FontColor
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000310 RID: 784 RVA: 0x00002A9C File Offset: 0x00000C9C
	// (set) Token: 0x06000311 RID: 785 RVA: 0x00002AA0 File Offset: 0x00000CA0
	public SysFontText.PivotAlignment Pivot
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00002AA4 File Offset: 0x00000CA4
	protected void UpdateMesh()
	{
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00002AA8 File Offset: 0x00000CA8
	protected void UpdatePivot()
	{
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00002AAC File Offset: 0x00000CAC
	public void UpdateScale()
	{
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00002AB0 File Offset: 0x00000CB0
	protected virtual void Awake()
	{
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00002AB4 File Offset: 0x00000CB4
	protected virtual void Update()
	{
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00002AB8 File Offset: 0x00000CB8
	protected void OnDestroy()
	{
	}

	// Token: 0x040000FF RID: 255
	[SerializeField]
	protected SysFontTexture _texture;

	// Token: 0x04000100 RID: 256
	[SerializeField]
	protected Color _fontColor;

	// Token: 0x04000101 RID: 257
	[SerializeField]
	protected SysFontText.PivotAlignment _pivot;

	// Token: 0x04000102 RID: 258
	protected Color _lastFontColor;

	// Token: 0x04000103 RID: 259
	protected SysFontText.PivotAlignment _lastPivot;

	// Token: 0x04000104 RID: 260
	protected Transform _transform;

	// Token: 0x04000105 RID: 261
	protected Material _createdMaterial;

	// Token: 0x04000106 RID: 262
	protected Material _material;

	// Token: 0x04000107 RID: 263
	protected Vector3[] _vertices;

	// Token: 0x04000108 RID: 264
	protected Vector2[] _uv;

	// Token: 0x04000109 RID: 265
	protected int[] _triangles;

	// Token: 0x0400010A RID: 266
	protected Mesh _mesh;

	// Token: 0x0400010B RID: 267
	protected MeshFilter _filter;

	// Token: 0x0400010C RID: 268
	protected MeshRenderer _renderer;

	// Token: 0x0400010D RID: 269
	protected static Shader _shader;

	// Token: 0x02000030 RID: 48
	public enum PivotAlignment
	{
		// Token: 0x0400010F RID: 271
		TopLeft,
		// Token: 0x04000110 RID: 272
		Top,
		// Token: 0x04000111 RID: 273
		TopRight,
		// Token: 0x04000112 RID: 274
		Left,
		// Token: 0x04000113 RID: 275
		Center,
		// Token: 0x04000114 RID: 276
		Right,
		// Token: 0x04000115 RID: 277
		BottomLeft,
		// Token: 0x04000116 RID: 278
		Bottom,
		// Token: 0x04000117 RID: 279
		BottomRight
	}
}
