using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public float range = 999;
    public float force = 999;
    Animator anim;

    [SerializeField]
    private Collider milk;

    [SerializeField]
    private Collider shaker;

    [SerializeField]
    private Collider sphere;

    [SerializeField]
    private Collider eggggg;



    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetButtonDown("Fire1")){
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
                        anim.SetTrigger("egg");
                    }
                }
            }
    }
}

