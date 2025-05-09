using UnityEngine;

public class CC_CookieManager : MonoBehaviour {
	int cookieCount;
	int clickMultiplier = 1;
	public void AddCookie(int amount) {
		cookieCount += amount * clickMultiplier;
		Debug.Log("Cookies: " + cookieCount);
	}
	public void AddClickMultiplier(int amount) {
		clickMultiplier += amount;
		Debug.Log("Click Multiplier: " + clickMultiplier);
	}
	public bool CanAfford(int cost) {
		return cookieCount >= cost;
	}
}