using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngineInternal;

namespace UnityEngine
{
	public class GUILayoutUtility
	{
		internal sealed class LayoutCache
		{
			internal GUILayoutGroup topLevel;

			internal GenericStack layoutGroups;

			internal GUILayoutGroup windows;

			internal LayoutCache()
			{
			}
		}

		private static Dictionary<int, LayoutCache> storedLayouts;

		private static Dictionary<int, LayoutCache> storedWindows;

		internal static LayoutCache current;

		private static Rect kDummyRect;

		private static GUIStyle s_SpaceStyle;

		internal static GUIStyle spaceStyle => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		internal static LayoutCache SelectIDList(int instanceID, bool isWindow)
		{
			return (LayoutCache)/*Error near IL_0001: Stack underflow*/;
		}

		internal static void Begin(int instanceID)
		{
		}

		internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options)
		{
		}

		public static void EndGroup(string groupName)
		{
		}

		internal static void Layout()
		{
		}

		internal static void LayoutFromEditorWindow()
		{
		}

		internal static void LayoutFreeGroup(GUILayoutGroup toplevel)
		{
		}

		private static void LayoutSingleGroup(GUILayoutGroup i)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Rect Internal_GetWindowRect(int windowID);

		private static void Internal_MoveWindow(int windowID, Rect r)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Internal_MoveWindow(int windowID, ref Rect r);

		[SecuritySafeCritical]
		private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
		{
			return (GUILayoutGroup)/*Error near IL_0001: Stack underflow*/;
		}

		internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type LayoutType)
		{
			return (GUILayoutGroup)/*Error near IL_0001: Stack underflow*/;
		}

		internal static void EndLayoutGroup()
		{
		}

		internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type LayoutType)
		{
			return (GUILayoutGroup)/*Error near IL_0001: Stack underflow*/;
		}

		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
