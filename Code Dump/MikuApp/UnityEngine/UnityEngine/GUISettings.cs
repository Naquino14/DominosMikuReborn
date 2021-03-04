using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	[Serializable]
	public sealed class GUISettings
	{
		[SerializeField]
		private bool m_DoubleClickSelectsWord;

		[SerializeField]
		private bool m_TripleClickSelectsLine;

		[SerializeField]
		private Color m_CursorColor;

		[SerializeField]
		private float m_CursorFlashSpeed;

		[SerializeField]
		private Color m_SelectionColor;

		public Color cursorColor => (Color)/*Error near IL_0001: Stack underflow*/;

		public float cursorFlashSpeed => (float)/*Error near IL_0001: Stack underflow*/;

		public Color selectionColor => (Color)/*Error near IL_0001: Stack underflow*/;

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern float Internal_GetCursorFlashSpeed();
	}
}
