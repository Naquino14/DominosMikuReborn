using System;

// Token: 0x0200008F RID: 143
public interface ICloudRecoEventHandler
{
	// Token: 0x060003F6 RID: 1014
	void OnInitialized();

	// Token: 0x060003F7 RID: 1015
	void OnInitError(TargetFinder.InitState initError);

	// Token: 0x060003F8 RID: 1016
	void OnUpdateError(TargetFinder.UpdateState updateError);

	// Token: 0x060003F9 RID: 1017
	void OnStateChanged(bool scanning);

	// Token: 0x060003FA RID: 1018
	void OnNewSearchResult(TargetFinder.TargetSearchResult targetSearchResult);
}
