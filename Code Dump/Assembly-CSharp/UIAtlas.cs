using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000060 RID: 96
[AddComponentMenu("NGUI/UI/Atlas")]
public class UIAtlas : MonoBehaviour
{
	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000291 RID: 657 RVA: 0x00002A8C File Offset: 0x00000C8C
	// (set) Token: 0x06000292 RID: 658 RVA: 0x00002A90 File Offset: 0x00000C90
	public Material spriteMaterial
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000293 RID: 659 RVA: 0x00002A94 File Offset: 0x00000C94
	// (set) Token: 0x06000294 RID: 660 RVA: 0x00002A98 File Offset: 0x00000C98
	public List<UIAtlas.Sprite> spriteList
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000295 RID: 661 RVA: 0x00002A9C File Offset: 0x00000C9C
	public Texture texture
	{
		get
		{
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000296 RID: 662 RVA: 0x00002AA0 File Offset: 0x00000CA0
	// (set) Token: 0x06000297 RID: 663 RVA: 0x00002AA4 File Offset: 0x00000CA4
	public UIAtlas.Coordinates coordinates
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000298 RID: 664 RVA: 0x00002AA8 File Offset: 0x00000CA8
	// (set) Token: 0x06000299 RID: 665 RVA: 0x00002AAC File Offset: 0x00000CAC
	public float pixelSize
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x0600029A RID: 666 RVA: 0x00002AB0 File Offset: 0x00000CB0
	// (set) Token: 0x0600029B RID: 667 RVA: 0x00002AB4 File Offset: 0x00000CB4
	public UIAtlas replacement
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00002AB8 File Offset: 0x00000CB8
	public UIAtlas.Sprite GetSprite(string name)
	{
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00002ABC File Offset: 0x00000CBC
	private static int CompareString(string a, string b)
	{
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00002AC0 File Offset: 0x00000CC0
	public BetterList<string> GetListOfSprites()
	{
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00002AC4 File Offset: 0x00000CC4
	public BetterList<string> GetListOfSprites(string match)
	{
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002AC8 File Offset: 0x00000CC8
	private bool References(UIAtlas atlas)
	{
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00002ACC File Offset: 0x00000CCC
	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00002AD0 File Offset: 0x00000CD0
	public void MarkAsDirty()
	{
	}

	// Token: 0x0400025C RID: 604
	[HideInInspector]
	[SerializeField]
	private Material material;

	// Token: 0x0400025D RID: 605
	[HideInInspector]
	[SerializeField]
	private List<UIAtlas.Sprite> sprites;

	// Token: 0x0400025E RID: 606
	[SerializeField]
	[HideInInspector]
	private UIAtlas.Coordinates mCoordinates;

	// Token: 0x0400025F RID: 607
	[SerializeField]
	[HideInInspector]
	private float mPixelSize;

	// Token: 0x04000260 RID: 608
	[SerializeField]
	[HideInInspector]
	private UIAtlas mReplacement;

	// Token: 0x02000061 RID: 97
	[Serializable]
	public class Sprite
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00002AD8 File Offset: 0x00000CD8
		public bool hasPadding
		{
			get
			{
			}
		}

		// Token: 0x04000261 RID: 609
		public string name;

		// Token: 0x04000262 RID: 610
		public Rect outer;

		// Token: 0x04000263 RID: 611
		public Rect inner;

		// Token: 0x04000264 RID: 612
		public float paddingLeft;

		// Token: 0x04000265 RID: 613
		public float paddingRight;

		// Token: 0x04000266 RID: 614
		public float paddingTop;

		// Token: 0x04000267 RID: 615
		public float paddingBottom;
	}

	// Token: 0x02000062 RID: 98
	public enum Coordinates
	{
		// Token: 0x04000269 RID: 617
		Pixels,
		// Token: 0x0400026A RID: 618
		TexCoords
	}
}
