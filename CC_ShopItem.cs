using UnityEngine;

public abstract class CC_ShopItem : ScriptableObject {
	public string itemName;
	public int itemPrice;
	public float costMultiplier = 1.15f;
	public abstract void PurchaseItem(CC_CookieManager cookieManager);
}