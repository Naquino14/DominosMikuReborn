using System;
using UnityEngine;

// Token: 0x0200006C RID: 108
[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInput : MonoBehaviour
{
	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060002F3 RID: 755 RVA: 0x00002C14 File Offset: 0x00000E14
	// (set) Token: 0x060002F4 RID: 756 RVA: 0x00002C18 File Offset: 0x00000E18
	public string text
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002C1C File Offset: 0x00000E1C
	// (set) Token: 0x060002F6 RID: 758 RVA: 0x00002C20 File Offset: 0x00000E20
	public bool selected
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002C24 File Offset: 0x00000E24
	protected void Init()
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002C28 File Offset: 0x00000E28
	private void OnEnable()
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00002C2C File Offset: 0x00000E2C
	private void OnDisable()
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00002C30 File Offset: 0x00000E30
	private void OnSelect(bool isSelected)
	{
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00002C34 File Offset: 0x00000E34
	private void Update()
	{
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002C38 File Offset: 0x00000E38
	private void OnInput(string input)
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002C3C File Offset: 0x00000E3C
	private void UpdateLabel()
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002C40 File Offset: 0x00000E40
	private void RestoreLabel()
	{
	}

	// Token: 0x040002C3 RID: 707
	public static UIInput current;

	// Token: 0x040002C4 RID: 708
	public UILabel label;

	// Token: 0x040002C5 RID: 709
	public int maxChars;

	// Token: 0x040002C6 RID: 710
	public string caratChar;

	// Token: 0x040002C7 RID: 711
	public UIInput.Validator validator;

	// Token: 0x040002C8 RID: 712
	public UIInput.KeyboardType type;

	// Token: 0x040002C9 RID: 713
	public bool isPassword;

	// Token: 0x040002CA RID: 714
	public Color activeColor;

	// Token: 0x040002CB RID: 715
	public GameObject eventReceiver;

	// Token: 0x040002CC RID: 716
	public string functionName;

	// Token: 0x040002CD RID: 717
	public UIInput.OnSubmit onSubmit;

	// Token: 0x040002CE RID: 718
	private string mText;

	// Token: 0x040002CF RID: 719
	private string mDefaultText;

	// Token: 0x040002D0 RID: 720
	private Color mDefaultColor;

	// Token: 0x040002D1 RID: 721
	private UIWidget.Pivot mPivot;

	// Token: 0x040002D2 RID: 722
	private float mPosition;

	// Token: 0x040002D3 RID: 723
	private TouchScreenKeyboard mKeyboard;

	// Token: 0x040002D4 RID: 724
	private bool mDoInit;

	// Token: 0x0200006D RID: 109
	public enum KeyboardType
	{
		// Token: 0x040002D6 RID: 726
		Default,
		// Token: 0x040002D7 RID: 727
		ASCIICapable,
		// Token: 0x040002D8 RID: 728
		NumbersAndPunctuation,
		// Token: 0x040002D9 RID: 729
		URL,
		// Token: 0x040002DA RID: 730
		NumberPad,
		// Token: 0x040002DB RID: 731
		PhonePad,
		// Token: 0x040002DC RID: 732
		NamePhonePad,
		// Token: 0x040002DD RID: 733
		EmailAddress
	}

	// Token: 0x02000160 RID: 352
	// (Invoke) Token: 0x06000B75 RID: 2933
	public delegate char Validator(string currentText, char nextChar);

	// Token: 0x02000161 RID: 353
	// (Invoke) Token: 0x06000B79 RID: 2937
	public delegate void OnSubmit(string inputString);
}
