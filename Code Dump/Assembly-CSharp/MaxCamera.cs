using System;
using UnityEngine;

// Token: 0x02000100 RID: 256
[AddComponentMenu("Camera-Control/3dsMax Camera Style")]
public class MaxCamera : MonoBehaviour
{
	// Token: 0x060007BA RID: 1978 RVA: 0x000039E8 File Offset: 0x00001BE8
	private void OnEnable()
	{
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x000039EC File Offset: 0x00001BEC
	private void OnDisable()
	{
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x000039F0 File Offset: 0x00001BF0
	public void Init()
	{
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x000039F4 File Offset: 0x00001BF4
	public void Reset()
	{
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x000039F8 File Offset: 0x00001BF8
	public void OnZoom(float deltaY)
	{
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x000039FC File Offset: 0x00001BFC
	public void OnOrbit(float deltaX, float deltaY)
	{
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00003A00 File Offset: 0x00001C00
	public void OnPan(float deltaX, float deltaY)
	{
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00003A04 File Offset: 0x00001C04
	public void OnZoom()
	{
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00003A08 File Offset: 0x00001C08
	public void OnOrbit()
	{
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00003A0C File Offset: 0x00001C0C
	public void OnPan()
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00003A10 File Offset: 0x00001C10
	private void LateUpdate()
	{
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00003A14 File Offset: 0x00001C14
	private static float ClampAngle(float angle, float min, float max)
	{
	}

	// Token: 0x040004CF RID: 1231
	private const float xSpeed = 10f;

	// Token: 0x040004D0 RID: 1232
	private const float ySpeed = 10f;

	// Token: 0x040004D1 RID: 1233
	public Transform realTarget;

	// Token: 0x040004D2 RID: 1234
	public Transform target;

	// Token: 0x040004D3 RID: 1235
	public Vector3 targetOffset;

	// Token: 0x040004D4 RID: 1236
	public float distance;

	// Token: 0x040004D5 RID: 1237
	public float maxDistance;

	// Token: 0x040004D6 RID: 1238
	public float minDistance;

	// Token: 0x040004D7 RID: 1239
	public int yMinLimit;

	// Token: 0x040004D8 RID: 1240
	public int yMaxLimit;

	// Token: 0x040004D9 RID: 1241
	public int zoomRate;

	// Token: 0x040004DA RID: 1242
	public float panSpeed;

	// Token: 0x040004DB RID: 1243
	public float zoomDampening;

	// Token: 0x040004DC RID: 1244
	private float currentDistance;

	// Token: 0x040004DD RID: 1245
	private float desiredDistance;

	// Token: 0x040004DE RID: 1246
	private Quaternion rotation;

	// Token: 0x040004DF RID: 1247
	private Vector3 position;
}
