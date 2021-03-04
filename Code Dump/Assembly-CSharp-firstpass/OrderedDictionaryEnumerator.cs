using System;
using System.Collections;
using System.Collections.Generic;

namespace LitJson
{
	// Token: 0x0200000F RID: 15
	internal class OrderedDictionaryEnumerator : IEnumerator, IDictionaryEnumerator
	{
		// Token: 0x0600012D RID: 301 RVA: 0x0000241C File Offset: 0x0000061C
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002420 File Offset: 0x00000620
		public object Current
		{
			get
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00002424 File Offset: 0x00000624
		public DictionaryEntry Entry
		{
			get
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002428 File Offset: 0x00000628
		public object Key
		{
			get
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000242C File Offset: 0x0000062C
		public object Value
		{
			get
			{
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002430 File Offset: 0x00000630
		public bool MoveNext()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002434 File Offset: 0x00000634
		public void Reset()
		{
		}

		// Token: 0x0400003E RID: 62
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;
	}
}
