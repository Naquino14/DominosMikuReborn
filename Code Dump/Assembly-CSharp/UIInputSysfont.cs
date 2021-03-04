using System;
using UnityEngine;

// Token: 0x0200010A RID: 266
[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInputSysfont : MonoBehaviour
{
	// Token: 0x17000135 RID: 309
	// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00003ACC File Offset: 0x00001CCC
	// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00003AD0 File Offset: 0x00001CD0
	public virtual string text
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00003AD4 File Offset: 0x00001CD4
	// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00003AD8 File Offset: 0x00001CD8
	public bool selected
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00003ADC File Offset: 0x00001CDC
	protected void Init()
	{
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00003AE0 File Offset: 0x00001CE0
	private void OnEnable()
	{
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x00003AE4 File Offset: 0x00001CE4
	private void OnDisable()
	{
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00003AE8 File Offset: 0x00001CE8
	public virtual void OnSelect(bool isSelected)
	{
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00003AEC File Offset: 0x00001CEC
	private void Update()
	{
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00003AF0 File Offset: 0x00001CF0
	private void OnInput(string input)
	{
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00003AF4 File Offset: 0x00001CF4
	public virtual void UpdateLabel()
	{
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00003AF8 File Offset: 0x00001CF8
	public void RestoreLabel()
	{
	}

	// Token: 0x04000502 RID: 1282
	public static UIInputSysfont current;

	// Token: 0x04000503 RID: 1283
	public UISysFontLabel label;

	// Token: 0x04000504 RID: 1284
	public int maxChars;

	// Token: 0x04000505 RID: 1285
	public string caratChar;

	// Token: 0x04000506 RID: 1286
	public UIInputSysfont.Validator validator;

	// Token: 0x04000507 RID: 1287
	public UIInputSysfont.KeyboardType type;

	// Token: 0x04000508 RID: 1288
	public bool isPassword;

	// Token: 0x04000509 RID: 1289
	public Color activeColor;

	// Token: 0x0400050A RID: 1290
	public GameObject eventReceiver;

	// Token: 0x0400050B RID: 1291
	public string functionName;

	// Token: 0x0400050C RID: 1292
	public UIInputSysfont.OnSubmit onSubmit;

	// Token: 0x0400050D RID: 1293
	[HideInInspector]
	public string mText;

	// Token: 0x0400050E RID: 1294
	[HideInInspector]
	public string mDefaultText;

	// Token: 0x0400050F RID: 1295
	[HideInInspector]
	public Color mDefaultColor;

	// Token: 0x04000510 RID: 1296
	private UIWidget.Pivot mPivot;

	// Token: 0x04000511 RID: 1297
	private float mPosition;

	// Token: 0x04000512 RID: 1298
	public TouchScreenKeyboard mKeyboard;

	// Token: 0x04000513 RID: 1299
	[HideInInspector]
	public bool mDoInit;

	// Token: 0x0200010B RID: 267
	public enum KeyboardType
	{
		// Token: 0x04000515 RID: 1301
		Default,
		// Token: 0x04000516 RID: 1302
		ASCIICapable,
		// Token: 0x04000517 RID: 1303
		NumbersAndPunctuation,
		// Token: 0x04000518 RID: 1304
		URL,
		// Token: 0x04000519 RID: 1305
		NumberPad,
		// Token: 0x0400051A RID: 1306
		PhonePad,
		// Token: 0x0400051B RID: 1307
		NamePhonePad,
		// Token: 0x0400051C RID: 1308
		EmailAddress
	}

	// Token: 0x02000163 RID: 355
	// (Invoke) Token: 0x06000B81 RID: 2945
	public delegate char Validator(string currentText, char nextChar);

	// Token: 0x02000164 RID: 356
	// (Invoke) Token: 0x06000B85 RID: 2949
	public delegate void OnSubmit(string inputString);
}
