using System.Collections.Generic;
using UnityEngine;

public class TwitterEventListener : MonoBehaviour
{
	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void loginSucceeded()
	{
	}

	private void loginFailed(string error)
	{
	}

	private void postSucceeded()
	{
	}

	private void postFailed(string error)
	{
	}

	private void homeTimelineFailed(string error)
	{
	}

	private void homeTimelineReceived(List<object> result)
	{
	}

	private void requestDidFailEvent(string error)
	{
	}

	private void requestDidFinishEvent(object result)
	{
	}

	private void tweetSheetCompletedEvent(bool didSucceed)
	{
	}
}
