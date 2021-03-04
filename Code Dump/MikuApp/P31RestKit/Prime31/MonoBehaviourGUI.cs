using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Prime31
{
	public class MonoBehaviourGUI : MonoBehaviour
	{
		protected float _width;

		protected float _buttonHeight;

		protected Dictionary<string, bool> _toggleButtons;

		protected StringBuilder _logBuilder;

		private bool _logRegistered;

		private Vector2 _logScrollPosition;

		private bool _isShowingLogConsole;

		private float _doubleClickDelay;

		private float _previousClickTime;

		private bool isRetinaOrLargeScreen()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private void paintWindow(int id)
		{
		}

		private void handleLog(string logString, string stackTrace, LogType type)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		protected void beginColumn()
		{
		}

		protected void endColumn()
		{
		}

		protected void endColumn(bool hasSecondColumn)
		{
		}

		private void beginRightColumn()
		{
		}

		protected bool bottomRightButton(string text, float width = 150f)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		protected bool bottomLeftButton(string text, float width = 150f)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		protected bool bottomCenterButton(string text, float width = 150f)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		protected bool toggleButton(string defaultText, string selectedText)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		protected bool toggleButtonState(string defaultText)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
