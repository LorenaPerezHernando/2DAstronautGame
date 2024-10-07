using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    [SerializeField] private Slider _energySlider;
    [SerializeField] private TextMeshProUGUI _altitudText;
    [SerializeField] private Jetpack _jetpack;
    
    void Update()
    {
        _energySlider.value = _jetpack.Energy;
        _altitudText.text = ((int)_jetpack.transform.position.y).ToString();
    }
}
