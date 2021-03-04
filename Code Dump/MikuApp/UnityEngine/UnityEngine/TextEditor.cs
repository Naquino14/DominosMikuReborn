using System.Collections.Generic;

namespace UnityEngine
{
	public class TextEditor
	{
		private enum CharacterType
		{
			LetterLike,
			Symbol,
			Symbol2,
			WhiteSpace
		}

		public enum DblClickSnapping : byte
		{
			WORDS,
			PARAGRAPHS
		}

		private enum TextEditOp
		{
			MoveLeft,
			MoveRight,
			MoveUp,
			MoveDown,
			MoveLineStart,
			MoveLineEnd,
			MoveTextStart,
			MoveTextEnd,
			MovePageUp,
			MovePageDown,
			MoveGraphicalLineStart,
			MoveGraphicalLineEnd,
			MoveWordLeft,
			MoveWordRight,
			MoveParagraphForward,
			MoveParagraphBackward,
			MoveToStartOfNextWord,
			MoveToEndOfPreviousWord,
			SelectLeft,
			SelectRight,
			SelectUp,
			SelectDown,
			SelectTextStart,
			SelectTextEnd,
			SelectPageUp,
			SelectPageDown,
			ExpandSelectGraphicalLineStart,
			ExpandSelectGraphicalLineEnd,
			SelectGraphicalLineStart,
			SelectGraphicalLineEnd,
			SelectWordLeft,
			SelectWordRight,
			SelectToEndOfPreviousWord,
			SelectToStartOfNextWord,
			SelectParagraphBackward,
			SelectParagraphForward,
			Delete,
			Backspace,
			DeleteWordBack,
			DeleteWordForward,
			DeleteLineBack,
			Cut,
			Copy,
			Paste,
			SelectAll,
			SelectNone,
			ScrollStart,
			ScrollEnd,
			ScrollPageUp,
			ScrollPageDown
		}

		public TouchScreenKeyboard keyboardOnScreen;

		public int pos;

		public int selectPos;

		public int controlID;

		public GUIContent content;

		public GUIStyle style;

		public Rect position;

		public bool multiline;

		public bool hasHorizontalCursorPos;

		public bool isPasswordField;

		internal bool m_HasFocus;

		public Vector2 scrollOffset;

		public Vector2 graphicalCursorPos;

		public Vector2 graphicalSelectCursorPos;

		private bool m_MouseDragSelectsWholeWords;

		private int m_DblClickInitPos;

		private DblClickSnapping m_DblClickSnap;

		private bool m_bJustSelected;

		private int m_iAltCursorPos;

		private string oldText;

		private int oldPos;

		private int oldSelectPos;

		private static Dictionary<Event, TextEditOp> s_Keyactions;

		public bool hasSelection => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public string SelectedText => (string)/*Error near IL_0001: Stack underflow*/;

		private void ClearCursorPos()
		{
		}

		public void OnFocus()
		{
		}

		public void OnLostFocus()
		{
		}

		private void GrabGraphicalCursorPos()
		{
		}

		public bool HandleKeyEvent(Event e)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool DeleteLineBack()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool DeleteWordBack()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool DeleteWordForward()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool Delete()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool CanPaste()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool Backspace()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void SelectAll()
		{
		}

		public void SelectNone()
		{
		}

		public bool DeleteSelection()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void ReplaceSelection(string replace)
		{
		}

		public void Insert(char c)
		{
		}

		public void MoveSelectionToAltCursor()
		{
		}

		public void MoveRight()
		{
		}

		public void MoveLeft()
		{
		}

		public void MoveUp()
		{
		}

		public void MoveDown()
		{
		}

		public void MoveLineStart()
		{
		}

		public void MoveLineEnd()
		{
		}

		public void MoveGraphicalLineStart()
		{
		}

		public void MoveGraphicalLineEnd()
		{
		}

		public void MoveTextStart()
		{
		}

		public void MoveTextEnd()
		{
		}

		public void MoveParagraphForward()
		{
		}

		public void MoveParagraphBackward()
		{
		}

		public void MoveCursorToPosition(Vector2 cursorPosition)
		{
		}

		public void MoveAltCursorToPosition(Vector2 cursorPosition)
		{
		}

		public bool IsOverSelection(Vector2 cursorPosition)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void SelectToPosition(Vector2 cursorPosition)
		{
		}

		public void SelectLeft()
		{
		}

		public void SelectRight()
		{
		}

		public void SelectUp()
		{
		}

		public void SelectDown()
		{
		}

		public void SelectTextEnd()
		{
		}

		public void SelectTextStart()
		{
		}

		public void MouseDragSelectsWholeWords(bool on)
		{
		}

		public void DblClickSnap(DblClickSnapping snapping)
		{
		}

		private int GetGraphicalLineStart(int p)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int GetGraphicalLineEnd(int p)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int FindNextSeperator(int startPos)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool isLetterLikeChar(char c)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private int FindPrevSeperator(int startPos)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public void MoveWordRight()
		{
		}

		public void MoveToStartOfNextWord()
		{
		}

		public void MoveToEndOfPreviousWord()
		{
		}

		public void SelectToStartOfNextWord()
		{
		}

		public void SelectToEndOfPreviousWord()
		{
		}

		private CharacterType ClassifyChar(char c)
		{
			return (CharacterType)/*Error near IL_0001: Stack underflow*/;
		}

		public int FindStartOfNextWord(int p)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int FindEndOfPreviousWord(int p)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public void MoveWordLeft()
		{
		}

		public void SelectWordRight()
		{
		}

		public void SelectWordLeft()
		{
		}

		public void ExpandSelectGraphicalLineStart()
		{
		}

		public void ExpandSelectGraphicalLineEnd()
		{
		}

		public void SelectGraphicalLineStart()
		{
		}

		public void SelectGraphicalLineEnd()
		{
		}

		public void SelectParagraphForward()
		{
		}

		public void SelectParagraphBackward()
		{
		}

		public void SelectCurrentWord()
		{
		}

		private int FindEndOfClassification(int p, int dir)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public void SelectCurrentParagraph()
		{
		}

		public void DrawCursor(string text)
		{
		}

		private bool PerformOperation(TextEditOp operation)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void SaveBackup()
		{
		}

		public void Undo()
		{
		}

		public bool Cut()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void Copy()
		{
		}

		public bool Paste()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static void MapKey(string key, TextEditOp action)
		{
		}

		private void InitKeyActions()
		{
		}

		public void ClampPos()
		{
		}
	}
}
