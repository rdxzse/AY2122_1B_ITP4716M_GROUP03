using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator MTrigger;

    [SerializeField]
    private string milk = "milk";

    private void OnMouseDown() 
    {
        if (Input.GetButtonDown("Fire1"))
        {
            MTrigger.Play(milk);
        }
    }
}
