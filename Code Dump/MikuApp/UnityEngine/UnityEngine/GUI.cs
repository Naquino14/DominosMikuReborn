using System;
using System.Runtime.CompilerServices;
using UnityEngineInternal;

namespace UnityEngine
{
	public class GUI
	{
		internal sealed class ScrollViewState
		{
			public Rect position;

			public Rect visibleRect;

			public Rect viewRect;

			public Vector2 scrollPosition;

			public bool apply;

			public bool hasScrollTo;

			public Rect scrollTo;

			internal void ScrollTo(Rect position)
			{
			}
		}

		public delegate void WindowFunction(int id);

		private static float scrollStepSize;

		private static int scrollControlID;

		private static int hotTextField;

		private static GUISkin s_Skin;

		internal static Rect s_ToolTipRect;

		private static int boxHash;

		private static int repeatButtonHash;

		private static int toggleHash;

		private static int buttonGridHash;

		private static int sliderHash;

		private static int beginGroupHash;

		private static int scrollviewHash;

		private static GenericStack s_ScrollViewStates;

		internal static DateTime nextScrollStepTime
		{
			[CompilerGenerated]
			get
			{
				return (DateTime)/*Error near IL_0001: Stack underflow*/;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static int scrollTroughSide
		{
			[CompilerGenerated]
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static GUISkin skin
		{
			get
			{
				return (GUISkin)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public static Color color
		{
			get
			{
				return (Color)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public static Color backgroundColor
		{
			get
			{
				return (Color)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public static Color contentColor
		{
			get
			{
				return (Color)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public static bool changed
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static bool enabled
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static Matrix4x4 matrix
		{
			get
			{
				return (Matrix4x4)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public static string tooltip
		{
			get
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		protected static string mouseTooltip => (string)/*Error near IL_0001: Stack underflow*/;

		protected static Rect tooltipRect
		{
			get
			{
				return (Rect)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public static int depth
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		private static Material blendMaterial
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		private static Material blitMaterial
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		internal static bool usePageScrollbars
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		static GUI()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_get_color(out Color value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_set_color(ref Color value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_get_backgroundColor(out Color value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_set_backgroundColor(ref Color value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_get_contentColor(out Color value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_set_contentColor(ref Color value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern string Internal_GetTooltip();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_SetTooltip(string value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern string Internal_GetMouseTooltip();

		public static void Label(Rect position, string text)
		{
		}

		public static void Label(Rect position, Texture image)
		{
		}

		public static void Label(Rect position, GUIContent content)
		{
		}

		public static void Label(Rect position, string text, GUIStyle style)
		{
		}

		public static void Label(Rect position, Texture image, GUIStyle style)
		{
		}

		public static void Label(Rect position, GUIContent content, GUIStyle style)
		{
		}

		private static void DoLabel(Rect position, GUIContent content, IntPtr style)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_DoLabel(ref Rect position, GUIContent content, IntPtr style);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void InitializeGUIClipTexture();

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend)
		{
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode)
		{
		}

		public static void DrawTexture(Rect position, Texture image)
		{
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect)
		{
		}

		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords)
		{
		}

		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend)
		{
		}

		public static void Box(Rect position, string text)
		{
		}

		public static void Box(Rect position, Texture image)
		{
		}

		public static void Box(Rect position, GUIContent content)
		{
		}

		public static void Box(Rect position, string text, GUIStyle style)
		{
		}

		public static void Box(Rect position, Texture image, GUIStyle style)
		{
		}

		public static void Box(Rect position, GUIContent content, GUIStyle style)
		{
		}

		public static bool Button(Rect position, string text)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Button(Rect position, Texture image)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Button(Rect position, GUIContent content)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Button(Rect position, string text, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Button(Rect position, Texture image, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool DoButton(Rect position, GUIContent content, IntPtr style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool INTERNAL_CALL_DoButton(ref Rect position, GUIContent content, IntPtr style);

		public static bool RepeatButton(Rect position, string text)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool RepeatButton(Rect position, Texture image)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool RepeatButton(Rect position, GUIContent content)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool RepeatButton(Rect position, string text, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool RepeatButton(Rect position, Texture image, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool RepeatButton(Rect position, GUIContent content, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static string TextField(Rect position, string text)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string TextField(Rect position, string text, int maxLength)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string TextField(Rect position, string text, GUIStyle style)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string TextField(Rect position, string text, int maxLength, GUIStyle style)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string PasswordField(Rect position, string password, char maskChar)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string PasswordField(Rect position, string password, char maskChar, int maxLength)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string PasswordField(Rect position, string password, char maskChar, GUIStyle style)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static string PasswordFieldGetStrToShow(string password, char maskChar)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string TextArea(Rect position, string text)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string TextArea(Rect position, string text, int maxLength)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string TextArea(Rect position, string text, GUIStyle style)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string TextArea(Rect position, string text, int maxLength, GUIStyle style)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static string TextArea(Rect position, GUIContent content, int maxLength, GUIStyle style)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText = null)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void SetNextControlName(string name);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern string GetNameOfFocusedControl();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void FocusControl(string name);

		public static bool Toggle(Rect position, bool value, string text)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Toggle(Rect position, bool value, Texture image)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Toggle(Rect position, bool value, GUIContent content)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Toggle(Rect position, bool value, string text, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Toggle(Rect position, bool value, Texture image, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, IntPtr style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool INTERNAL_CALL_DoToggle(ref Rect position, int id, bool value, GUIContent content, IntPtr style);

		public static int Toolbar(Rect position, int selected, string[] texts)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int Toolbar(Rect position, int selected, Texture[] images)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int Toolbar(Rect position, int selected, GUIContent[] content)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int Toolbar(Rect position, int selected, string[] texts, GUIStyle style)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int Toolbar(Rect position, int selected, Texture[] images, GUIStyle style)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int SelectionGrid(Rect position, int selected, GUIContent[] content, int xCount)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount, GUIStyle style)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount, GUIStyle style)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal static void FindStyles(ref GUIStyle style, out GUIStyle firstStyle, out GUIStyle midStyle, out GUIStyle lastStyle, string first, string mid, string last)
		{
		}

		internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static Rect[] CalcMouseRects(Rect position, int count, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders)
		{
			return (Rect[])/*Error near IL_0001: Stack underflow*/;
		}

		private static int GetButtonGridMouseSelection(Rect[] buttonRects, Vector2 mousePos, bool findNearest)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern void InternalRepaintEditorWindow();

		internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		private static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static void BeginGroup(Rect position)
		{
		}

		public static void BeginGroup(Rect position, string text)
		{
		}

		public static void BeginGroup(Rect position, Texture image)
		{
		}

		public static void BeginGroup(Rect position, GUIContent content)
		{
		}

		public static void BeginGroup(Rect position, GUIStyle style)
		{
		}

		public static void BeginGroup(Rect position, string text, GUIStyle style)
		{
		}

		public static void BeginGroup(Rect position, Texture image, GUIStyle style)
		{
		}

		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
		}

		public static void EndGroup()
		{
		}

		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		protected static Vector2 DoBeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		public static void EndScrollView()
		{
		}

		public static void EndScrollView(bool handleScrollWheel)
		{
		}

		internal static ScrollViewState GetTopScrollView()
		{
			return (ScrollViewState)/*Error near IL_0001: Stack underflow*/;
		}

		public static void ScrollTo(Rect position)
		{
		}

		public static Rect Window(int id, Rect clientRect, WindowFunction func, string text)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect Window(int id, Rect clientRect, WindowFunction func, Texture image)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent content)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect Window(int id, Rect clientRect, WindowFunction func, Texture image, GUIStyle style)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, string text)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, Texture image)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, GUIContent content)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, Texture image, GUIStyle style)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, GUIContent content, GUIStyle style)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		private static Rect DoModalWindow(int id, Rect clientRect, WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Rect INTERNAL_CALL_DoModalWindow(int id, ref Rect clientRect, WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin);

		internal static void CallWindowDelegate(WindowFunction func, int id, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
		{
		}

		private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Rect INTERNAL_CALL_DoWindow(int id, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout);

		public static void DragWindow(Rect position)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_DragWindow(ref Rect position);

		public static void DragWindow()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void BringWindowToFront(int windowID);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void BringWindowToBack(int windowID);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void FocusWindow(int windowID);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void UnfocusWindow();

		internal static void BeginWindows(int skinMode, int editorWindowInstanceID)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_BeginWindows();

		internal static void EndWindows()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_EndWindows();
	}
}
