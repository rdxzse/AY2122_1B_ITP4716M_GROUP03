using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class EscPause : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;

    [SerializeField]
    private GameObject fpsCon;

    [SerializeField] 
    private MouseLook m_MouseLook;

    public static bool isPaused = false;


    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
             if (isPaused)
            {
                Resume();
                
            }
            else 
            {
                Pause();
                
            }
        }

        
    }

    public void Pause()
    {
        Time.timeScale = 0;
        fpsCon.SetActive(false);
        pauseMenu.SetActive(true);
        isPaused = true;
        m_MouseLook.SetCursorLock(false);
        m_MouseLook.UpdateCursorLock();

    }

    public void Resume()
    {
        Time.timeScale = 1;
        fpsCon.SetActive(true);
        pauseMenu.SetActive(false);
        isPaused = false;
        m_MouseLook.SetCursorLock(true);
        m_MouseLook.UpdateCursorLock();

    }
}
