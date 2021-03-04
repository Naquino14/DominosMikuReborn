using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Root")]
public class UIRoot : MonoBehaviour
{
	private static List<UIRoot> mRoots;

	private Transform mTrans;

	public bool automatic;

	public int manualHeight;

	public int minimumHeight;

	public int maximumHeight;

	public static List<UIRoot> list => (List<UIRoot>)/*Error near IL_0001: Stack underflow*/;

	public int activeHeight => (int)/*Error near IL_0001: Stack underflow*/;

	public float pixelSizeAdjustment => (float)/*Error near IL_0001: Stack underflow*/;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static void Broadcast(string funcName)
	{
	}

	public static void Broadcast(string funcName, object param)
	{
	}
}
