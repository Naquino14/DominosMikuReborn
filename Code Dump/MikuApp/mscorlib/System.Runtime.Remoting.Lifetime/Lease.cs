using System.Collections;

namespace System.Runtime.Remoting.Lifetime
{
	internal class Lease : MarshalByRefObject, ILease
	{
		private delegate TimeSpan RenewalDelegate(ILease lease);

		private DateTime _leaseExpireTime;

		private LeaseState _currentState;

		private TimeSpan _initialLeaseTime;

		private TimeSpan _renewOnCallTime;

		private TimeSpan _sponsorshipTimeout;

		private ArrayList _sponsors;

		private Queue _renewingSponsors;

		private RenewalDelegate _renewalDelegate;

		public TimeSpan CurrentLeaseTime => (TimeSpan)/*Error near IL_0001: Stack underflow*/;

		public LeaseState CurrentState => (LeaseState)/*Error near IL_0001: Stack underflow*/;

		public TimeSpan InitialLeaseTime
		{
			set
			{
			}
		}

		public TimeSpan RenewOnCallTime
		{
			set
			{
			}
		}

		public TimeSpan SponsorshipTimeout
		{
			set
			{
			}
		}

		public void Activate()
		{
		}

		public TimeSpan Renew(TimeSpan renewalTime)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		public void Unregister(ISponsor obj)
		{
		}

		internal void UpdateState()
		{
		}

		private void CheckNextSponsor()
		{
		}

		private void ProcessSponsorResponse(object state, bool timedOut)
		{
		}
	}
}
