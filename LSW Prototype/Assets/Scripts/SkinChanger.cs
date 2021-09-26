using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    public AnimatorOverrideController skin1, skin2, skin3, skin4;

    public void Skin1()
    {
        GetComponent<Animator>().runtimeAnimatorController = skin1 as RuntimeAnimatorController;
    }

    public void Skin2()
    {
        GetComponent<Animator>().runtimeAnimatorController = skin2 as RuntimeAnimatorController;
    }

    public void Skin3()
    {
        GetComponent<Animator>().runtimeAnimatorController = skin3 as RuntimeAnimatorController;
    }

    public void Skin4()
    {
        GetComponent<Animator>().runtimeAnimatorController = skin4 as RuntimeAnimatorController;
    }
}
