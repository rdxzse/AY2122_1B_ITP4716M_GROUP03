using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    public int resolutionIndex;
    public Dropdown resolutionDd;
    public Resolution[] resolutions;

    public AudioMixer AudioMixer;
    public void SetVolume(float vol)
    {
        AudioMixer.SetFloat("Volume", vol);
    }

    public void SetFullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }

    public void SetQuality(int qv)
    {
        QualitySettings.SetQualityLevel(qv);
    }

    private void OnEnable()
    {
        resolutionDd.onValueChanged.AddListener(delegate { OnResolutionChange(); });
        resolutions = Screen.resolutions;
        foreach (Resolution resolution in resolutions)
        {
            resolutionDd.options.Add(new Dropdown.OptionData(resolution.ToString()));
        }
    }

    public void OnResolutionChange()
    {
        Screen.SetResolution(resolutions[resolutionDd.value].width, resolutions[resolutionDd.value].height, Screen.fullScreen);
    }
}
