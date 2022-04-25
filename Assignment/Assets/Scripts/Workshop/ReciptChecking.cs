using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciptChecking : MonoBehaviour
{
    [SerializeField]
    private GameObject CakeRecipt;
    [SerializeField]
    private GameObject CookieRecipt;

    // Start is called before the first frame update
    void Start()
    {
       if (CakeButton.cook)
        {
            CakeRecipt.SetActive(true);
        } 
        else if (CookieButton.cook)
        {
            CookieRecipt.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
