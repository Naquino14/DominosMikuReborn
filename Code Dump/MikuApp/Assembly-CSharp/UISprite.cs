using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Basic)")]
public class UISprite : UIWidget
{
	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	protected UIAtlas.Sprite mSprite;

	protected Rect mOuter;

	protected Rect mOuterUV;

	private bool mSpriteSet;

	private string mLastName;

	public Rect outerUV => (Rect)/*Error near IL_0001: Stack underflow*/;

	public UIAtlas atlas
	{
		get
		{
			return (UIAtlas)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public string spriteName
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public UIAtlas.Sprite sprite
	{
		get
		{
			return (UIAtlas.Sprite)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override Vector2 pivotOffset => (Vector2)/*Error near IL_0001: Stack underflow*/;

	public override Material material => (Material)/*Error near IL_0001: Stack underflow*/;

	public virtual Vector4 border => (Vector4)/*Error near IL_0001: Stack underflow*/;

	public virtual void UpdateUVs(bool force)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	protected override void OnStart()
	{
	}

	public override bool OnUpdate()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
