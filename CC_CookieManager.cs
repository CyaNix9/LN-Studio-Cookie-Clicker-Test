using TMPro;
using UnityEngine;

public class CC_CookieManager : MonoBehaviour {
	public static CC_CookieManager Instance;
	[SerializeField] int point;
	[SerializeField] int clickMultiplier = 1;
	[SerializeField] float autoClickRate;
	[SerializeField] TMP_Text pointText;
	private void Awake() {
		if (Instance == null) {
			Instance = this;
		}
		else {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}
	private void Update() {
		if (autoClickRate > 0) {
			point += (int)(Time.deltaTime * autoClickRate);
		}
	}
	public void AddPoint(int amount) {
		point += (amount == 0) ? clickMultiplier : amount;
		SetPointText();
	}
	void SetPointText() {
		pointText.text = point.ToString();
	}
	public void SetClickMultiplier(int amount) {
		clickMultiplier = amount;
		Debug.Log("Click Multiplier: " + clickMultiplier);
	}
	public void SetAutoClickRate(float rate) {
		autoClickRate = rate;
		Debug.Log("Auto Click Rate: " + autoClickRate);
	}
	public bool CanAfford(int cost) {
		if (point >= cost) {
			point -= cost;
			SetPointText();
			return true;
		}
		else {
			Debug.Log("Not enough points");
			return false;
		}
	}
}