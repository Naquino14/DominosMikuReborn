using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000F4 RID: 244
public class VirtualButtonBehaviour : MonoBehaviour, IEditorVirtualButtonBehaviour
{
	// Token: 0x06000762 RID: 1890 RVA: 0x00003888 File Offset: 0x00001A88
	bool IEditorVirtualButtonBehaviour.SetVirtualButtonName(string virtualButtonName)
	{
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000763 RID: 1891 RVA: 0x0000388C File Offset: 0x00001A8C
	VirtualButton.Sensitivity IEditorVirtualButtonBehaviour.SensitivitySetting
	{
		get
		{
		}
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00003890 File Offset: 0x00001A90
	bool IEditorVirtualButtonBehaviour.SetSensitivitySetting(VirtualButton.Sensitivity sensibility)
	{
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000765 RID: 1893 RVA: 0x00003894 File Offset: 0x00001A94
	Matrix4x4 IEditorVirtualButtonBehaviour.PreviousTransform
	{
		get
		{
		}
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00003898 File Offset: 0x00001A98
	bool IEditorVirtualButtonBehaviour.SetPreviousTransform(Matrix4x4 transform)
	{
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000767 RID: 1895 RVA: 0x0000389C File Offset: 0x00001A9C
	GameObject IEditorVirtualButtonBehaviour.PreviousParent
	{
		get
		{
		}
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x000038A0 File Offset: 0x00001AA0
	bool IEditorVirtualButtonBehaviour.SetPreviousParent(GameObject parent)
	{
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x000038A4 File Offset: 0x00001AA4
	void IEditorVirtualButtonBehaviour.InitializeVirtualButton(VirtualButton virtualButton)
	{
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x000038A8 File Offset: 0x00001AA8
	bool IEditorVirtualButtonBehaviour.SetPosAndScaleFromButtonArea(Vector2 topLeft, Vector2 bottomRight)
	{
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x0600076B RID: 1899 RVA: 0x000038AC File Offset: 0x00001AAC
	public string VirtualButtonName
	{
		get
		{
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x0600076C RID: 1900 RVA: 0x000038B0 File Offset: 0x00001AB0
	public bool Pressed
	{
		get
		{
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x0600076D RID: 1901 RVA: 0x000038B4 File Offset: 0x00001AB4
	public bool HasUpdatedPose
	{
		get
		{
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x0600076E RID: 1902 RVA: 0x000038B8 File Offset: 0x00001AB8
	// (set) Token: 0x0600076F RID: 1903 RVA: 0x000038BC File Offset: 0x00001ABC
	public bool UnregisterOnDestroy
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000770 RID: 1904 RVA: 0x000038C0 File Offset: 0x00001AC0
	public VirtualButton VirtualButton
	{
		get
		{
		}
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x000038C4 File Offset: 0x00001AC4
	public void RegisterEventHandler(IVirtualButtonEventHandler eventHandler)
	{
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x000038C8 File Offset: 0x00001AC8
	public bool UnregisterEventHandler(IVirtualButtonEventHandler eventHandler)
	{
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x000038CC File Offset: 0x00001ACC
	public bool CalculateButtonArea(out Vector2 topLeft, out Vector2 bottomRight)
	{
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x000038D0 File Offset: 0x00001AD0
	public bool UpdateAreaRectangle()
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x000038D4 File Offset: 0x00001AD4
	public bool UpdateSensitivity()
	{
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x000038D8 File Offset: 0x00001AD8
	private bool UpdateEnabled()
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x000038DC File Offset: 0x00001ADC
	public bool UpdatePose()
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x000038E0 File Offset: 0x00001AE0
	public void OnTrackerUpdated(bool pressed)
	{
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x000038E4 File Offset: 0x00001AE4
	public ImageTargetBehaviour GetImageTargetBehaviour()
	{
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x000038E8 File Offset: 0x00001AE8
	private void LateUpdate()
	{
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x000038EC File Offset: 0x00001AEC
	private void OnDisable()
	{
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x000038F0 File Offset: 0x00001AF0
	private void OnDestroy()
	{
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x000038F4 File Offset: 0x00001AF4
	private static bool Equals(Vector2 vec1, Vector2 vec2, float threshold)
	{
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x000038F8 File Offset: 0x00001AF8
	virtual bool get_enabled()
	{
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x000038FC File Offset: 0x00001AFC
	virtual void set_enabled(bool value)
	{
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00003900 File Offset: 0x00001B00
	virtual Transform get_transform()
	{
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00003904 File Offset: 0x00001B04
	virtual GameObject get_gameObject()
	{
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00003908 File Offset: 0x00001B08
	virtual Renderer get_renderer()
	{
	}

	// Token: 0x040004B6 RID: 1206
	public const float TARGET_OFFSET = 0.001f;

	// Token: 0x040004B7 RID: 1207
	[SerializeField]
	[HideInInspector]
	private string mName;

	// Token: 0x040004B8 RID: 1208
	[HideInInspector]
	[SerializeField]
	private VirtualButton.Sensitivity mSensitivity;

	// Token: 0x040004B9 RID: 1209
	[HideInInspector]
	[SerializeField]
	private bool mHasUpdatedPose;

	// Token: 0x040004BA RID: 1210
	[SerializeField]
	[HideInInspector]
	private Matrix4x4 mPrevTransform;

	// Token: 0x040004BB RID: 1211
	[HideInInspector]
	[SerializeField]
	private GameObject mPrevParent;

	// Token: 0x040004BC RID: 1212
	private bool mSensitivityDirty;

	// Token: 0x040004BD RID: 1213
	private bool mPreviouslyEnabled;

	// Token: 0x040004BE RID: 1214
	private bool mPressed;

	// Token: 0x040004BF RID: 1215
	private List<IVirtualButtonEventHandler> mHandlers;

	// Token: 0x040004C0 RID: 1216
	private Vector2 mLeftTop;

	// Token: 0x040004C1 RID: 1217
	private Vector2 mRightBottom;

	// Token: 0x040004C2 RID: 1218
	private bool mUnregisterOnDestroy;

	// Token: 0x040004C3 RID: 1219
	private VirtualButton mVirtualButton;
}
