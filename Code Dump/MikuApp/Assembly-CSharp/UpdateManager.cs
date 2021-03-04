using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Update Manager")]
public class UpdateManager : MonoBehaviour
{
	public class UpdateEntry
	{
		public int index;

		public OnUpdate func;

		public MonoBehaviour mb;

		public bool isMonoBehaviour;
	}

	public class DestroyEntry
	{
		public Object obj;

		public float time;
	}

	public delegate void OnUpdate(float delta);

	private static UpdateManager mInst;

	private List<UpdateEntry> mOnUpdate;

	private List<UpdateEntry> mOnLate;

	private List<UpdateEntry> mOnCoro;

	private BetterList<DestroyEntry> mDest;

	private float mTime;

	private static int Compare(UpdateEntry a, UpdateEntry b)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private static void CreateInstance()
	{
	}

	private void UpdateList(List<UpdateEntry> list, float delta)
	{
	}

	private void Start()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private bool CoroutineUpdate()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	[DebuggerHidden]
	private IEnumerator CoroutineFunction()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void Add(MonoBehaviour mb, int updateOrder, OnUpdate func, List<UpdateEntry> list)
	{
	}

	public static void AddUpdate(MonoBehaviour mb, int updateOrder, OnUpdate func)
	{
	}

	public static void AddLateUpdate(MonoBehaviour mb, int updateOrder, OnUpdate func)
	{
	}

	public static void AddCoroutine(MonoBehaviour mb, int updateOrder, OnUpdate func)
	{
	}

	public static void AddDestroy(Object obj, float delay)
	{
	}
}
