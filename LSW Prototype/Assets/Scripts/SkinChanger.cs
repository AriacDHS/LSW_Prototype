using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    public AnimatorOverrideController skin1, skin2, skin3, skin4;
    public static bool equip1, equip2, equip3, equip4=false;

    public void Skin1()
    {
        GetComponent<Animator>().runtimeAnimatorController = skin1 as RuntimeAnimatorController;
        equip1=true;
        equip2=false;
        equip3=false;
        equip4=false;
    }

    public void Skin2()
    {
        GetComponent<Animator>().runtimeAnimatorController = skin2 as RuntimeAnimatorController;
        equip1=false;
        equip2=true;
        equip3=false;
        equip4=false;
    }

    public void Skin3()
    {
        GetComponent<Animator>().runtimeAnimatorController = skin3 as RuntimeAnimatorController;
        equip1=false;
        equip2=false;
        equip3=true;
        equip4=false;
    }

    public void Skin4()
    {
        GetComponent<Animator>().runtimeAnimatorController = skin4 as RuntimeAnimatorController;
        equip1=false;
        equip2=false;
        equip3=false;
        equip4=true;
    }
}
