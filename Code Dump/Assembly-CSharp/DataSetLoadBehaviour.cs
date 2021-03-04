using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200008A RID: 138
public class DataSetLoadBehaviour : MonoBehaviour
{
	// Token: 0x060003E1 RID: 993 RVA: 0x00002F78 File Offset: 0x00001178
	private void Awake()
	{
	}

	// Token: 0x04000393 RID: 915
	[SerializeField]
	[HideInInspector]
	public List<string> mDataSetsToActivate;

	// Token: 0x04000394 RID: 916
	[SerializeField]
	[HideInInspector]
	public List<string> mDataSetsToLoad;
}
