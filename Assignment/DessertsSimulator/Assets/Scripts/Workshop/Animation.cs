using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public float range = 999;
    public float force = 999;
    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetButtonDown("Fire1"))
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.name == "milk") 
                    anim.SetTrigger("milk");
                    else if(hit.collider.name == "shaker")
                    {
                        anim.SetTrigger("shaker");
                    }
                    else if (hit.collider.name == "sphere")
                    {
                        anim.SetTrigger("sphere");
                    }
                    else if (hit.collider.name == "egggggg")
                    {
                        anim.SetTrigger("egggggg");
                    }
                }
            }
        }

    }
}

