using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakerTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator ShaTrigger;

    [SerializeField]
    private string shaker = "shaker";

    private void OnMouseDown()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShaTrigger.Play(shaker);
        }
    }
}
