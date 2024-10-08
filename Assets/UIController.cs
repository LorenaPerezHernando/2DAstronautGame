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
    [SerializeField] private Jetpack _jetpack;

    [SerializeField] GameObject _rechargePartSys; 
    private float _previousValue;


    private void Start()
    {
        
        _previousValue = _jetpack.Energy;
    }
    void Update()
    {
        _energySlider.value = _jetpack.Energy;

        
        _altitudText.text = ((int)_jetpack.transform.position.y).ToString();


        // Comparamos el valor actual con el valor anterior
        if (_jetpack.Energy > _previousValue)
        {            
            Debug.Log("El valor está aumentando.");
            _rechargePartSys.SetActive(true);
        }
        else if (_jetpack.Energy < _previousValue)
        {
            _rechargePartSys.SetActive(false);
            Debug.Log("El valor está disminuyendo.");
        }
        _previousValue = _jetpack.Energy; 
    }


    
}
