using System;

namespace Prime31
{
	public static class ActionExtensions
	{
		private static void invoke(Delegate listener, object[] args)
		{
		}

		public static void fire(this Action handler)
		{
		}

		public static void fire<T>(this Action<T> handler, T param)
		{
		}
	}
}
