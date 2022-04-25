using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public bool step1, step2, step3, step4;

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
        
    }

    void Update()
    {
        if (!(step1 && step2 && step3 && step4) )
        { 
            
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Input.GetButtonDown("Fire1"))
                {
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.name == "milk") {
                            step1 = true; 
                        }
                    }
                        else if (hit.collider.name == "shaker")
                        {
                            step2 = true;
                       }
                     else if (hit.collider.name == "sphere")
                    {
                        step3 = true;
                    }
                    else if (hit.collider.name == "egggggg")
                    {
                        step4 = true;
                    }
                   
                }
            //NextStepButton.SetActive(true);
        }
        
    }
}

