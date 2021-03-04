using UnityEngine;

public class ShareComposerController : MonoBehaviour
{
	private const string CONSUMER_KEY = "CwZvon4BKdGa1krWRM6ubw";

	private const string CONSUMER_SECRET = "aHRTcazIIITnGCOvlq0s9F9X8tTphRv1wwPH9rKAyuI";

	private bool _isPostClicked;

	protected string _fbMessage;

	protected virtual void AfterLogin()
	{
	}

	protected virtual void PostFb()
	{
	}

	protected virtual void PostTw()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPostClick(string message)
	{
	}

	protected void PostFacebook()
	{
	}

	private void sessionOpenedEvent()
	{
	}

	protected void completionHandler(string error, object result)
	{
	}

	private void facebookComposerCompletedEvent(bool didSucceed)
	{
	}

	protected void PostTwitter()
	{
	}

	private void tweetSheetCompletedEvent(bool didSucceed)
	{
	}
}
