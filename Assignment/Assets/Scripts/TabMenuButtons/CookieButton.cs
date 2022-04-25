using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookieButton : MonoBehaviour
{
    Text text;
    public static bool cook = false;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "You need to make a cookie now.";
        cook = true;
    }

}
