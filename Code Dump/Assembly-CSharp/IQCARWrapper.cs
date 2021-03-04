using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000C8 RID: 200
public interface IQCARWrapper
{
	// Token: 0x06000577 RID: 1399
	int CameraDeviceInitCamera(int camera);

	// Token: 0x06000578 RID: 1400
	int CameraDeviceDeinitCamera();

	// Token: 0x06000579 RID: 1401
	int CameraDeviceStartCamera();

	// Token: 0x0600057A RID: 1402
	int CameraDeviceStopCamera();

	// Token: 0x0600057B RID: 1403
	int CameraDeviceGetNumVideoModes();

	// Token: 0x0600057C RID: 1404
	void CameraDeviceGetVideoMode(int idx, [In] [Out] IntPtr videoMode);

	// Token: 0x0600057D RID: 1405
	int CameraDeviceSelectVideoMode(int idx);

	// Token: 0x0600057E RID: 1406
	int CameraDeviceSetFlashTorchMode(int on);

	// Token: 0x0600057F RID: 1407
	int CameraDeviceSetFocusMode(int focusMode);

	// Token: 0x06000580 RID: 1408
	int CameraDeviceSetCameraConfiguration(int width, int height);

	// Token: 0x06000581 RID: 1409
	int QcarSetFrameFormat(int format, int enabled);

	// Token: 0x06000582 RID: 1410
	int DataSetExists(string relativePath, int storageType);

