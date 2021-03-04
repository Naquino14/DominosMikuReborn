using UnityEngine;

public class UIGeometry
{
	public BetterList<Vector3> verts;

	public BetterList<Vector2> uvs;

	public BetterList<Color32> cols;

	private BetterList<Vector3> mRtpVerts;

	private Vector3 mRtpNormal;

	private Vector4 mRtpTan;

	public bool hasVertices => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public bool hasTransformed => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public void Clear()
	{
	}

	public void ApplyOffset(Vector3 pivotOffset)
	{
	}

	public void ApplyTransform(Matrix4x4 widgetToPanel, bool normals)
	{
	}

	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}
}
