using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[StructLayout(0)]
	public sealed class Event
	{
		[NonSerialized]
		[NotRenamed]
		internal IntPtr m_Ptr;

		private static Event s_Current;

		private static Event s_MasterEvent;

		public EventType rawType
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public EventType type
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Vector2 mousePosition
		{
			get
			{
				return (Vector2)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector2 delta
		{
			get
			{
				return (Vector2)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		[Obsolete("Use HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);", true)]
		public Ray mouseRay
		{
			get
			{
				return (Ray)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public int button
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public EventModifiers modifiers
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float pressure
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int clickCount
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public char character
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public string commandName
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public KeyCode keyCode
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool shift
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public bool control
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public bool alt
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public bool command
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public bool capsLock
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public bool numeric
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public bool functionKey => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public static Event current
		{
			get
			{
				return (Event)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public bool isKey => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool isMouse => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public Event()
		{
		}

		public Event(Event other)
		{
		}

		private Event(IntPtr ptr)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Init();

		~Event()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Cleanup();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void InitCopy(Event other);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void InitPtr(IntPtr ptr);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern EventType GetTypeForControl(int controlID);

		private void Internal_SetMousePosition(Vector2 value)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Internal_SetMousePosition(Event self, ref Vector2 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Internal_GetMousePosition(out Vector2 value);

		private void Internal_SetMouseDelta(Vector2 value)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Internal_SetMouseDelta(Event self, ref Vector2 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Internal_GetMouseDelta(out Vector2 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_SetNativeEvent(IntPtr ptr);

		private static void Internal_MakeMasterEventCurrent()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Use();

		public static Event KeyboardEvent(string key)
		{
			return (Event)/*Error near IL_0001: Stack underflow*/;
		}

		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override bool Equals(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
