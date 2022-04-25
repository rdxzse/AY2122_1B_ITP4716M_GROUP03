using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class WorkshopTabButton : MonoBehaviour
{

    [SerializeField]
    private GameObject tabPanel;

    [SerializeField]
    private GameObject ButtonText;

    public static bool isTab = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isTab)
            {
                Close();
            }
            else
            {
                Open();

            }
        }

    }

    public void Open()
    {

        Time.timeScale = 0;
        tabPanel.SetActive(true);
        isTab = true;
        ButtonText.SetActive(false);
    }

    public void Close()
    {

        Time.timeScale = 1;
        tabPanel.SetActive(false);
        isTab = false;
        ButtonText.SetActive(true);
    }

}
