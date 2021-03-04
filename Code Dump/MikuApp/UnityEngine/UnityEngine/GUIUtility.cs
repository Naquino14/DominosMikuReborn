using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public class GUIUtility
	{
		[NotRenamed]
		private static int s_SkinMode;

		[NotRenamed]
		internal static int s_OriginalID;

		internal static Vector2 s_EditorScreenPointOffset;

		internal static bool s_HasKeyboardFocus;

		public static int hotControl
		{
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public static int keyboardControl
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		internal static string systemCopyBuffer
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		internal static bool mouseUsed
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static bool hasModalWindow
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		internal static bool textFieldInput
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static int GetControlID(FocusType focus)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern int GetControlID(int hint, FocusType focus);

		public static int GetControlID(GUIContent contents, FocusType focus)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int GetControlID(FocusType focus, Rect position)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int GetControlID(int hint, FocusType focus, Rect position)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int GetControlID(GUIContent contents, FocusType focus, Rect position)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int Internal_GetNextControlID2(int hint, FocusType focusType, Rect rect)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int INTERNAL_CALL_Internal_GetNextControlID2(int hint, FocusType focusType, ref Rect rect);

		public static object GetStateObject(Type t, int controlID)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public static object QueryStateObject(Type t, int controlID)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern int GetPermanentControlID();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int Internal_GetHotControl();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_SetHotControl(int value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern void UpdateUndoName();

		public static void ExitGUI()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern void SetDidGUIWindowsEatLastEvent(bool value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Object Internal_LoadSkin(int skinNo, Type type);

		internal static GUISkin GetDefaultSkin()
		{
			return (GUISkin)/*Error near IL_0001: Stack underflow*/;
		}

		internal static GUISkin GetBuiltinSkin(int skin)
		{
			return (GUISkin)/*Error near IL_0001: Stack underflow*/;
		}

		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_ExitGUI();

		internal static void EndGUI(int layoutType)
		{
		}

		internal static bool EndGUIFromException(Exception exception)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		internal static void CheckOnGUI()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern int Internal_GetGUIDepth();

		public static Vector2 GUIToScreenPoint(Vector2 guiPoint)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		internal static Rect GUIToScreenRect(Rect guiRect)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		public static Vector2 ScreenToGUIPoint(Vector2 screenPoint)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		public static void RotateAroundPivot(float angle, Vector2 pivotPoint)
		{
		}

		public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint)
		{
		}
	}
}
