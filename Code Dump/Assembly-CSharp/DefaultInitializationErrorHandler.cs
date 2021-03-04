using System;
using UnityEngine;

// Token: 0x0200008C RID: 140
public class DefaultInitializationErrorHandler : MonoBehaviour
{
	// Token: 0x060003E7 RID: 999 RVA: 0x00002F90 File Offset: 0x00001190
	private void Start()
	{
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00002F94 File Offset: 0x00001194
	private void OnGUI()
	{
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00002F98 File Offset: 0x00001198
	private void DrawWindowContent(int id)
	{
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00002F9C File Offset: 0x0000119C
	private void SetErrorCode(QCARUnity.InitError errorCode)
	{
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00002FA0 File Offset: 0x000011A0
	private void SetErrorOccurred(bool errorOccurred)
	{
	}

	// Token: 0x04000396 RID: 918
	private const string WINDOW_TITLE = "QCAR Initialization Error";

	// Token: 0x04000397 RID: 919
	private string mErrorText;

	// Token: 0x04000398 RID: 920
	private bool mErrorOccurred;
}
