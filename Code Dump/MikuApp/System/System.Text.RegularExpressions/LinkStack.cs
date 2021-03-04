using System.Collections;

namespace System.Text.RegularExpressions
{
	internal abstract class LinkStack : LinkRef
	{
		private Stack stack;

		public LinkStack()
		{
		}

		public void Push()
		{
		}

		public bool Pop()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		protected abstract object GetCurrent();

		protected abstract void SetCurrent(object l);
	}
}
