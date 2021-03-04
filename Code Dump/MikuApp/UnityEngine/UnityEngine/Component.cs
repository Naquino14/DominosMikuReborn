using System;
using System.Runtime.CompilerServices;
using UnityEngineInternal;

namespace UnityEngine
{
	public class Component : Object
	{
		public Transform transform => (Transform)/*Error near IL_0001: Stack underflow*/;

		public Camera camera
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Light light
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Animation animation
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Renderer renderer
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public AudioSource audio
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public GUIText guiText
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Collider collider
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public GameObject gameObject => (GameObject)/*Error near IL_0001: Stack underflow*/;

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern Transform InternalGetTransform();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern GameObject InternalGetGameObject();

		[MethodImpl(4096)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[WrapperlessIcall]
		public extern Component GetComponent(Type type);

		public T GetComponent<T>() where T : Component
		{
			return (T)/*Error near IL_0001: Stack underflow*/;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type t)
		{
			return (Component)/*Error near IL_0001: Stack underflow*/;
		}

		public T GetComponentInChildren<T>() where T : Component
		{
			return (T)/*Error near IL_0001: Stack underflow*/;
		}

		public T[] GetComponentsInChildren<T>(bool includeInactive) where T : Component
		{
			return (T[])/*Error near IL_0001: Stack underflow*/;
		}

		public T[] GetComponentsInChildren<T>() where T : Component
		{
			return (T[])/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern Component[] GetComponentsWithCorrectReturnType(Type type);

		public T[] GetComponents<T>() where T : Component
		{
			return (T[])/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SendMessage(string methodName, object value, SendMessageOptions options);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void BroadcastMessage(string methodName, object parameter, SendMessageOptions options);

		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
		}
	}
}
