using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour {
	private const string sid = "62056d310111552c000000000000000000000000000000000000000000000000";
	private const string tag = "Ad01";

	public void onShowBtnClick() {
		Debug.Log("show");
		AMoAdNativeUnityPlugin.Show(sid, tag);
	}
	public void onHideBtnClick() {
		Debug.Log("hide");
		AMoAdNativeUnityPlugin.Hide(sid, tag);
	}
	public void onLoadBtnClick() {
		Debug.Log("load");
		AMoAdNativeUnityPlugin.Load(sid, tag, 100, 100, 400, 400);
	}
	public void onRemoveBtnClick() {
		Debug.Log("remove");
		AMoAdNativeUnityPlugin.Remove(sid, tag);
	}
	public void onReloadBtnClick() {
		Debug.Log("reload");
		AMoAdNativeUnityPlugin.Reload(sid, tag);
	}
	public void onStartBtnClick() {
		Debug.Log("start");
		AMoAdNativeUnityPlugin.StartRotation(sid, tag, 10);
	}
	public void onStopBtnClick() {
		Debug.Log("stop");
		AMoAdNativeUnityPlugin.StopRotation(sid, tag);
	}
}
