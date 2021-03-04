using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Prime31
{
	// Token: 0x0200000A RID: 10
	public class MonoBehaviourGUI : MonoBehaviour
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000020DC File Offset: 0x000002DC
		private bool isRetinaOrLargeScreen()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020E0 File Offset: 0x000002E0
		private void paintWindow(int id)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020E4 File Offset: 0x000002E4
		private void handleLog(string logString, string stackTrace, LogType type)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020E8 File Offset: 0x000002E8
		private void OnDestroy()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020EC File Offset: 0x000002EC
		private void Update()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020F0 File Offset: 0x000002F0
		protected void beginColumn()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020F4 File Offset: 0x000002F4
		protected void endColumn()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020F8 File Offset: 0x000002F8
		protected void endColumn(bool hasSecondColumn)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020FC File Offset: 0x000002FC
		private void beginRightColumn()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002100 File Offset: 0x00000300
		protected bool bottomRightButton(string text, float width = 150f)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002104 File Offset: 0x00000304
		protected bool bottomLeftButton(string text, float width = 150f)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002108 File Offset: 0x00000308
		protected bool bottomCenterButton(string text, float width = 150f)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000210C File Offset: 0x0000030C
		protected bool toggleButton(string defaultText, string selectedText)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002110 File Offset: 0x00000310
		protected bool toggleButtonState(string defaultText)
		{
		}

		// Token: 0x04000017 RID: 23
		protected float _width;

		// Token: 0x04000018 RID: 24
		protected float _buttonHeight;

		// Token: 0x04000019 RID: 25
		protected Dictionary<string, bool> _toggleButtons;

		// Token: 0x0400001A RID: 26
		protected StringBuilder _logBuilder;

		// Token: 0x0400001B RID: 27
		private bool _logRegistered;

		// Token: 0x0400001C RID: 28
		private Vector2 _logScrollPosition;

		// Token: 0x0400001D RID: 29
		private bool _isShowingLogConsole;

		// Token: 0x0400001E RID: 30
		private float _doubleClickDelay;

		// Token: 0x0400001F RID: 31
		private float _previousClickTime;
	}
}
