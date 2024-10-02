using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    #region Enums

    public enum ItemTypes
    {
        None,
        NoSe,
        ErrorCode,
        PositiveWords
    }
    #endregion
    #region Properties

    
    [field: SerializeField] public ItemTypes Type { get; set; }
    #endregion

    #region Fields
    #endregion

    #region Callbacks
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region Public Methods
    #endregion
}
