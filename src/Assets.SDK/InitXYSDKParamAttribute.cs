using System;

namespace Assets.SDK
{
	public sealed class InitXYSDKParamAttribute : JoyYouSDKAttribute
	{
		public override string NAME
		{
			get
			{
				return "__XYSDK__";
			}
		}

		public InitXYSDKParamAttribute(int appId, string appKey, string noficationObjectName, bool isLongConnect, bool rechargeEnable, int rechargeAmount, string closeRechargeAlertMsg, bool isOriPortrait, bool isOriLandscapeLeft, bool isOriLandscapeRight, bool isOriPortraitUpsideDown, bool logEnable) : base(appId, appKey, noficationObjectName, isLongConnect, rechargeEnable, rechargeAmount, closeRechargeAlertMsg, isOriPortrait, isOriLandscapeLeft, isOriLandscapeRight, isOriPortraitUpsideDown, logEnable)
		{
		}
	}
}
