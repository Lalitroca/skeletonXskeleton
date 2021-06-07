using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    [SerializeField] private SpawnPolls.Spawnables[] _possibleItens = null;
    [SerializeField] [Range(0,1)] private float _itemDropRate = 0f;
    private GameObject _gameManager;
    private SpawnPolls _itemPool = null;
    private SpawnPolls.Spawnables _chosenItemTag;
    
    public DropItem Initialize()
    {
        Debug.Log(this + " intialized");
        _gameManager = GameObject.Find("GameManager");
        _itemPool = _gameManager.GetComponentInChildren<SpawnPolls>();

        return this;
    }
    public void DropTheItem()
    {
        SpawnPolls.Spawnables chosenItemTag = ItemToDrop();
        _itemPool.SpawnFromPool(chosenItemTag, transform.position, transform.rotation);
    }

    private SpawnPolls.Spawnables ItemToDrop()
    {
        if(Random.Range(0f,1f) <= _itemDropRate)
        {
            int chosenItem = Random.Range(0, _possibleItens.Length);
            return _possibleItens[chosenItem];
        }
        else
        {
            return SpawnPolls.Spawnables.None;
        }
    }
}
