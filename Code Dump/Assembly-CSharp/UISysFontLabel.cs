using System;
using UnityEngine;

// Token: 0x0200010E RID: 270
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/SysFont Label")]
public class UISysFontLabel : UIWidget, ISysFontTexturable
{
	// Token: 0x06000807 RID: 2055 RVA: 0x00003B18 File Offset: 0x00001D18
	private void Start()
	{
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06000808 RID: 2056 RVA: 0x00003B1C File Offset: 0x00001D1C
	// (set) Token: 0x06000809 RID: 2057 RVA: 0x00003B20 File Offset: 0x00001D20
	public string Text
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x0600080A RID: 2058 RVA: 0x00003B24 File Offset: 0x00001D24
	// (set) Token: 0x0600080B RID: 2059 RVA: 0x00003B28 File Offset: 0x00001D28
	public string AppleFontName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x0600080C RID: 2060 RVA: 0x00003B2C File Offset: 0x00001D2C
	// (set) Token: 0x0600080D RID: 2061 RVA: 0x00003B30 File Offset: 0x00001D30
	public string AndroidFontName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x0600080E RID: 2062 RVA: 0x00003B34 File Offset: 0x00001D34
	// (set) Token: 0x0600080F RID: 2063 RVA: 0x00003B38 File Offset: 0x00001D38
	public string FontName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000810 RID: 2064 RVA: 0x00003B3C File Offset: 0x00001D3C
	// (set) Token: 0x06000811 RID: 2065 RVA: 0x00003B40 File Offset: 0x00001D40
	public int FontSize
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06000812 RID: 2066 RVA: 0x00003B44 File Offset: 0x00001D44
	// (set) Token: 0x06000813 RID: 2067 RVA: 0x00003B48 File Offset: 0x00001D48
	public bool IsBold
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06000814 RID: 2068 RVA: 0x00003B4C File Offset: 0x00001D4C
	// (set) Token: 0x06000815 RID: 2069 RVA: 0x00003B50 File Offset: 0x00001D50
	public bool IsItalic
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06000816 RID: 2070 RVA: 0x00003B54 File Offset: 0x00001D54
	// (set) Token: 0x06000817 RID: 2071 RVA: 0x00003B58 File Offset: 0x00001D58
	public SysFont.Alignment Alignment
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06000818 RID: 2072 RVA: 0x00003B5C File Offset: 0x00001D5C
	// (set) Token: 0x06000819 RID: 2073 RVA: 0x00003B60 File Offset: 0x00001D60
	public bool IsMultiLine
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x0600081A RID: 2074 RVA: 0x00003B64 File Offset: 0x00001D64
	// (set) Token: 0x0600081B RID: 2075 RVA: 0x00003B68 File Offset: 0x00001D68
	public int MaxWidthPixels
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x0600081C RID: 2076 RVA: 0x00003B6C File Offset: 0x00001D6C
	// (set) Token: 0x0600081D RID: 2077 RVA: 0x00003B70 File Offset: 0x00001D70
	public int MaxHeightPixels
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x0600081E RID: 2078 RVA: 0x00003B74 File Offset: 0x00001D74
	public int WidthPixels
	{
		get
		{
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x0600081F RID: 2079 RVA: 0x00003B78 File Offset: 0x00001D78
	public int HeightPixels
	{
		get
		{
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06000820 RID: 2080 RVA: 0x00003B7C File Offset: 0x00001D7C
	public int TextWidthPixels
	{
		get
		{
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000821 RID: 2081 RVA: 0x00003B80 File Offset: 0x00001D80
	public int TextHeightPixels
	{
		get
		{
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000822 RID: 2082 RVA: 0x00003B84 File Offset: 0x00001D84
	public Texture Texture
	{
		get
		{
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000823 RID: 2083 RVA: 0x00003B88 File Offset: 0x00001D88
	public override bool keepMaterial
	{
		get
		{
		}
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00003B8C File Offset: 0x00001D8C
	public override bool OnUpdate()
	{
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00003B90 File Offset: 0x00001D90
	public override void MakePixelPerfect()
	{
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00003B94 File Offset: 0x00001D94
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00003B98 File Offset: 0x00001D98
	protected void OnEnable()
	{
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x00003B9C File Offset: 0x00001D9C
	protected void OnDestroy()
	{
	}

	// Token: 0x04000522 RID: 1314
	[SerializeField]
	public bool hack;

	// Token: 0x04000523 RID: 1315
	[SerializeField]
	protected SysFontTexture _texture;

	// Token: 0x04000524 RID: 1316
	protected static Shader _shader;

	// Token: 0x04000525 RID: 1317
	protected Material _createdMaterial;

	// Token: 0x04000526 RID: 1318
	protected Vector3[] _vertices;

	// Token: 0x04000527 RID: 1319
	protected Vector2 _uv;
}
