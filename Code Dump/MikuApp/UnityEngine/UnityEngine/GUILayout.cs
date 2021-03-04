namespace UnityEngine
{
	public sealed class GUILayout
	{
		private sealed class LayoutedWindow
		{
			private GUI.WindowFunction func;

			private Rect screenRect;

			private GUILayoutOption[] options;

			private GUIStyle style;

			internal LayoutedWindow(GUI.WindowFunction f, Rect _screenRect, GUIContent _content, GUILayoutOption[] _options, GUIStyle _style)
			{
			}

			public void DoWindow(int windowID)
			{
			}
		}

		public static void Label(string text, params GUILayoutOption[] options)
		{
		}

		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
		}

		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static void BeginVertical(params GUILayoutOption[] options)
		{
		}

		public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		public static void EndVertical()
		{
		}

		public static void BeginArea(Rect screenRect)
		{
		}

		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
		}

		public static void EndArea()
		{
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		public static void EndScrollView()
		{
		}

		internal static void EndScrollView(bool handleScrollWheel)
		{
		}

		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static GUILayoutOption Width(float width)
		{
			return (GUILayoutOption)/*Error near IL_0001: Stack underflow*/;
		}

		public static GUILayoutOption Height(float height)
		{
			return (GUILayoutOption)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