	// Token: 0x06000583 RID: 1411
	int DataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr);

	// Token: 0x06000584 RID: 1412
	int DataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr);

	// Token: 0x06000585 RID: 1413
	int DataSetGetTrackablesOfType(int trackableType, [In] [Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr);

	// Token: 0x06000586 RID: 1414
	int DataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength);

	// Token: 0x06000587 RID: 1415
	int DataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In] [Out] IntPtr trackableData);

	// Token: 0x06000588 RID: 1416
	int DataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId);

	// Token: 0x06000589 RID: 1417
	int DataSetHasReachedTrackableLimit(IntPtr dataSetPtr);

	// Token: 0x0600058A RID: 1418
	int ImageTargetBuilderBuild(string targetName, float sceenSizeWidth);

	// Token: 0x0600058B RID: 1419
	void ImageTargetBuilderStartScan();

	// Token: 0x0600058C RID: 1420
	void ImageTargetBuilderStopScan();

	// Token: 0x0600058D RID: 1421
	int ImageTargetBuilderGetFrameQuality();

	// Token: 0x0600058E RID: 1422
	IntPtr ImageTargetBuilderGetTrackableSource();

	// Token: 0x0600058F RID: 1423
	int ImageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In] [Out] IntPtr rectData);

	// Token: 0x06000590 RID: 1424
	int ImageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	// Token: 0x06000591 RID: 1425
	int VirtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	// Token: 0x06000592 RID: 1426
	int ImageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName);

	// Token: 0x06000593 RID: 1427
	int ImageTargetGetVirtualButtons([In] [Out] IntPtr virtualButtonDataArray, [In] [Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName);

	// Token: 0x06000594 RID: 1428
	int ImageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength);

	// Token: 0x06000595 RID: 1429
	int ImageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In] [Out] IntPtr size);

	// Token: 0x06000596 RID: 1430
	int ImageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In] [Out] IntPtr size);

	// Token: 0x06000597 RID: 1431
	int ImageTrackerStart();

	// Token: 0x06000598 RID: 1432
	void ImageTrackerStop();

	// Token: 0x06000599 RID: 1433
	IntPtr ImageTrackerCreateDataSet();

	// Token: 0x0600059A RID: 1434
	int ImageTrackerDestroyDataSet(IntPtr dataSetPtr);

	// Token: 0x0600059B RID: 1435
	int ImageTrackerActivateDataSet(IntPtr dataSetPtr);

	// Token: 0x0600059C RID: 1436
	int ImageTrackerDeactivateDataSet(IntPtr dataSetPtr);

	// Token: 0x0600059D RID: 1437
	int MarkerTrackerStart();

	// Token: 0x0600059E RID: 1438
	void MarkerTrackerStop();

	// Token: 0x0600059F RID: 1439
	int MarkerTrackerCreateMarker(int id, string trackableName, float size);

	// Token: 0x060005A0 RID: 1440
	int MarkerTrackerDestroyMarker(int trackableId);

	// Token: 0x060005A1 RID: 1441
	void InitFrameState([In] [Out] IntPtr frameIndex);

	// Token: 0x060005A2 RID: 1442
	void DeinitFrameState([In] [Out] IntPtr frameIndex);

	// Token: 0x060005A3 RID: 1443
	void UpdateQCAR([In] [Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In] [Out] IntPtr frameIndex, int screenOrientation);

	// Token: 0x060005A4 RID: 1444
	int QcarGetBufferSize(int width, int height, int format);

	// Token: 0x060005A5 RID: 1445
	void QcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally);

	// Token: 0x060005A6 RID: 1446
	void RendererSetVideoBackgroundCfg([In] [Out] IntPtr bgCfg);

	// Token: 0x060005A7 RID: 1447
	void RendererGetVideoBackgroundCfg([In] [Out] IntPtr bgCfg);

	// Token: 0x060005A8 RID: 1448
	void RendererGetVideoBackgroundTextureInfo([In] [Out] IntPtr texInfo);

	// Token: 0x060005A9 RID: 1449
	int RendererSetVideoBackgroundTextureID(int textureID);

	// Token: 0x060005AA RID: 1450
	int RendererIsVideoBackgroundTextureInfoAvailable();

	// Token: 0x060005AB RID: 1451
	int GetInitErrorCode();

	// Token: 0x060005AC RID: 1452
	int IsRendererDirty();

	// Token: 0x060005AD RID: 1453
	int QcarSetHint(int hint, int value);

	// Token: 0x060005AE RID: 1454
	int QcarRequiresAlpha();

	// Token: 0x060005AF RID: 1455
	int GetProjectionGL(float nearClip, float farClip, [In] [Out] IntPtr projMatrix, int screenOrientation);

	// Token: 0x060005B0 RID: 1456
	void SetUnityVersion(int major, int minor, int change);

	// Token: 0x060005B1 RID: 1457
	int TargetFinderStartInit(string userKey, string secretKey);

	// Token: 0x060005B2 RID: 1458
	int TargetFinderGetInitState();

	// Token: 0x060005B3 RID: 1459
	int TargetFinderDeinit();

	// Token: 0x060005B4 RID: 1460
	int TargetFinderStartRecognition();

	// Token: 0x060005B5 RID: 1461
	int TargetFinderStop();

	// Token: 0x060005B6 RID: 1462
	void TargetFinderSetUIScanlineColor(float r, float g, float b);

	// Token: 0x060005B7 RID: 1463
	void TargetFinderSetUIPointColor(float r, float g, float b);

	// Token: 0x060005B8 RID: 1464
	void TargetFinderUpdate([In] [Out] IntPtr targetFinderState);

	// Token: 0x060005B9 RID: 1465
	int TargetFinderGetResults([In] [Out] IntPtr searchResultArray, int searchResultArrayLength);

	// Token: 0x060005BA RID: 1466
	int TargetFinderEnableTracking(IntPtr searchResult, [In] [Out] IntPtr trackableData);

	// Token: 0x060005BB RID: 1467
	void TargetFinderGetImageTargets([In] [Out] IntPtr trackableIdArray, int trackableIdArrayLength);

	// Token: 0x060005BC RID: 1468
	void TargetFinderClearTrackables();

	// Token: 0x060005BD RID: 1469
	int TrackerManagerInitTracker(int trackerType);

	// Token: 0x060005BE RID: 1470
	int TrackerManagerDeinitTracker(int trackerType);

	// Token: 0x060005BF RID: 1471
	int VirtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled);

	// Token: 0x060005C0 RID: 1472
	int VirtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity);

	// Token: 0x060005C1 RID: 1473
	int VirtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In] [Out] IntPtr rectData);

	// Token: 0x060005C2 RID: 1474
	int GetSurfaceOrientation();

	// Token: 0x060005C3 RID: 1475
	int QcarDeinit();
}
