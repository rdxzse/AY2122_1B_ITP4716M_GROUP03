using UnityEngine;
using System.Collections;

public class canch : MonoBehaviour
{
    public GameObject cam1, cam2, cam3, cam4, hitobj;

    void Start()
    {
        hitobj.SetActive(true);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }
    public static bool Space = false;
    void Update()
    {
        if (Input.GetKey("1") == true)
        {
            hitobj.SetActive(true);
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);

        }
        else if (Input.GetKey("2") == true)
        {
            hitobj.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            cam4.SetActive(false);
        }

        else if (Input.GetKey("3") == true)
        {
            hitobj.SetActive(false);
            cam1.SetActive(false);
            cam4.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }
        else if (Input.GetKey("4") == true)
        {
            hitobj.SetActive(false);
            cam1.SetActive(false);
            cam4.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);

        }
    }
}

