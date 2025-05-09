using UnityEngine;

public class CC_ShopItem : ScriptableObject {
	public string itemName;
	public int itemPrice;
	public string itemDescription;
	public Sprite itemIcon;
	// Method to purchase the item
	public abstract void PurchaseItem() {
		// Logic for purchasing the item
		Debug.Log("Purchased: " + itemName);
	}
	// Method to display item details
	public void DisplayItemDetails() {
		// Logic for displaying item details
		Debug.Log("Item Name: " + itemName);
		Debug.Log("Item Price: " + itemPrice);
		Debug.Log("Item Description: " + itemDescription);
	}
}