namespace UnityEngine
{
	public struct Plane
	{
		private Vector3 m_Normal;

		private float m_Distance;

		public Vector3 normal => (Vector3)/*Error near IL_0001: Stack underflow*/;

		public float distance => (float)/*Error near IL_0001: Stack underflow*/;

		public Plane(Vector3 inNormal, Vector3 inPoint)
		{
		}

		public bool Raycast(Ray ray, out float enter)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
