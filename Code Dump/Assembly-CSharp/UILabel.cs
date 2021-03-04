using System;
using UnityEngine;

// Token: 0x0200006F RID: 111
[AddComponentMenu("NGUI/UI/Label")]
[ExecuteInEditMode]
public class UILabel : UIWidget
{
	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000303 RID: 771 RVA: 0x00002C54 File Offset: 0x00000E54
	// (set) Token: 0x06000304 RID: 772 RVA: 0x00002C58 File Offset: 0x00000E58
	private bool hasChanged
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000305 RID: 773 RVA: 0x00002C5C File Offset: 0x00000E5C
	// (set) Token: 0x06000306 RID: 774 RVA: 0x00002C60 File Offset: 0x00000E60
	public UIFont font
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000307 RID: 775 RVA: 0x00002C64 File Offset: 0x00000E64
	// (set) Token: 0x06000308 RID: 776 RVA: 0x00002C68 File Offset: 0x00000E68
	public string text
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000309 RID: 777 RVA: 0x00002C6C File Offset: 0x00000E6C
	// (set) Token: 0x0600030A RID: 778 RVA: 0x00002C70 File Offset: 0x00000E70
	public bool supportEncoding
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x0600030B RID: 779 RVA: 0x00002C74 File Offset: 0x00000E74
	// (set) Token: 0x0600030C RID: 780 RVA: 0x00002C78 File Offset: 0x00000E78
	public UIFont.SymbolStyle symbolStyle
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x0600030D RID: 781 RVA: 0x00002C7C File Offset: 0x00000E7C
	// (set) Token: 0x0600030E RID: 782 RVA: 0x00002C80 File Offset: 0x00000E80
	public int lineWidth
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600030F RID: 783 RVA: 0x00002C84 File Offset: 0x00000E84
	// (set) Token: 0x06000310 RID: 784 RVA: 0x00002C88 File Offset: 0x00000E88
	public bool multiLine
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000311 RID: 785 RVA: 0x00002C8C File Offset: 0x00000E8C
	// (set) Token: 0x06000312 RID: 786 RVA: 0x00002C90 File Offset: 0x00000E90
	public int maxLineCount
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000313 RID: 787 RVA: 0x00002C94 File Offset: 0x00000E94
	// (set) Token: 0x06000314 RID: 788 RVA: 0x00002C98 File Offset: 0x00000E98
	public bool password
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000315 RID: 789 RVA: 0x00002C9C File Offset: 0x00000E9C
	// (set) Token: 0x06000316 RID: 790 RVA: 0x00002CA0 File Offset: 0x00000EA0
	public bool showLastPasswordChar
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000317 RID: 791 RVA: 0x00002CA4 File Offset: 0x00000EA4
	// (set) Token: 0x06000318 RID: 792 RVA: 0x00002CA8 File Offset: 0x00000EA8
	public UILabel.Effect effectStyle
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000319 RID: 793 RVA: 0x00002CAC File Offset: 0x00000EAC
	// (set) Token: 0x0600031A RID: 794 RVA: 0x00002CB0 File Offset: 0x00000EB0
	public Color effectColor
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x0600031B RID: 795 RVA: 0x00002CB4 File Offset: 0x00000EB4
	// (set) Token: 0x0600031C RID: 796 RVA: 0x00002CB8 File Offset: 0x00000EB8
	public Vector2 effectDistance
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x0600031D RID: 797 RVA: 0x00002CBC File Offset: 0x00000EBC
	public string processedText
	{
		get
		{
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x0600031E RID: 798 RVA: 0x00002CC0 File Offset: 0x00000EC0
	public override Material material
	{
		get
		{
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x0600031F RID: 799 RVA: 0x00002CC4 File Offset: 0x00000EC4
	public override Vector2 relativeSize
	{
		get
		{
		}
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00002CC8 File Offset: 0x00000EC8
	protected override void OnStart()
	{
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00002CCC File Offset: 0x00000ECC
	public override void MarkAsChanged()
	{
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00002CD0 File Offset: 0x00000ED0
	private void ProcessText()
	{
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00002CD4 File Offset: 0x00000ED4
	public void MakePositionPerfect()
	{
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00002CD8 File Offset: 0x00000ED8
	public override void MakePixelPerfect()
	{
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00002CDC File Offset: 0x00000EDC
	private void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00002CE0 File Offset: 0x00000EE0
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	// Token: 0x040002DF RID: 735
	[HideInInspector]
	[SerializeField]
	private UIFont mFont;

	// Token: 0x040002E0 RID: 736
	[SerializeField]
	[HideInInspector]
	private string mText;

	// Token: 0x040002E1 RID: 737
	[HideInInspector]
	[SerializeField]
	private int mMaxLineWidth;

	// Token: 0x040002E2 RID: 738
	[SerializeField]
	[HideInInspector]
	private bool mEncoding;

	// Token: 0x040002E3 RID: 739
	[HideInInspector]
	[SerializeField]
	private int mMaxLineCount;

	// Token: 0x040002E4 RID: 740
	[SerializeField]
	[HideInInspector]
	private bool mPassword;

	// Token: 0x040002E5 RID: 741
	[HideInInspector]
	[SerializeField]
	private bool mShowLastChar;

	// Token: 0x040002E6 RID: 742
	[SerializeField]
	[HideInInspector]
	private UILabel.Effect mEffectStyle;

	// Token: 0x040002E7 RID: 743
	[SerializeField]
	[HideInInspector]
	private Color mEffectColor;

	// Token: 0x040002E8 RID: 744
	[SerializeField]
	[HideInInspector]
	private UIFont.SymbolStyle mSymbols;

	// Token: 0x040002E9 RID: 745
	[SerializeField]
	[HideInInspector]
	private Vector2 mEffectDistance;

	// Token: 0x040002EA RID: 746
	[SerializeField]
	[HideInInspector]
	private float mLineWidth;

	// Token: 0x040002EB RID: 747
	[SerializeField]
	[HideInInspector]
	private bool mMultiline;

	// Token: 0x040002EC RID: 748
	private bool mShouldBeProcessed;

	// Token: 0x040002ED RID: 749
	private string mProcessedText;

	// Token: 0x040002EE RID: 750
	private Vector3 mLastScale;

	// Token: 0x040002EF RID: 751
	private string mLastText;

	// Token: 0x040002F0 RID: 752
	private int mLastWidth;

	// Token: 0x040002F1 RID: 753
	private bool mLastEncoding;

	// Token: 0x040002F2 RID: 754
	private int mLastCount;

	// Token: 0x040002F3 RID: 755
	private bool mLastPass;

	// Token: 0x040002F4 RID: 756
	private bool mLastShow;

	// Token: 0x040002F5 RID: 757
	private UILabel.Effect mLastEffect;

	// Token: 0x040002F6 RID: 758
	private Vector3 mSize;

	// Token: 0x02000070 RID: 112
	public enum Effect
	{
		// Token: 0x040002F8 RID: 760
		None,
		// Token: 0x040002F9 RID: 761
		Shadow,
		// Token: 0x040002FA RID: 762
		Outline
	}
}
