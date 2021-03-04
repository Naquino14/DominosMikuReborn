using System.Collections;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Transform : Component, IEnumerable
	{
		private sealed class Enumerator : IEnumerator
		{
			private Transform outer;

			private int currentIndex;

			public object Current => (object)/*Error near IL_0001: Stack underflow*/;

			internal Enumerator(Transform outer)
			{
			}

			public bool MoveNext()
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public void Reset()
			{
			}
		}

		public Vector3 position
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector3 localPosition
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector3 eulerAngles
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector3 localEulerAngles
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector3 right
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector3 up
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector3 forward
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Quaternion rotation
		{
			get
			{
				return (Quaternion)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Quaternion localRotation
		{
			get
			{
				return (Quaternion)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector3 localScale
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Transform parent
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Matrix4x4 worldToLocalMatrix => (Matrix4x4)/*Error near IL_0001: Stack underflow*/;

		public Matrix4x4 localToWorldMatrix => (Matrix4x4)/*Error near IL_0001: Stack underflow*/;

		public Transform root
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public int childCount
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Vector3 lossyScale => (Vector3)/*Error near IL_0001: Stack underflow*/;

		public bool hasChanged
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		private Transform()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_position(out Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_position(ref Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_localPosition(out Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_localPosition(ref Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_localEulerAngles(out Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_localEulerAngles(ref Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_rotation(out Quaternion value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_rotation(ref Quaternion value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_localRotation(out Quaternion value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_localRotation(ref Quaternion value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_localScale(out Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_localScale(ref Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_worldToLocalMatrix(out Matrix4x4 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_localToWorldMatrix(out Matrix4x4 value);

		public void Translate(Vector3 translation)
		{
		}

		public void Translate(Vector3 translation, Space relativeTo)
		{
		}

		public void Translate(float x, float y, float z)
		{
		}

		public void Translate(float x, float y, float z, Space relativeTo)
		{
		}

		public void Translate(Vector3 translation, Transform relativeTo)
		{
		}

		public void Translate(float x, float y, float z, Transform relativeTo)
		{
		}

		public void Rotate(Vector3 eulerAngles)
		{
		}

		public void Rotate(Vector3 eulerAngles, Space relativeTo)
		{
		}

		public void Rotate(float xAngle, float yAngle, float zAngle)
		{
		}

		public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo)
		{
		}

		public void Rotate(Vector3 axis, float angle)
		{
		}

		public void Rotate(Vector3 axis, float angle, Space relativeTo)
		{
		}

		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		public void LookAt(Transform target)
		{
		}

		public void LookAt(Transform target, Vector3 worldUp)
		{
		}

		public void LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
		}

		public void LookAt(Vector3 worldPosition)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_LookAt(Transform self, ref Vector3 worldPosition, ref Vector3 worldUp);

		public Vector3 TransformDirection(Vector3 direction)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_TransformDirection(Transform self, ref Vector3 direction);

		public Vector3 TransformDirection(float x, float y, float z)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_InverseTransformDirection(Transform self, ref Vector3 direction);

		public Vector3 InverseTransformDirection(float x, float y, float z)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		public Vector3 TransformPoint(Vector3 position)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_TransformPoint(Transform self, ref Vector3 position);

		public Vector3 TransformPoint(float x, float y, float z)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		public Vector3 InverseTransformPoint(Vector3 position)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_InverseTransformPoint(Transform self, ref Vector3 position);

		public Vector3 InverseTransformPoint(float x, float y, float z)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void DetachChildren();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern Transform Find(string name);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_lossyScale(out Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern bool IsChildOf(Transform parent);

		public Transform FindChild(string name)
		{
			return (Transform)/*Error near IL_0001: Stack underflow*/;
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		public void RotateAround(Vector3 axis, float angle)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_RotateAround(Transform self, ref Vector3 axis, float angle);

		public void RotateAroundLocal(Vector3 axis, float angle)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_RotateAroundLocal(Transform self, ref Vector3 axis, float angle);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern Transform GetChild(int index);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern int GetChildCount();
	}
}
