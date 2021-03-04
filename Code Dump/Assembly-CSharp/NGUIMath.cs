using System;
using UnityEngine;

// Token: 0x02000045 RID: 69
public static class NGUIMath
{
	// Token: 0x0600019D RID: 413 RVA: 0x000026C0 File Offset: 0x000008C0
	public static float Lerp(float from, float to, float factor)
	{
	}

	// Token: 0x0600019E RID: 414 RVA: 0x000026C4 File Offset: 0x000008C4
	public static int ClampIndex(int val, int max)
	{
	}

	// Token: 0x0600019F RID: 415 RVA: 0x000026C8 File Offset: 0x000008C8
	public static int RepeatIndex(int val, int max)
	{
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x000026CC File Offset: 0x000008CC
	public static float WrapAngle(float angle)
	{
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x000026D0 File Offset: 0x000008D0
	public static float Wrap01(float val)
	{
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x000026D4 File Offset: 0x000008D4
	public static int HexToDecimal(char ch)
	{
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x000026D8 File Offset: 0x000008D8
	public static char DecimalToHexChar(int num)
	{
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x000026DC File Offset: 0x000008DC
	public static string DecimalToHex(int num)
	{
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x000026E0 File Offset: 0x000008E0
	public static int ColorToInt(Color c)
	{
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x000026E4 File Offset: 0x000008E4
	public static Color IntToColor(int val)
	{
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x000026E8 File Offset: 0x000008E8
	public static string IntToBinary(int val, int bits)
	{
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x000026EC File Offset: 0x000008EC
	public static Color HexToColor(uint val)
	{
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x000026F0 File Offset: 0x000008F0
	public static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
	}

	// Token: 0x060001AA RID: 426 RVA: 0x000026F4 File Offset: 0x000008F4
	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
	}

	// Token: 0x060001AB RID: 427 RVA: 0x000026F8 File Offset: 0x000008F8
	public static Rect MakePixelPerfect(Rect rect)
	{
	}

	// Token: 0x060001AC RID: 428 RVA: 0x000026FC File Offset: 0x000008FC
	public static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00002700 File Offset: 0x00000900
	public static Vector3 ApplyHalfPixelOffset(Vector3 pos)
	{
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00002704 File Offset: 0x00000904
	public static Vector3 ApplyHalfPixelOffset(Vector3 pos, Vector3 scale)
	{
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00002708 File Offset: 0x00000908
	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x0000270C File Offset: 0x0000090C
	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00002710 File Offset: 0x00000910
	public static Bounds CalculateRelativeWidgetBounds(Transform root, Transform child)
	{
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00002714 File Offset: 0x00000914
	public static Bounds CalculateRelativeInnerBounds(Transform root, UISlicedSprite sprite)
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00002718 File Offset: 0x00000918
	public static Bounds CalculateRelativeInnerBounds(Transform root, UISprite sprite)
	{
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x0000271C File Offset: 0x0000091C
	public static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00002720 File Offset: 0x00000920
	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00002724 File Offset: 0x00000924
	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00002728 File Offset: 0x00000928
	public static float SpringLerp(float strength, float deltaTime)
	{
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x0000272C File Offset: 0x0000092C
	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00002730 File Offset: 0x00000930
	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00002734 File Offset: 0x00000934
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00002738 File Offset: 0x00000938
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0000273C File Offset: 0x0000093C
	public static float RotateTowards(float from, float to, float maxAngle)
	{
	}
}
