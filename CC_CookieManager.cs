using UnityEngine;

public class CC_CookieManager : MonoBehaviour {
	[SerializeField] int point;
	[SerializeField] int clickMultiplier = 1;
	[SerializeField] float autoClickRate;
	public void OnCookieClick(int amount) {
		point += amount * clickMultiplier;
		Debug.Log("Cookies: " + point);
	}
	public void AddClickMultiplier(int amount) {
		clickMultiplier += amount;
		Debug.Log("Click Multiplier: " + clickMultiplier);
	}
	public bool CanAfford(int cost) {
		return point >= cost;
	}
}