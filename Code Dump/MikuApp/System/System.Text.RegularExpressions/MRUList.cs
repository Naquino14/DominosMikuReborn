namespace System.Text.RegularExpressions
{
	internal class MRUList
	{
		private class Node
		{
			public object value;

			public Node previous;

			public Node next;

			public Node(object value)
			{
			}
		}

		private Node head;

		private Node tail;

		public void Use(object o)
		{
		}

		public object Evict()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
