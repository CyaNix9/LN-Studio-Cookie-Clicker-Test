using UnityEngine;

public class CC_ShopManager : MonoBehaviour {
	public CC_ShopItem[] shopItems;
	public CC_CookieManager cookieManager;
	public void BuyItem(int index) {
		if (index < 0 || index >= shopItems.Length) {
			Debug.LogError("Invalid item index");
			return;
		}
		CC_ShopItem item = shopItems[index];
		if (cookieManager.CanAfford(item.itemPrice)) {
			item.PurchaseItem(cookieManager);
			Debug.Log("Purchased: " + item.itemName);
		}
		else {
			Debug.Log("Not enough cookies to purchase: " + item.itemName);
		}
	}
}