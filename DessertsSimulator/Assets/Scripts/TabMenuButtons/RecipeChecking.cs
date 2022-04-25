using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WSTabPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject tabPanel;

    // Start is called before the first frame update
    void Start()
    {
        if (CakeButton.cook)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            tabPanel.SetActive(true);
        } else
        {
            tabPanel.SetActive(false);
        }
    }
}
