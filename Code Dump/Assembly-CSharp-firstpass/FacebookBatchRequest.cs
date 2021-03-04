using System;
using System.Collections.Generic;

// Token: 0x02000021 RID: 33
public class FacebookBatchRequest
{
	// Token: 0x06000220 RID: 544 RVA: 0x00002798 File Offset: 0x00000998
	public FacebookBatchRequest(string relativeUrl, string method)
	{
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000279C File Offset: 0x0000099C
	public void addParameter(string key, string value)
	{
	}

	// Token: 0x06000222 RID: 546 RVA: 0x000027A0 File Offset: 0x000009A0
	public Dictionary<string, object> requestDictionary()
	{
	}

	// Token: 0x040000D5 RID: 213
	public Dictionary<string, string> _parameters;

	// Token: 0x040000D6 RID: 214
	private Dictionary<string, object> _requestDict;
}
