using UnityEngine;

public class CC_CookieManager : MonoBehaviour {
	public static CC_CookieManager Instance;
	[SerializeField] int point;
	[SerializeField] int clickMultiplier = 1;
	[SerializeField] float autoClickRate;
	private void Awake() {
		if (Instance == null) {
			Instance = this;
		}
		else {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}
	public void AddPoint(int amount) {
		point += (amount == 0) ? clickMultiplier : amount;
		Debug.Log("Points: " + point);
	}
	public void SetClickMultiplier(int amount) {
		clickMultiplier = amount;
		Debug.Log("Click Multiplier: " + clickMultiplier);
	}
	public bool CanAfford(int cost) {
		return point >= cost ? (point -= cost) >= 0 : false;
	}
}