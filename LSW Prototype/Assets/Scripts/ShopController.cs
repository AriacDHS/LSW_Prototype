using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public float price;
    private bool canBuy=false;
    public static bool itemID01, itemID02, itemID03, itemID04;

    public Button sell01, sell02, sell03, sell04;
    public Button buy01, buy02, buy03, buy04;
    public GameObject failScreen;

    public Text cost, sellcost;


    void Update()
    {   
        //shop prices

        cost.text = "" + price;
        sellcost.text = "" + price * 0.6f;

        //if the item was bought or not
        if(itemID01)
        {
            sell01.interactable = true;
        }else{
            sell01.interactable = false;
            buy01.interactable = true;
        }

        if(itemID02)
        {
            sell02.interactable = true;
        }else{
            sell02.interactable = false;
            buy02.interactable = true;
        }

        if(itemID03)
        {
            sell03.interactable = true;
        }else{
            sell03.interactable = false;
            buy03.interactable = true;
        }
        
        if(itemID04)
        {
            sell04.interactable = true;
        }else{
            sell04.interactable = false;
            buy04.interactable = true;
        }

    }

    //Buy functions
    public void Confirmation1()
    {
        if(price<=PlayerMovement.coins)
        {
            canBuy=true;
        }else{
            canBuy=false;
        }
        if(canBuy)
        {
            PlayerMovement.coins-=price;
            itemID01=true;
            Debug.Log(PlayerMovement.coins);
        }
        else
        {
            failScreen.SetActive(true);
        }
    }


    public void Confirmation2()
    {
        if(price<=PlayerMovement.coins)
        {
            canBuy=true;
        }else{
            canBuy=false;
        }
        if(canBuy)
        {
            PlayerMovement.coins-=price;
            itemID02=true;
            Debug.Log(PlayerMovement.coins);
        }
        else
        {
            failScreen.SetActive(true);
        }
    }


    public void Confirmation3()
    {
        if(price<=PlayerMovement.coins)
        {
            canBuy=true;
        }else{
            canBuy=false;
        }
        if(canBuy)
        {
            PlayerMovement.coins-=price;
            itemID03=true;
            Debug.Log(PlayerMovement.coins);
        }
        else
        {
            failScreen.SetActive(true);
        }
    }


    public void Confirmation4()        
    {
        if(price<=PlayerMovement.coins)
        {
            canBuy=true;
        }else{
            canBuy=false;
        }
        if(canBuy)
        {
            PlayerMovement.coins-=price;
            itemID04=true;
            Debug.Log(PlayerMovement.coins);
        }
        else
        {
            failScreen.SetActive(true);
        }
    }

    //Sell Functions

    public void Sell1()
    {
        PlayerMovement.coins+=price*0.6f;
        itemID01 = false;
        Debug.Log(PlayerMovement.coins);
    }

    public void Sell2()
    {
        PlayerMovement.coins+=price*0.6f;
        itemID02 = false;
        Debug.Log(PlayerMovement.coins);
    }

    public void Sell3()
    {
        PlayerMovement.coins+=price*0.6f;
        itemID03 = false;
        Debug.Log(PlayerMovement.coins);
    }

    public void Sell4()
    {
        PlayerMovement.coins+=price*0.6f;
        itemID04 = false;
        Debug.Log(PlayerMovement.coins);
    }
}
