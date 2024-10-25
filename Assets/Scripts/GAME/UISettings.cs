using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEditor;

public class UISettings : MonoBehaviour
{
    //Fields 
    [SerializeField] Button _closeButton;
    [SerializeField] TMP_Dropdown _qualityDrop;
    [SerializeField] Toggle _VSyncToggle;
    [SerializeField] Toggle _fullScreenToggle;
    [SerializeField] Slider _particleResolution;
    [SerializeField] Toggle _noShadowToggle;
    [SerializeField] Toggle _softShadowToggle;
    [SerializeField] Toggle _hardShadowToggle;
    void Start()
    {

        _closeButton.onClick.AddListener(CloseSettings);

        _qualityDrop.onValueChanged.AddListener(SetQuality);

        _VSyncToggle.onValueChanged.AddListener(SetVSync);

        _fullScreenToggle.onValueChanged.AddListener(ToggleFullScreen);

        _particleResolution.onValueChanged.AddListener(SetParticleResolution);
        _noShadowToggle.onValueChanged.AddListener(SetNoShadows);
        _softShadowToggle.onValueChanged.AddListener(SetSoftShadows);
        _hardShadowToggle.onValueChanged.AddListener(SetHardShadows);

        InitializeDropDownQuality();
    }







    //Private Methods
    private void SetHardShadows(bool stateOn)
    {
        if (stateOn)
            QualitySettings.shadows = ShadowQuality.HardOnly;

    }
    private void SetSoftShadows(bool stateOn)
    {
        if (stateOn)
        {

            QualitySettings.shadows = ShadowQuality.All; //Soft
           
        }
    }
    private void SetNoShadows(bool stateOn)
    {
        if(stateOn) 
            QualitySettings.shadows = ShadowQuality.Disable;
    }
    private void SetParticleResolution(float level)
    {
        QualitySettings.particleRaycastBudget = (int)level;
    }
    private void ToggleFullScreen(bool screen)
    {
        Screen.fullScreen = !Screen.fullScreen;

    }
    private void SetVSync(bool stateOn)
    {
        if (stateOn)
            QualitySettings.vSyncCount = 1;
        else
            QualitySettings.vSyncCount = 0;
    }
    private void SetQuality(int index)
    {
        QualitySettings.SetQualityLevel(index, true);
    }

    private void InitializeDropDownQuality()
    {
        List<string> options = new List<string>(QualitySettings.names);
        _qualityDrop.ClearOptions();
        _qualityDrop.AddOptions(options);

        //Configurar el nuvel de calidad actual como la opcion seleccionada
        _qualityDrop.value = QualitySettings.GetQualityLevel();
        _qualityDrop.RefreshShownValue();
    }

    private void CloseSettings()
    {
        gameObject.SetActive(false);
    }

    
}
