public interface IUserDefinedTargetEventHandler
{
	void OnInitialized();

	void OnFrameQualityChanged(ImageTargetBuilder.FrameQuality frameQuality);

	void OnNewTrackableSource(TrackableSource trackableSource);
}
