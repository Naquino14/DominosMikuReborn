using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Sliced)")]
public class UISlicedSprite : UISprite
{
	[SerializeField]
	[HideInInspector]
	private bool mFillCenter;

	protected Rect mInner;

	protected Rect mInnerUV;

	protected Vector3 mScale;

	public Rect innerUV => (Rect)/*Error near IL_0001: Stack underflow*/;

	public bool fillCenter
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public override Vector4 border => (Vector4)/*Error near IL_0001: Stack underflow*/;

	public override Vector2 pivotOffset => (Vector2)/*Error near IL_0001: Stack underflow*/;

	public override void UpdateUVs(bool force)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
