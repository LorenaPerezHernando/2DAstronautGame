using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    //Script en UI para controllar los stats del juego 
    [SerializeField] private Slider _energySlider;
    [SerializeField] private TextMeshProUGUI _altitudText;
    [SerializeField] private TextMeshProUGUI _starsCollected;
    [SerializeField] private Jetpack _jetpack;

    [Header("Final Stats")]

    [SerializeField] private TextMeshProUGUI _finalStars;
    [SerializeField] private float _time;
    [SerializeField] private TextMeshProUGUI _finalTime;
    [SerializeField] private InputController _inputController;


    private void Start()
    {
        
        _time = 0;
    }

    void Update()         
    {
        _energySlider.value = _jetpack.Energy;

        _starsCollected.text = ("Stars: " + _jetpack.starsCollected.ToString());
        
        _altitudText.text = ((int)_jetpack.transform.position.y).ToString();

        _finalStars.text = _starsCollected.text ;

        if(_inputController.InGame) 
            _time += Time.deltaTime;
        int minutes = Mathf.FloorToInt(_time / 60);
        int seconds = Mathf.FloorToInt(_time % 60);
        _finalTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        

    }

    public void SustituirStats() //Al poner el panel final se quita el texto que estaba en el juego
    {
        _altitudText.enabled = false;
        _starsCollected.enabled = false;
    }

    public void StatsDeJuego()
    {
        _altitudText.enabled = true;
        _starsCollected.enabled = true;
    }


    
}
