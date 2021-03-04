using System;

namespace Prime31
{
	// Token: 0x02000003 RID: 3
	public static class ActionExtensions
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		private static void invoke(Delegate listener, object[] args)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000206C File Offset: 0x0000026C
		public static void fire(this Action handler)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002070 File Offset: 0x00000270
		public static void fire<T>(this Action<T> handler, T param)
		{
		}
	}
}
