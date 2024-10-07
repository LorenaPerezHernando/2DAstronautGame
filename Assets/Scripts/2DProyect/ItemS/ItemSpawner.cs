using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemSpawner : MonoBehaviour
{
    #region Fields

    [SerializeField] private List<Item> _spawnList;
    [SerializeField] private float _minspawnTime = 1;
    [SerializeField] private float _maxspawnTime = 5;
    private float _nextSpawnTime; 

     private float _cronoTime = 0;
    #endregion
    void Start()
    {
        SpawnTime();
        ResetTime();
    }

    // Update is called once per frame
    void Update()
    {
        _cronoTime += Time.deltaTime;
        if(_cronoTime > _nextSpawnTime)
        {
            SpawnTime();
            ResetTime();
        }
    }

    private void SpawnTime()
    {
        //Random Object from a list
        int index = Random.Range(0, _spawnList.Count);

        //Random Horizontal Pos
        float xPos = Random.Range(-7f, 7f);
        Vector2 itemPosition = new Vector2(xPos, transform.position.y);

        //Instantiate
        Item newItem = Instantiate(_spawnList[index], itemPosition, Quaternion.identity );

        //Add Rotation Force
        int torqueForceZ = Random.Range(-70, 70);
        newItem.GetComponent<Rigidbody2D>().AddTorque(torqueForceZ);

        //Dificulty Progression
        if(_maxspawnTime > _minspawnTime)
        _maxspawnTime -= 0.1f;
    }

    private void ResetTime()
    {
        _cronoTime = 0;
        _nextSpawnTime = Random.Range(_minspawnTime, _maxspawnTime);
    }
}
