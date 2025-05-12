using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "AutoClicker", menuName = "ScriptableObjects/CC_AutoClicker", order = 1)]
public class CC_AutoClicker : CC_ShopItem {
	[SerializeField] private float autoClickRate;
	[SerializeField] private float effectMultiplier = 1.15f;
	[SerializeField] TMP_Text autoClickRateText;
	[SerializeField] TMP_Text priceText;
	public override void PurchaseItem(CC_CookieManager cookieManager) {
		if (cookieManager.CanAfford(itemPrice)) {
			cookieManager.SetAutoClickRate(autoClickRate);
			itemPrice = Mathf.RoundToInt(itemPrice * costMultiplier);
			Debug.Log("Purchased Auto Clicker: " + itemName);
			effectMultiplier = Mathf.RoundToInt(effectMultiplier * costMultiplier);
		}
		else {
			Debug.Log("Not enough cookies to purchase: " + itemName);
		}
	}
}