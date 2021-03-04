using UnityEngine;

[AddComponentMenu("NGUI/Internal/Draw Call")]
[ExecuteInEditMode]
public class UIDrawCall : MonoBehaviour
{
	public enum Clipping
	{
		None,
		HardClip,
		AlphaClip,
		SoftClip
	}

	private Transform mTrans;

	private Material mSharedMat;

	private Mesh mMesh0;

	private Mesh mMesh1;

	private MeshFilter mFilter;

	private MeshRenderer mRen;

	private Clipping mClipping;

	private Vector4 mClipRange;

	private Vector2 mClipSoft;

	private Material mClippedMat;

	private Material mDepthMat;

	private int[] mIndices;

	private bool mDepthPass;

	private bool mReset;

	private bool mEven;

	public bool depthPass
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public Transform cachedTransform => (Transform)/*Error near IL_0001: Stack underflow*/;

	public Material material
	{
		get
		{
			return (Material)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int triangles => (int)/*Error near IL_0001: Stack underflow*/;

	public Clipping clipping
	{
		get
		{
			return (Clipping)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Vector4 clipRange
	{
		get
		{
			return (Vector4)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Vector2 clipSoftness
	{
		get
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	private Mesh GetMesh(ref bool rebuildIndices, int vertexCount)
	{
		return (Mesh)/*Error near IL_0001: Stack underflow*/;
	}

	private void UpdateMaterials()
	{
	}

	public void Set(BetterList<Vector3> verts, BetterList<Vector3> norms, BetterList<Vector4> tans, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	private void OnWillRenderObject()
	{
	}

	private void OnDestroy()
	{
	}
}
