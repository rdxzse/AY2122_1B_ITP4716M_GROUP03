using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabButton : MonoBehaviour
{
    [SerializeField]
    private GameObject tabPanel;

    public static bool tab = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (tab)
            {
                tab = false;
                tabPanel.SetActive(false);
            }
            else
            {
                tab = true;
                tabPanel.SetActive(true);

            }
        }
    }
}
