using System;
using System.Runtime.CompilerServices;
using UnityEngineInternal;

namespace UnityEngine
{
	public sealed class GameObject : Object
	{
		public bool isStatic
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		internal bool isStaticBatchable
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Transform transform
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Rigidbody rigidbody
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

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

		public ConstantForce constantForce
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

		public NetworkView networkView
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		[Obsolete("Please use guiTexture instead")]
		public GUIElement guiElement
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public GUITexture guiTexture
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

		public HingeJoint hingeJoint
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public ParticleEmitter particleEmitter
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public ParticleSystem particleSystem
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public int layer
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
		public bool active
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool activeSelf
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public bool activeInHierarchy
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public string tag
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public GameObject gameObject => (GameObject)/*Error near IL_0001: Stack underflow*/;

		public GameObject(string name)
		{
		}

		public GameObject()
		{
		}

		public GameObject(string name, params Type[] components)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern GameObject CreatePrimitive(PrimitiveType type);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public extern Component GetComponent(Type type);

		public T GetComponent<T>() where T : Component
		{
			return (T)/*Error near IL_0001: Stack underflow*/;
		}

		public Component GetComponent(string type)
		{
			return (Component)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern Component GetComponentByName(string type);

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type type)
		{
			return (Component)/*Error near IL_0001: Stack underflow*/;
		}

		public T GetComponentInChildren<T>() where T : Component
		{
			return (T)/*Error near IL_0001: Stack underflow*/;
		}

		[CanConvertToFlash]
		public Component[] GetComponents(Type type)
		{
			return (Component[])/*Error near IL_0001: Stack underflow*/;
		}

		public T[] GetComponents<T>() where T : Component
		{
			return (T[])/*Error near IL_0001: Stack underflow*/;
		}

		public Component[] GetComponentsInChildren(Type type)
		{
			return (Component[])/*Error near IL_0001: Stack underflow*/;
		}

		public Component[] GetComponentsInChildren(Type type, bool includeInactive)
		{
			return (Component[])/*Error near IL_0001: Stack underflow*/;
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
		private extern Component[] GetComponentsInternal(Type type, bool isGenericTypeArray, bool recursive, bool includeInactive);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SetActive(bool value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		[Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
		public extern void SetActiveRecursively(bool state);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern bool CompareTag(string tag);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern GameObject FindGameObjectWithTag(string tag);

		public static GameObject FindWithTag(string tag)
		{
			return (GameObject)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern GameObject[] FindGameObjectsWithTag(string tag);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SendMessageUpwards(string methodName, object value, SendMessageOptions options);

		public void SendMessageUpwards(string methodName, object value)
		{
		}

		public void SendMessageUpwards(string methodName)
		{
		}

		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SendMessage(string methodName, object value, SendMessageOptions options);

		public void SendMessage(string methodName, object value)
		{
		}

		public void SendMessage(string methodName)
		{
		}

		public void SendMessage(string methodName, SendMessageOptions options)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void BroadcastMessage(string methodName, object parameter, SendMessageOptions options);

		public void BroadcastMessage(string methodName, object parameter)
		{
		}

		public void BroadcastMessage(string methodName)
		{
		}

		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern Component AddComponent(string className);

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component AddComponent(Type componentType)
		{
			return (Component)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern Component Internal_AddComponentWithType(Type componentType);

		public T AddComponent<T>() where T : Component
		{
			return (T)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_CreateGameObject([Writable] GameObject mono, string name);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SampleAnimation(AnimationClip animation, float time);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		[Obsolete("gameObject.PlayAnimation is not supported anymore. Use animation.Play")]
		public extern void PlayAnimation(AnimationClip animation);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		[Obsolete("gameObject.StopAnimation is not supported anymore. Use animation.Stop")]
		public extern void StopAnimation();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern GameObject Find(string name);
	}
}
