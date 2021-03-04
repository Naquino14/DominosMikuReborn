using System;
using UnityEngine;

namespace Prime31
{
	// Token: 0x02000002 RID: 2
	public abstract class AbstractManager : MonoBehaviour
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
		public static ThreadingCallbackHelper getThreadingCallbackHelper()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000258
		public static void createThreadingCallbackHelper()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000205C File Offset: 0x0000025C
		public static GameObject getPrime31ManagerGameObject()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002060 File Offset: 0x00000260
		public static void initialize(Type type)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002064 File Offset: 0x00000264
		private void Awake()
		{
		}

		// Token: 0x04000001 RID: 1
		private static ThreadingCallbackHelper _threadingCallbackHelper;

		// Token: 0x04000002 RID: 2
		private static GameObject _prime31GameObject;
	}
}
