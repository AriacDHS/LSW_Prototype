using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class balanceUI : MonoBehaviour
{
    public Text balance;

    void Update()
    {
        balance.text = "" + PlayerMovement.coins;
    }
}
