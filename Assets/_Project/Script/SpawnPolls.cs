using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPolls : MonoBehaviour
{
    [System.Serializable]
    public class Pool {
        public Spawnables tag;
        public GameObject prefab;
        public int maxSize;
        public Transform parentGroup;
    }

    public enum Spawnables
    {
        None, Warrior, Mage, Magic, Arrow, HealthBoost, AmmoBoost
    };
    [SerializeField] private List<Pool> _generalPool = null;
    [SerializeField] private EnemySpawner _enemySpawner = null;
    private Dictionary<Spawnables, Queue<GameObject>> _poolDictionary;
    private Transform _randomizedSpawnPoint;
    
    public void Initialize ()
    {
        Debug.Log(this + " intialized");
        _poolDictionary = new Dictionary<Spawnables, Queue<GameObject>>();

        foreach (Pool pool in _generalPool)
        {
            Queue<GameObject> poolQueue = new Queue<GameObject>();

            for (int i = 0; i < pool.maxSize; i++)
            {
                GameObject obj = Instantiate(pool.prefab, pool.parentGroup);
                
                obj.SetActive(false);
                poolQueue.Enqueue(obj);
            }
            _poolDictionary.Add(pool.tag, poolQueue);
        }
        _enemySpawner.Initialize();
    }

    public GameObject SpawnFromPool (Spawnables tag, Vector3? pos, Quaternion? rotation)
    {
        if(!_poolDictionary.ContainsKey(tag))
        {
            return null;
        }

        GameObject objToSpawn = _poolDictionary[tag].Dequeue();
        if(objToSpawn.activeSelf)
        {
            _poolDictionary[tag].Enqueue(objToSpawn);
            return null;
        }

        if(pos.HasValue)
        {
            objToSpawn.transform.position = pos.Value;
        }
        if(rotation.HasValue)
        {
            objToSpawn.transform.rotation = rotation.Value;
        }
        objToSpawn.SetActive(true);

        IPoolManager[] pooledObj = objToSpawn.GetComponents<IPoolManager>();

        if (pooledObj != null)
            foreach(IPoolManager manager in pooledObj)
            {
                manager.IOnObjectSpawn();
            }

        _poolDictionary[tag].Enqueue(objToSpawn);

        return objToSpawn;
    }

    public bool canSpawnFromPool(Spawnables tag)
    {
        if(_poolDictionary.ContainsKey(tag))
        {
            return _poolDictionary[tag].Peek().activeSelf;
        }
        else
        {
            return false;
        }
    }
}
