using System;
using UnityEngine;

// Token: 0x0200001A RID: 26
[AddComponentMenu("NGUI/Interaction/Checkbox")]
public class UICheckbox : MonoBehaviour
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060000A6 RID: 166 RVA: 0x000022E4 File Offset: 0x000004E4
	// (set) Token: 0x060000A7 RID: 167 RVA: 0x000022E8 File Offset: 0x000004E8
	public bool isChecked
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000022EC File Offset: 0x000004EC
	private void Awake()
	{
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x000022F0 File Offset: 0x000004F0
	private void Start()
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000022F4 File Offset: 0x000004F4
	private void OnClick()
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000022F8 File Offset: 0x000004F8
	private void Set(bool state)
	{
	}

	// Token: 0x0400008A RID: 138
	public static UICheckbox current;

	// Token: 0x0400008B RID: 139
	public UISprite checkSprite;

	// Token: 0x0400008C RID: 140
	public Animation checkAnimation;

	// Token: 0x0400008D RID: 141
	public bool startsChecked;

	// Token: 0x0400008E RID: 142
	public Transform radioButtonRoot;

	// Token: 0x0400008F RID: 143
	public bool optionCanBeNone;

	// Token: 0x04000090 RID: 144
	public GameObject eventReceiver;

	// Token: 0x04000091 RID: 145
	public string functionName;

	// Token: 0x04000092 RID: 146
	public UICheckbox.OnStateChange onStateChange;

	// Token: 0x04000093 RID: 147
	[SerializeField]
	[HideInInspector]
	private bool option;

	// Token: 0x04000094 RID: 148
	private bool mChecked;

	// Token: 0x04000095 RID: 149
	private bool mStarted;

	// Token: 0x04000096 RID: 150
	private Transform mTrans;

	// Token: 0x0200014E RID: 334
	// (Invoke) Token: 0x06000B2D RID: 2861
	public delegate void OnStateChange(bool state);
}
