using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator SphTrigger;

    [SerializeField]
    private string sphere = "sphere";

    private void OnMouseDown()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SphTrigger.Play(sphere);
        }
    }
}
