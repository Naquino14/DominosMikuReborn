using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Camera : Behaviour
	{
		public float fov
		{
			get
			{
				return (float)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public float fieldOfView
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float nearClipPlane
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float farClipPlane
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float orthographicSize
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool orthographic
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool isOrthoGraphic
		{
			set
			{
			}
		}

		public float depth
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float aspect
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int cullingMask
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int eventMask
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Color backgroundColor
		{
			get
			{
				return (Color)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Rect rect
		{
			get
			{
				return (Rect)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Rect pixelRect => (Rect)/*Error near IL_0001: Stack underflow*/;

		public RenderTexture targetTexture
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float pixelWidth
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public float pixelHeight
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Matrix4x4 projectionMatrix
		{
			set
			{
			}
		}

		public CameraClearFlags clearFlags
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static Camera main
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static Camera[] allCameras
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_backgroundColor(out Color value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_backgroundColor(ref Color value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_rect(out Rect value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_rect(ref Rect value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_pixelRect(out Rect value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_projectionMatrix(ref Matrix4x4 value);

		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_WorldToScreenPoint(Camera self, ref Vector3 position);

		public Vector3 WorldToViewportPoint(Vector3 position)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_WorldToViewportPoint(Camera self, ref Vector3 position);

		public Vector3 ViewportToWorldPoint(Vector3 position)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_ViewportToWorldPoint(Camera self, ref Vector3 position);

		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_ScreenToWorldPoint(Camera self, ref Vector3 position);

		public Vector3 ScreenToViewportPoint(Vector3 position)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_ScreenToViewportPoint(Camera self, ref Vector3 position);

		public Ray ScreenPointToRay(Vector3 position)
		{
			return (Ray)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Ray INTERNAL_CALL_ScreenPointToRay(Camera self, ref Vector3 position);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Render();
	}
}
