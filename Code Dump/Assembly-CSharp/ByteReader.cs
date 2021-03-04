using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000041 RID: 65
public class ByteReader
{
	// Token: 0x06000184 RID: 388 RVA: 0x0000265C File Offset: 0x0000085C
	public ByteReader(byte[] bytes)
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002660 File Offset: 0x00000860
	public ByteReader(TextAsset asset)
	{
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000186 RID: 390 RVA: 0x00002664 File Offset: 0x00000864
	public bool canRead
	{
		get
		{
		}
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002668 File Offset: 0x00000868
	private static string ReadLine(byte[] buffer, int start, int count)
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0000266C File Offset: 0x0000086C
	public string ReadLine()
	{
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002670 File Offset: 0x00000870
	public Dictionary<string, string> ReadDictionary()
	{
	}

	// Token: 0x0400019A RID: 410
	private byte[] mBuffer;

	// Token: 0x0400019B RID: 411
	private int mOffset;
}
