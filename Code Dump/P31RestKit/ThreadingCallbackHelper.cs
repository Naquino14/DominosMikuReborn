using System;
using System.Collections.Generic;
using UnityEngine;

namespace Prime31
{
	// Token: 0x0200000E RID: 14
	public class ThreadingCallbackHelper : MonoBehaviour
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002164 File Offset: 0x00000364
		public void addActionToQueue(Action action)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002168 File Offset: 0x00000368
		private void Update()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000216C File Offset: 0x0000036C
		public void disableIfEmpty()
		{
		}

		// Token: 0x04000034 RID: 52
		private Queue<Action> _actionQueue;
	}
}
