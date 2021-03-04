namespace UnityEngine
{
	internal class GUILayoutEntry
	{
		public float minWidth;

		public float maxWidth;

		public float minHeight;

		public float maxHeight;

		public Rect rect;

		public int stretchWidth;

		public int stretchHeight;

		private GUIStyle m_Style;

		internal static Rect kDummyRect;

		protected static int indent;

		public GUIStyle style
		{
			get
			{
				return (GUIStyle)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public virtual RectOffset margin => (RectOffset)/*Error near IL_0001: Stack underflow*/;

		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
		{
		}

		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options)
		{
		}

		public virtual void CalcWidth()
		{
		}

		public virtual void CalcHeight()
		{
		}

		public virtual void SetHorizontal(float x, float width)
		{
		}

		public virtual void SetVertical(float y, float height)
		{
		}

		protected virtual void ApplyStyleSettings(GUIStyle style)
		{
		}

		public virtual void ApplyOptions(GUILayoutOption[] options)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
