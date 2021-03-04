using System;
using UnityEngine;

namespace Prime31
{
	public abstract class AbstractManager : MonoBehaviour
	{
		private static ThreadingCallbackHelper _threadingCallbackHelper;

		private static GameObject _prime31GameObject;

		public static ThreadingCallbackHelper getThreadingCallbackHelper()
		{
			return (ThreadingCallbackHelper)/*Error near IL_0001: Stack underflow*/;
		}

		public static void createThreadingCallbackHelper()
		{
		}

		public static GameObject getPrime31ManagerGameObject()
		{
			return (GameObject)/*Error near IL_0001: Stack underflow*/;
		}

		public static void initialize(Type type)
		{
		}

		private void Awake()
		{
		}
	}
}
