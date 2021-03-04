using System;
using System.Collections.Generic;

namespace LitJson
{
	// Token: 0x02000013 RID: 19
	internal struct ObjectMetadata
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000246C File Offset: 0x0000066C
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002470 File Offset: 0x00000670
		public Type ElementType
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00002474 File Offset: 0x00000674
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002478 File Offset: 0x00000678
		public bool IsDictionary
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000247C File Offset: 0x0000067C
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002480 File Offset: 0x00000680
		public IDictionary<string, PropertyMetadata> Properties
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x04000045 RID: 69
		private Type element_type;

		// Token: 0x04000046 RID: 70
		private bool is_dictionary;

		// Token: 0x04000047 RID: 71
		private IDictionary<string, PropertyMetadata> properties;
	}
}
