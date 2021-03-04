using System.Collections.Generic;

namespace UnityEngine
{
	internal class GUILayoutGroup : GUILayoutEntry
	{
		public List<GUILayoutEntry> entries;

		public bool isVertical;

		public bool resetCoords;

		public float spacing;

		public bool sameSize;

		public bool isWindow;

		public int windowID;

		private int cursor;

		protected int stretchableCountX;

		protected int stretchableCountY;

		protected bool userSpecifiedWidth;

		protected bool userSpecifiedHeight;

		protected float childMinWidth;

		protected float childMaxWidth;

		protected float childMinHeight;

		protected float childMaxHeight;

		private RectOffset m_Margin;

		public override RectOffset margin => (RectOffset)/*Error near IL_0001: Stack underflow*/;

		public override void ApplyOptions(GUILayoutOption[] options)
		{
		}

		protected override void ApplyStyleSettings(GUIStyle style)
		{
		}

		public void ResetCursor()
		{
		}

		public GUILayoutEntry GetNext()
		{
			return (GUILayoutEntry)/*Error near IL_0001: Stack underflow*/;
		}

		public void Add(GUILayoutEntry e)
		{
		}

		public override void CalcWidth()
		{
		}

		public override void SetHorizontal(float x, float width)
		{
		}

		public override void CalcHeight()
		{
		}

		public override void SetVertical(float y, float height)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
