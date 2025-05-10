using UnityEngine;

[CreateAssetMenu(fileName = "ClickMultiplier", menuName = "ScriptableObjects/CC_ClickMultiplier", order = 2)]
public class CC_ClickMultiplier : CC_ShopItem {
	[SerializeField] private int clickMultiplier;
	public override void PurchaseItem(CC_CookieManager cookieManager) {
		if (cookieManager.CanAfford(itemPrice)) {
			cookieManager.SetClickMultiplier(clickMultiplier);
			itemPrice = Mathf.RoundToInt(itemPrice * costMultiplier);
			Debug.Log("Purchased Click Multiplier: " + itemName);
			clickMultiplier = Mathf.RoundToInt(clickMultiplier * costMultiplier);
		}
		else {
			Debug.Log("Not enough cookies to purchase: " + itemName);
		}
	}
}