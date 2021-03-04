namespace UnityEngine
{
	internal class SendMouseEvents
	{
		private struct HitInfo
		{
			public GameObject target;

			public Camera camera;

			public void SendMessage(string name)
			{
			}

			public static bool Compare(HitInfo lhs, HitInfo rhs)
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public static implicit operator bool(HitInfo exists)
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
		}

		private static HitInfo[] m_LastHit;

		private static HitInfo[] m_MouseDownHit;

		[NotRenamed]
		private static void DoSendMouseEvents(int mouseUsed, int skipRTCameras)
		{
		}

		private static void SendEvents(int i, HitInfo hit)
		{
		}
	}
}
