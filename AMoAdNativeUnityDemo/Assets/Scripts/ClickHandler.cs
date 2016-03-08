using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour {
	private const string ad_sid = "62056d310111552c000000000000000000000000000000000000000000000000";
	private const string ad_tag = "Ad01";

	public void onShowBtnClick() {
		Debug.Log("show");
		AMoAdNativeUnityPlugin.Show(ad_sid, ad_tag);
	}
	public void onHideBtnClick() {
		Debug.Log("hide");
		AMoAdNativeUnityPlugin.Hide(ad_sid, ad_tag);
	}
	public void onLoadBtnClick() {
		Debug.Log("load");
#if UNITY_ANDROID
        AMoAdNativeUnityPlugin.SetConnectTimeoutSeconds(5);
        AMoAdNativeUnityPlugin.SetReadTimeoutSeconds(5);
		AMoAdNativeUnityPlugin.Load(ad_sid, ad_tag, 100, 100, 140, 120);
#else
		AMoAdNativeUnityPlugin.Load(ad_sid, ad_tag, 100, 100, 140, 120);
#endif
	}
	public void onRemoveBtnClick() {
		Debug.Log("remove");
		AMoAdNativeUnityPlugin.Remove(ad_sid, ad_tag);
	}
	public void onReloadBtnClick() {
		Debug.Log("reload");
		AMoAdNativeUnityPlugin.Reload(ad_sid, ad_tag);
	}
	public void onStartBtnClick() {
		Debug.Log("start");
		AMoAdNativeUnityPlugin.StartRotation(ad_sid, ad_tag, 10);
	}
	public void onStopBtnClick() {
		Debug.Log("stop");
		AMoAdNativeUnityPlugin.StopRotation(ad_sid, ad_tag);
	}
}
