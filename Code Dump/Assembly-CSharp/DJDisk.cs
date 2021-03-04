using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000119 RID: 281
public class DJDisk : MonoBehaviour
{
	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000866 RID: 2150 RVA: 0x00003C94 File Offset: 0x00001E94
	// (remove) Token: 0x06000867 RID: 2151 RVA: 0x00003C98 File Offset: 0x00001E98
	public event Action onRotationFinish
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

	// Token: 0x06000868 RID: 2152 RVA: 0x00003C9C File Offset: 0x00001E9C
	private void Awake()
	{
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00003CA0 File Offset: 0x00001EA0
	private void Start()
	{
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00003CA4 File Offset: 0x00001EA4
	private void Init()
	{
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00003CA8 File Offset: 0x00001EA8
	public GameObject GetItem(int index)
	{
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00003CAC File Offset: 0x00001EAC
	public void AddItemToDjList(string[] items)
	{
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00003CB0 File Offset: 0x00001EB0
	public void SetCenterIndex(int centerIdx)
	{
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00003CB4 File Offset: 0x00001EB4
	public void SetCenterIndex(string centerItem)
	{
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00003CB8 File Offset: 0x00001EB8
	private void Update()
	{
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00003CBC File Offset: 0x00001EBC
	private void ResetItemRotation()
	{
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x00003CC0 File Offset: 0x00001EC0
	private void HideAllItem()
	{
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00003CC4 File Offset: 0x00001EC4
	private void MoveAwayAllItem()
	{
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00003CC8 File Offset: 0x00001EC8
	private void OnWheelPress()
	{
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00003CCC File Offset: 0x00001ECC
	public void ChangeImage(int index, string spriteName)
	{
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00003CD0 File Offset: 0x00001ED0
	public void ForceWheelPress(bool close)
	{
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00003CD4 File Offset: 0x00001ED4
	private void OnPress(bool pressed)
	{
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00003CD8 File Offset: 0x00001ED8
	public void ForceItemWithoutCallback(int i)
	{
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00003CDC File Offset: 0x00001EDC
	protected void AutoRotate(bool useTween)
	{
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00003CE0 File Offset: 0x00001EE0
	public void StartAutoRotateEffect(float _maxTime, int _checkIndex)
	{
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00003CE4 File Offset: 0x00001EE4
	public void StopAutoRotateEffect()
	{
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x00003CE8 File Offset: 0x00001EE8
	protected virtual float AngleToCenter(float angle)
	{
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00003CEC File Offset: 0x00001EEC
	private void AfterTouchRelease()
	{
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00003CF0 File Offset: 0x00001EF0
	private void OnDrag(Vector2 delta)
	{
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x00003CF4 File Offset: 0x00001EF4
	private void SetBoxCollider()
	{
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00003CF8 File Offset: 0x00001EF8
	private void SetProp()
	{
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x00003CFC File Offset: 0x00001EFC
	private void SetFirstPosition()
	{
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00003D00 File Offset: 0x00001F00
	protected virtual void SetFirstPositionOfCenterIndex()
	{
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x00003D04 File Offset: 0x00001F04
	private void SetFirstPositionOf(int fromIndex, int toIndex)
	{
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x00003D08 File Offset: 0x00001F08
	protected virtual void SetItemRotation(int index, float angle)
	{
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00003D0C File Offset: 0x00001F0C
	protected virtual bool HideItemCondition(float x, float y)
	{
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00003D10 File Offset: 0x00001F10
	protected virtual float XfromAlpha(float a, int step)
	{
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00003D14 File Offset: 0x00001F14
	protected virtual float YfromAlpha(float a, int step)
	{
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00003D18 File Offset: 0x00001F18
	protected virtual float ClampAngle(float angle, float direction)
	{
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x00003D1C File Offset: 0x00001F1C
	private void RotateImage(float angle, float time)
	{
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00003D20 File Offset: 0x00001F20
	private void RotateImage(Transform _rotatePanel, float angle, float time, bool _isUseCallback)
	{
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00003D24 File Offset: 0x00001F24
	private void OnAutoRotating()
	{
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00003D28 File Offset: 0x00001F28
	private void RotateImage(float angle)
	{
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00003D2C File Offset: 0x00001F2C
	private void RotateItems(float angle, float time)
	{
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00003D30 File Offset: 0x00001F30
	private void RotateItems(float angle)
	{
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00003D34 File Offset: 0x00001F34
	protected virtual void GetCenter(float angle)
	{
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x00003D38 File Offset: 0x00001F38
	private void SetItemsVisible()
	{
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00003D3C File Offset: 0x00001F3C
	private void SetItemsVisibleOfCenterIndex()
	{
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x00003D40 File Offset: 0x00001F40
	private void SetItemsVisibleOf(int fromIndex, int toIndex)
	{
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x00003D44 File Offset: 0x00001F44
	protected float GetAngleOf(GameObject item)
	{
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00003D48 File Offset: 0x00001F48
	private bool IsLeft(Vector2 a, Vector2 b, Vector2 c)
	{
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00003D4C File Offset: 0x00001F4C
	private void ChangeItemAlpha(GameObject go, float alpha)
	{
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00003D50 File Offset: 0x00001F50
	protected bool isHideItem(GameObject go)
	{
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x00003D54 File Offset: 0x00001F54
	private void HideItem(GameObject go)
	{
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00003D58 File Offset: 0x00001F58
	private void ShowItem(GameObject go)
	{
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00003D5C File Offset: 0x00001F5C
	private void DeactiveAllItemTween()
	{
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00003D60 File Offset: 0x00001F60
	private void SetItemColor(GameObject go, Color col)
	{
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00003D64 File Offset: 0x00001F64
	protected virtual void SetCenterItemColor()
	{
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x00003D68 File Offset: 0x00001F68
	public virtual void SetAllItemWhite()
	{
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00003D6C File Offset: 0x00001F6C
	public int GetCurrentIndex()
	{
	}

	// Token: 0x04000559 RID: 1369
	public DJDisk.item_change_delegate OnItemChange;

	// Token: 0x0400055A RID: 1370
	[SerializeField]
	protected Transform rotatePanel;

	// Token: 0x0400055B RID: 1371
	[SerializeField]
	protected Transform rotate2Panel;

	// Token: 0x0400055C RID: 1372
	[SerializeField]
	protected Transform anchor;

	// Token: 0x0400055D RID: 1373
	[SerializeField]
	protected Transform image;

	// Token: 0x0400055E RID: 1374
	[SerializeField]
	protected GameObject[] djItemList;

	// Token: 0x0400055F RID: 1375
	[SerializeField]
	protected int centerIndex;

	// Token: 0x04000560 RID: 1376
	[SerializeField]
	protected float angleDistance;

	// Token: 0x04000561 RID: 1377
	[SerializeField]
	protected float rotateSpeed;

	// Token: 0x04000562 RID: 1378
	[SerializeField]
	protected Vector2 centRatio;

	// Token: 0x04000563 RID: 1379
	[SerializeField]
	protected DJDisk.TextRotateMode textRotateMode;

	// Token: 0x04000564 RID: 1380
	[SerializeField]
	protected Color selectedColor;

	// Token: 0x04000565 RID: 1381
	[SerializeField]
	protected Color unSelectedColor;

	// Token: 0x04000566 RID: 1382
	[SerializeField]
	protected int maxPart;

	// Token: 0x04000567 RID: 1383
	[SerializeField]
	protected float offsetRadius;

	// Token: 0x04000568 RID: 1384
	protected Vector2 prev;

	// Token: 0x04000569 RID: 1385
	protected Vector2 cent;

	// Token: 0x0400056A RID: 1386
	protected float radius;

	// Token: 0x0400056B RID: 1387
	protected float circle;

	// Token: 0x0400056C RID: 1388
	protected int curCenter;

	// Token: 0x0400056D RID: 1389
	protected int prevCenter;

	// Token: 0x0400056E RID: 1390
	protected bool isClose;

	// Token: 0x0400056F RID: 1391
	protected bool isInited;

	// Token: 0x04000570 RID: 1392
	protected bool isAutoRotateEffect;

	// Token: 0x04000571 RID: 1393
	protected float curDelta;

	// Token: 0x04000572 RID: 1394
	protected float maxTime;

	// Token: 0x04000573 RID: 1395
	protected int checkIndex;

	// Token: 0x04000574 RID: 1396
	protected float checkRotation;

	// Token: 0x0200011A RID: 282
	public enum TextRotateMode
	{
		// Token: 0x04000577 RID: 1399
		NO_TEXT_ROTATION,
		// Token: 0x04000578 RID: 1400
		TEXT_ALWAYS_UP
	}

	// Token: 0x02000165 RID: 357
	// (Invoke) Token: 0x06000B89 RID: 2953
	public delegate void item_change_delegate(int itemId);
}
