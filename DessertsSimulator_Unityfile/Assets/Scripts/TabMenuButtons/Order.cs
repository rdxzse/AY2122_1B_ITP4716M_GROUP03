using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Order : MonoBehaviour
{
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        
        text.text = "Make a cake                                                             or make a cookie?";
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
