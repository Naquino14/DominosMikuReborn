using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Filled)")]
public class UIFilledSprite : UISprite
{
	public enum FillDirection
	{
		Horizontal,
		Vertical,
		Radial90,
		Radial180,
		Radial360
	}

	[HideInInspector]
	[SerializeField]
	private FillDirection mFillDirection;

	[HideInInspector]
	[SerializeField]
	private float mFillAmount;

	[SerializeField]
	[HideInInspector]
	private bool mInvert;

	public FillDirection fillDirection
	{
		get
		{
			return (FillDirection)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public float fillAmount
	{
		get
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool invert
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	private bool AdjustRadial(Vector2[] xy, Vector2[] uv, float fill, bool invert)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private void Rotate(Vector2[] v, int offset)
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
