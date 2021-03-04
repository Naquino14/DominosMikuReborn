public interface ICloudRecoEventHandler
{
	void OnInitialized();

	void OnInitError(TargetFinder.InitState initError);

	void OnUpdateError(TargetFinder.UpdateState updateError);

	void OnStateChanged(bool scanning);

	void OnNewSearchResult(TargetFinder.TargetSearchResult targetSearchResult);
}
