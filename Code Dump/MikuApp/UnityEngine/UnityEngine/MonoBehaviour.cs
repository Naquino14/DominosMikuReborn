using System.Collections;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public class MonoBehaviour : Behaviour
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern MonoBehaviour();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Invoke(string methodName, float time);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void InvokeRepeating(string methodName, float time, float repeatRate);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void CancelInvoke(string methodName);

		public Coroutine StartCoroutine(IEnumerator routine)
		{
			return (Coroutine)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern Coroutine StartCoroutine_Auto(IEnumerator routine);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void StopAllCoroutines();

		public static void print(object message)
		{
		}
	}
}
