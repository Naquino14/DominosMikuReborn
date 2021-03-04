using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Mesh : Object
	{
		public bool isReadable
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		internal bool canAccess
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Vector3[] vertices
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Vector3[] normals
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Vector4[] tangents
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Vector2[] uv
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Vector2[] uv2
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Vector2[] uv1
		{
			get
			{
				return (Vector2[])/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Bounds bounds
		{
			get
			{
				return (Bounds)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Color[] colors
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Color32[] colors32
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int[] triangles
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int vertexCount
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public int subMeshCount
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public BoneWeight[] boneWeights
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Matrix4x4[] bindposes
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_Create([Writable] Mesh mono);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Clear(bool keepVertexLayout);

		public void Clear()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_bounds(out Bounds value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_bounds(ref Bounds value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void RecalculateBounds();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void RecalculateNormals();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Optimize();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern int[] GetTriangles(int submesh);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SetTriangles(int[] triangles, int submesh);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern int[] GetIndices(int submesh);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SetIndices(int[] indices, MeshTopology topology, int submesh);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern MeshTopology GetTopology(int submesh);

		[MethodImpl(4096)]
		[Obsolete("Use SetTriangles instead. Internally this function will convert the triangle strip to a list of triangles anyway.")]
		[WrapperlessIcall]
		public extern void SetTriangleStrip(int[] triangles, int submesh);

		[MethodImpl(4096)]
		[Obsolete("Use GetTriangles instead. Internally this function converts a list of triangles to a strip, so it might be slow, it might be a mess.")]
		[WrapperlessIcall]
		public extern int[] GetTriangleStrip(int submesh);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices);

		public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes)
		{
		}

		public void CombineMeshes(CombineInstance[] combine)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void MarkDynamic();
	}
}
