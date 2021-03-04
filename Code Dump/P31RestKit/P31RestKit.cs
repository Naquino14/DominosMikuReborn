using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Prime31
{
	// Token: 0x0200000B RID: 11
	public class P31RestKit
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002118 File Offset: 0x00000318
		// (set) Token: 0x06000034 RID: 52 RVA: 0x0000211C File Offset: 0x0000031C
		protected virtual GameObject surrogateGameObject
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002120 File Offset: 0x00000320
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002124 File Offset: 0x00000324
		protected MonoBehaviour surrogateMonobehaviour
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002128 File Offset: 0x00000328
		[DebuggerHidden]
		protected virtual IEnumerator send(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters, Action<string, object> onComplete)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000212C File Offset: 0x0000032C
		protected virtual WWW processRequest(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002130 File Offset: 0x00000330
		protected virtual void processResponse(WWW www, Action<string, object> onComplete)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002134 File Offset: 0x00000334
		protected bool isResponseJson(WWW www)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002138 File Offset: 0x00000338
		public void get(string path, Action<string, object> completionHandler)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000213C File Offset: 0x0000033C
		public void get(string path, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002140 File Offset: 0x00000340
		public void post(string path, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}

		// Token: 0x04000020 RID: 32
		protected string _baseUrl;

		// Token: 0x04000021 RID: 33
		public bool debugRequests;

		// Token: 0x04000022 RID: 34
		protected bool forceJsonResponse;

		// Token: 0x04000023 RID: 35
		private GameObject _surrogateGameObject;

		// Token: 0x04000024 RID: 36
		private MonoBehaviour _surrogateMonobehaviour;
	}
}
