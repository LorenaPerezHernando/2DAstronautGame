using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    [SerializeField] private Slider _energySlider;
    [SerializeField] private TextMeshProUGUI _altitudText;
    [SerializeField] private TextMeshProUGUI _starsCollected;
    [SerializeField] private Jetpack _jetpack;

    void Update()
    {
        _energySlider.value = _jetpack.Energy;

        _starsCollected.text = ("Stars: " + _jetpack.starsCollected.ToString());
        
        _altitudText.text = ((int)_jetpack.transform.position.y).ToString();

    }


    
}
