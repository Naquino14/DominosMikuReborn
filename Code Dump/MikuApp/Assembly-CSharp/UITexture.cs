using UnityEngine;

[AddComponentMenu("NGUI/UI/Texture")]
[ExecuteInEditMode]
public class UITexture : UIWidget
{
	[SerializeField]
	[HideInInspector]
	private Rect mRect;

	[SerializeField]
	[HideInInspector]
	private Shader mShader;

	[HideInInspector]
	[SerializeField]
	private Texture mTexture;

	private Material mDynamicMat;

	private bool mCreatingMat;

	public Rect uvRect
	{
		get
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Shader shader
	{
		get
		{
			return (Shader)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool hasDynamicMaterial => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public override bool keepMaterial => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public override Material material
	{
		get
		{
			return (Material)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override Texture mainTexture
	{
		get
		{
			return (Texture)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	private void OnDestroy()
	{
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
