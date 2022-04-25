using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator ETrigger;

    [SerializeField]
    private string egg = "egg";

    private void OnMouseDown()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ETrigger.Play(egg);
        }
    }
}
