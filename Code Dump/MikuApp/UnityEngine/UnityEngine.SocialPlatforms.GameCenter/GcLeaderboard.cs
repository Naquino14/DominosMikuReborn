using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms.GameCenter
{
	[StructLayout(0)]
	internal sealed class GcLeaderboard
	{
		private IntPtr m_InternalLeaderboard;

		private Leaderboard m_GenericLeaderboard;

		internal GcLeaderboard(Leaderboard board)
		{
		}

		~GcLeaderboard()
		{
		}

		internal bool Contains(Leaderboard board)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		internal void SetScores(GcScoreData[] scoreDatas)
		{
		}

		internal void SetLocalScore(GcScoreData scoreData)
		{
		}

		internal void SetMaxRange(uint maxRange)
		{
		}

		internal void SetTitle(string title)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern void Internal_LoadScores(string category, int from, int count, int playerScope, int timeScope);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern void Internal_LoadScoresWithUsers(string category, int timeScope, string[] userIDs);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern bool Loading();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern void Dispose();
	}
}
