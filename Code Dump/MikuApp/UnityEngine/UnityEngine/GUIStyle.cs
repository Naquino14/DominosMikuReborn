using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[Serializable]
	[StructLayout(0)]
	public sealed class GUIStyle
	{
		[NonSerialized]
		[NotRenamed]
		internal IntPtr m_Ptr;

		[NonSerialized]
		private GUIStyleState m_Normal;

		[NonSerialized]
		private GUIStyleState m_Hover;

		[NonSerialized]
		private GUIStyleState m_Active;

		[NonSerialized]
		private GUIStyleState m_Focused;

		[NonSerialized]
		private GUIStyleState m_OnNormal;

		[NonSerialized]
		private GUIStyleState m_OnHover;

		[NonSerialized]
		private GUIStyleState m_OnActive;

		[NonSerialized]
		private GUIStyleState m_OnFocused;

		[NonSerialized]
		private RectOffset m_Border;

		[NonSerialized]
		private RectOffset m_Padding;

		[NonSerialized]
		private RectOffset m_Margin;

		[NonSerialized]
		private RectOffset m_Overflow;

		internal static bool showKeyboardFocus;

		private static GUIStyle s_None;

		public string name
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public GUIStyleState normal => (GUIStyleState)/*Error near IL_0001: Stack underflow*/;

		public RectOffset margin
		{
			get
			{
				return (RectOffset)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public RectOffset padding => (RectOffset)/*Error near IL_0001: Stack underflow*/;

		public ImagePosition imagePosition
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public TextAnchor alignment
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool wordWrap
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Vector2 contentOffset
		{
			get
			{
				return (Vector2)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		internal Vector2 Internal_clipOffset
		{
			set
			{
			}
		}

		public float fixedWidth
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public float fixedHeight
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool stretchWidth
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool stretchHeight
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public FontStyle fontStyle
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float lineHeight => (float)/*Error near IL_0001: Stack underflow*/;

		public static GUIStyle none => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public bool isHeightDependantOnWidth => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		~GUIStyle()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Init();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Cleanup();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern IntPtr GetStyleStatePtr(int idx);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern IntPtr GetRectOffsetPtr(int idx);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void AssignRectOffset(int idx, IntPtr srcRectOffset);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_contentOffset(out Vector2 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_contentOffset(ref Vector2 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_Internal_clipOffset(ref Vector2 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern float Internal_GetLineHeight(IntPtr target);

		private static void Internal_Draw(IntPtr target, Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_Draw(GUIContent content, ref Internal_DrawArguments arguments);

		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		public void Draw(Rect position, GUIContent content, int controlID)
		{
		}

		public void Draw(Rect position, GUIContent content, int controlID, bool on)
		{
		}

		private static void Internal_Draw2(IntPtr style, Rect position, GUIContent content, int controlID, bool on)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Internal_Draw2(IntPtr style, ref Rect position, GUIContent content, int controlID, bool on);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern float Internal_GetCursorFlashOffset();

		private static void Internal_DrawCursor(IntPtr target, Rect position, GUIContent content, int pos, Color cursorColor)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Internal_DrawCursor(IntPtr target, ref Rect position, GUIContent content, int pos, ref Color cursorColor);

		public void DrawCursor(Rect position, GUIContent content, int controlID, int Character)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_DrawWithTextSelection(GUIContent content, ref Internal_DrawWithTextSelectionArguments arguments);

		internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
		{
		}

		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern void SetDefaultFont(Font font);

		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		internal static void Internal_GetCursorPixelPosition(IntPtr target, Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Internal_GetCursorPixelPosition(IntPtr target, ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret);

		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal static int Internal_GetCursorStringIndex(IntPtr target, Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int INTERNAL_CALL_Internal_GetCursorStringIndex(IntPtr target, ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition);

		public Vector2 CalcSize(GUIContent content)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern void Internal_CalcSize(IntPtr target, GUIContent content, out Vector2 ret);

		public float CalcHeight(GUIContent content, float width)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern float Internal_CalcHeight(IntPtr target, GUIContent content, float width);

		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_CalcMinMaxWidth(IntPtr target, GUIContent content, out float minWidth, out float maxWidth);

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static implicit operator GUIStyle(string str)
		{
			return (GUIStyle)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
