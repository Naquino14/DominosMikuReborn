using System.Runtime.InteropServices;

namespace UnityEngine
{
	[StructLayout(0)]
	public sealed class ControllerColliderHit
	{
		private CharacterController m_Controller;

		private Collider m_Collider;

		private Vector3 m_Point;

		private Vector3 m_Normal;

		private Vector3 m_MoveDirection;

		private float m_MoveLength;

		private int m_Push;
	}
}
