using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryChecker : MonoBehaviour
{
    public Button item1, item2, item3, item4;

    void Update()
    {
        if(ShopController.itemID01)
        {
            item1.interactable = true;
        }else{
            item1.interactable = false;
        }

        if(ShopController.itemID02)
        {
            item2.interactable = true;
        }else{
            item2.interactable = false;
        }

        if(ShopController.itemID03)
        {
            item3.interactable = true;
        }else{
            item3.interactable = false;
        }

        if(ShopController.itemID04)
        {
            item4.interactable = true;
        }else{
            item4.interactable = false;
        }
    }
}
