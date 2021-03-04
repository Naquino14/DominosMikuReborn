using System;
using System.Collections.Generic;

namespace UnityEngine
{
	[Serializable]
	[ExecuteInEditMode]
	public sealed class GUISkin : ScriptableObject
	{
		internal delegate void SkinChangedDelegate();

		[SerializeField]
		private Font m_Font;

		[SerializeField]
		private GUIStyle m_box;

		[SerializeField]
		private GUIStyle m_button;

		[SerializeField]
		private GUIStyle m_toggle;

		[SerializeField]
		private GUIStyle m_label;

		[SerializeField]
		private GUIStyle m_textField;

		[SerializeField]
		private GUIStyle m_textArea;

		[SerializeField]
		private GUIStyle m_window;

		[SerializeField]
		private GUIStyle m_horizontalSlider;

		[SerializeField]
		private GUIStyle m_horizontalSliderThumb;

		[SerializeField]
		private GUIStyle m_verticalSlider;

		[SerializeField]
		private GUIStyle m_verticalSliderThumb;

		[SerializeField]
		private GUIStyle m_horizontalScrollbar;

		[SerializeField]
		private GUIStyle m_horizontalScrollbarThumb;

		[SerializeField]
		private GUIStyle m_horizontalScrollbarLeftButton;

		[SerializeField]
		private GUIStyle m_horizontalScrollbarRightButton;

		[SerializeField]
		private GUIStyle m_verticalScrollbar;

		[SerializeField]
		private GUIStyle m_verticalScrollbarThumb;

		[SerializeField]
		private GUIStyle m_verticalScrollbarUpButton;

		[SerializeField]
		private GUIStyle m_verticalScrollbarDownButton;

		[SerializeField]
		private GUIStyle m_ScrollView;

		[SerializeField]
		internal GUIStyle[] m_CustomStyles;

		[SerializeField]
		private GUISettings m_Settings;

		internal static GUIStyle ms_Error;

		private Dictionary<string, GUIStyle> styles;

		internal static SkinChangedDelegate m_SkinChanged;

		internal static GUISkin current;

		public Font font => (Font)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle box => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle label => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle textField => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle textArea => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle button => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle toggle => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle window => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle horizontalSlider => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle horizontalSliderThumb => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle verticalSlider => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle verticalSliderThumb => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle horizontalScrollbar => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle horizontalScrollbarThumb => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle horizontalScrollbarLeftButton => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle horizontalScrollbarRightButton => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle verticalScrollbar => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle verticalScrollbarThumb => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle verticalScrollbarUpButton => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle verticalScrollbarDownButton => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUIStyle scrollView => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		public GUISettings settings => (GUISettings)/*Error near IL_0001: Stack underflow*/;

		internal static GUIStyle error => (GUIStyle)/*Error near IL_0001: Stack underflow*/;

		private void BuildStyleCache()
		{
		}

		public GUIStyle GetStyle(string styleName)
		{
			return (GUIStyle)/*Error near IL_0001: Stack underflow*/;
		}

		public GUIStyle FindStyle(string styleName)
		{
			return (GUIStyle)/*Error near IL_0001: Stack underflow*/;
		}

		internal void MakeCurrent()
		{
		}
	}
}
