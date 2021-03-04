using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

// Token: 0x02000073 RID: 115
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Panel")]
public class UIPanel : MonoBehaviour
{
	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000331 RID: 817 RVA: 0x00002D0C File Offset: 0x00000F0C
	public Transform cachedTransform
	{
		get
		{
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000332 RID: 818 RVA: 0x00002D10 File Offset: 0x00000F10
	public bool changedLastFrame
	{
		get
		{
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000333 RID: 819 RVA: 0x00002D14 File Offset: 0x00000F14
	// (set) Token: 0x06000334 RID: 820 RVA: 0x00002D18 File Offset: 0x00000F18
	public UIPanel.DebugInfo debugInfo
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000335 RID: 821 RVA: 0x00002D1C File Offset: 0x00000F1C
	// (set) Token: 0x06000336 RID: 822 RVA: 0x00002D20 File Offset: 0x00000F20
	public UIDrawCall.Clipping clipping
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000337 RID: 823 RVA: 0x00002D24 File Offset: 0x00000F24
	// (set) Token: 0x06000338 RID: 824 RVA: 0x00002D28 File Offset: 0x00000F28
	public Vector4 clipRange
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x06000339 RID: 825 RVA: 0x00002D2C File Offset: 0x00000F2C
	// (set) Token: 0x0600033A RID: 826 RVA: 0x00002D30 File Offset: 0x00000F30
	public Vector2 clipSoftness
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x0600033B RID: 827 RVA: 0x00002D34 File Offset: 0x00000F34
	public BetterList<UIWidget> widgets
	{
		get
		{
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x0600033C RID: 828 RVA: 0x00002D38 File Offset: 0x00000F38
	public BetterList<UIDrawCall> drawCalls
	{
		get
		{
		}
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00002D3C File Offset: 0x00000F3C
	private UINode GetNode(Transform t)
	{
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00002D40 File Offset: 0x00000F40
	private bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00002D44 File Offset: 0x00000F44
	public bool IsVisible(Vector3 worldPos)
	{
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00002D48 File Offset: 0x00000F48
	public bool IsVisible(UIWidget w)
	{
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00002D4C File Offset: 0x00000F4C
	public void MarkMaterialAsChanged(Material mat, bool sort)
	{
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00002D50 File Offset: 0x00000F50
	public bool WatchesTransform(Transform t)
	{
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00002D54 File Offset: 0x00000F54
	private UINode AddTransform(Transform t)
	{
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00002D58 File Offset: 0x00000F58
	private void RemoveTransform(Transform t)
	{
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00002D5C File Offset: 0x00000F5C
	public void AddWidget(UIWidget w)
	{
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00002D60 File Offset: 0x00000F60
	public void RemoveWidget(UIWidget w)
	{
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00002D64 File Offset: 0x00000F64
	private UIDrawCall GetDrawCall(Material mat, bool createIfMissing)
	{
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00002D68 File Offset: 0x00000F68
	private void Start()
	{
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00002D6C File Offset: 0x00000F6C
	private void OnEnable()
	{
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00002D70 File Offset: 0x00000F70
	private void OnDisable()
	{
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00002D74 File Offset: 0x00000F74
	private int GetChangeFlag(UINode start)
	{
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00002D78 File Offset: 0x00000F78
	private void UpdateTransformMatrix()
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002D7C File Offset: 0x00000F7C
	private void UpdateTransforms()
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00002D80 File Offset: 0x00000F80
	private void UpdateWidgets()
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00002D84 File Offset: 0x00000F84
	public void UpdateDrawcalls()
	{
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00002D88 File Offset: 0x00000F88
	private void Fill(Material mat)
	{
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00002D8C File Offset: 0x00000F8C
	private void LateUpdate()
	{
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00002D90 File Offset: 0x00000F90
	public void Refresh()
	{
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00002D94 File Offset: 0x00000F94
	public Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00002D98 File Offset: 0x00000F98
	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00002D9C File Offset: 0x00000F9C
	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00002DA0 File Offset: 0x00000FA0
	private static void SetChildLayer(Transform t, int layer)
	{
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00002DA4 File Offset: 0x00000FA4
	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00002DA8 File Offset: 0x00000FA8
	public static UIPanel Find(Transform trans)
	{
	}

	// Token: 0x04000300 RID: 768
	public bool showInPanelTool;

	// Token: 0x04000301 RID: 769
	public bool generateNormals;

	// Token: 0x04000302 RID: 770
	public bool depthPass;

	// Token: 0x04000303 RID: 771
	public bool widgetsAreStatic;

	// Token: 0x04000304 RID: 772
	[SerializeField]
	[HideInInspector]
	private UIPanel.DebugInfo mDebugInfo;

	// Token: 0x04000305 RID: 773
	[SerializeField]
	[HideInInspector]
	private UIDrawCall.Clipping mClipping;

	// Token: 0x04000306 RID: 774
	[SerializeField]
	[HideInInspector]
	private Vector4 mClipRange;

	// Token: 0x04000307 RID: 775
	[SerializeField]
	[HideInInspector]
	private Vector2 mClipSoftness;

	// Token: 0x04000308 RID: 776
	private OrderedDictionary mChildren;

	// Token: 0x04000309 RID: 777
	private BetterList<UIWidget> mWidgets;

	// Token: 0x0400030A RID: 778
	private BetterList<Material> mChanged;

	// Token: 0x0400030B RID: 779
	private BetterList<UIDrawCall> mDrawCalls;

	// Token: 0x0400030C RID: 780
	private BetterList<Vector3> mVerts;

	// Token: 0x0400030D RID: 781
	private BetterList<Vector3> mNorms;

	// Token: 0x0400030E RID: 782
	private BetterList<Vector4> mTans;

	// Token: 0x0400030F RID: 783
	private BetterList<Vector2> mUvs;

	// Token: 0x04000310 RID: 784
	private BetterList<Color32> mCols;

	// Token: 0x04000311 RID: 785
	private Transform mTrans;

	// Token: 0x04000312 RID: 786
	private Camera mCam;

	// Token: 0x04000313 RID: 787
	private int mLayer;

	// Token: 0x04000314 RID: 788
	private bool mDepthChanged;

	// Token: 0x04000315 RID: 789
	private bool mRebuildAll;

	// Token: 0x04000316 RID: 790
	private bool mChangedLastFrame;

	// Token: 0x04000317 RID: 791
	private bool mWidgetsAdded;

	// Token: 0x04000318 RID: 792
	private float mMatrixTime;

	// Token: 0x04000319 RID: 793
	private Matrix4x4 mWorldToLocal;

	// Token: 0x0400031A RID: 794
	private static float[] mTemp;

	// Token: 0x0400031B RID: 795
	private Vector2 mMin;

	// Token: 0x0400031C RID: 796
	private Vector2 mMax;

	// Token: 0x0400031D RID: 797
	private List<Transform> mRemoved;

	// Token: 0x0400031E RID: 798
	private bool mCheckVisibility;

	// Token: 0x0400031F RID: 799
	private float mCullTime;

	// Token: 0x04000320 RID: 800
	private bool mCulled;

	// Token: 0x04000321 RID: 801
	private static BetterList<UINode> mHierarchy;

	// Token: 0x02000074 RID: 116
	public enum DebugInfo
	{
		// Token: 0x04000323 RID: 803
		None,
		// Token: 0x04000324 RID: 804
		Gizmos,
		// Token: 0x04000325 RID: 805
		Geometry
	}
}
