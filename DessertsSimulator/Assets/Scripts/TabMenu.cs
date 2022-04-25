using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class TabMenu : MonoBehaviour
{

    [SerializeField]
    private GameObject fpsCon;

    [SerializeField]
    private MouseLook m_MouseLook;

    [SerializeField]
    private GameObject tabMenu;

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
        fpsCon.SetActive(false);
        tabMenu.SetActive(true);
        isTab = true;
        m_MouseLook.SetCursorLock(false);
        m_MouseLook.UpdateCursorLock();

    }

    public void Close()
    {

        Time.timeScale = 1;
        fpsCon.SetActive(true);
        tabMenu.SetActive(false);
        isTab = false;
        m_MouseLook.SetCursorLock(true);
        m_MouseLook.UpdateCursorLock();

    }

}
