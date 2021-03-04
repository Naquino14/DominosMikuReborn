using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Prime31
{
	public class P31RestKit
	{
		protected string _baseUrl;

		public bool debugRequests;

		protected bool forceJsonResponse;

		private GameObject _surrogateGameObject;

		private MonoBehaviour _surrogateMonobehaviour;

		protected virtual GameObject surrogateGameObject
		{
			get
			{
				return (GameObject)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		protected MonoBehaviour surrogateMonobehaviour
		{
			get
			{
				return (MonoBehaviour)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		[DebuggerHidden]
		protected virtual IEnumerator send(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters, Action<string, object> onComplete)
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		protected virtual WWW processRequest(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters)
		{
			return (WWW)/*Error near IL_0001: Stack underflow*/;
		}

		protected virtual void processResponse(WWW www, Action<string, object> onComplete)
		{
		}

		protected bool isResponseJson(WWW www)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void get(string path, Action<string, object> completionHandler)
		{
		}

		public void get(string path, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}

		public void post(string path, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}
	}
}
