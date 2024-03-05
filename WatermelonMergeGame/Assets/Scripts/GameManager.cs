using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private FruitObjectSetting setting;

    private bool isClick => Input.GetMouseButton(0);
    private Vector2Int fruitRange = new Vector2Int(0, 4);
   
    void Start()
    {
        
    }
    private void SpawnFruit()
    {
        var prefab = setting.spawnObject;
        var fruitObject = Instantiate(prefab, spawnPoint);

        var index = Random.Range(fruitRange.x, fruitRange.y);
        var sprite = setting.GetSprite(index);
        var scale = setting.GetScale(index);
        fruitObject.Prepare(sprite,index,scale);

    }

    // Update is called once per frame
    void Update()
    {
        if (isClick)
        {
            SpawnFruit();
        }
    }

   
}
