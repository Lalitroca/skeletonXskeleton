using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _gameManager = null;
    [SerializeField] private GameObject[] _coffins = null;
    [SerializeField] private Transform enemyParent = null;
    [SerializeField] private float _maxEnemyAmmount = 1;
    [SerializeField] private int _timeBetweenSpawns = 3;
    [SerializeField] private EnemyRandomizer[] _possibleEnemies = null;
    private SpawnPolls _spawner;
    private List<GameObject> _allEnemies;
    private List<EnemyRandomizer> _possibleEnemiesList;
    private List<GameObject> _coffinsList;
    private float _spawnTimer;
    private CoffinAnimator _coffinAnimator;

    [System.Serializable]
    public class EnemyRandomizer
    {
        public SpawnPolls.Spawnables tag;
        public int rate;
    }

    public void Initialize()
    {
        Debug.Log(this + " intialized");
        _spawner = GetComponentInChildren<SpawnPolls>();
        _possibleEnemiesList = new List<EnemyRandomizer>();
        _allEnemies = new List<GameObject>();
        _coffinsList = new List<GameObject>();

        foreach(GameObject coffin in _coffins)
        {
            _coffinsList.Add(coffin);
        }
        
        foreach(EnemyRandomizer enemy in _possibleEnemies)
        {
            for(int i = 0; i < enemy.rate; i++)
            {
                _possibleEnemiesList.Add(enemy);
            }
        }

        MatchActions.OnMatchStarted += StartMatch;
        MatchActions.OMatchEnded += EndMatch;

        GetAllEnemies();
    }
    public void GetAllEnemies()
    {
        GameObject currentEnemy;
        for(int i = 0; i < enemyParent.childCount; i++)
        {
            currentEnemy = enemyParent.transform.GetChild(i).gameObject;
            _allEnemies.Add(currentEnemy);
            CharacterController controller = currentEnemy.GetComponent<EnemyController>();
            controller.retrievedGameManager = _gameManager;
            controller.Initialize();
        }
    }
    public IEnumerator SpawnNewEnemy()
    {
        yield return new WaitUntil(() => _spawnTimer < Time.time);
        SpawnPolls.Spawnables tag = _possibleEnemiesList[Random.Range(0, _possibleEnemiesList.Count)].tag;
        if(!_spawner.canSpawnFromPool(tag))
        {
            StartCoroutine(SpawnNewEnemy());
            yield return null;
        }
        GameObject coffin = getNextCoffin();
        _coffinAnimator = coffin.GetComponent<CoffinAnimator>();
        _coffinAnimator.OpenCoffin();
        GameObject newEnemy = _spawner.SpawnFromPool(tag, coffin.transform.position, null);
        Debug.Log("Spawning " + newEnemy.gameObject.name);
        _spawnTimer = Time.time + _timeBetweenSpawns;
        _coffinAnimator.CloseCoffin();
        ReturnCoffinToList(coffin);
    }

    public void StartMatch()
    {
        Debug.Log("Match started");
        //StartCoroutine(SpawnStartingEnemies());
    }
    public void EndMatch()
    {
        foreach(GameObject enemy in _allEnemies)
        {
            enemy.SetActive(false);
        }
    }

    private void OnDisable()
    {
        MatchActions.OnMatchStarted -= StartMatch;
        MatchActions.OMatchEnded -= EndMatch;
    }
    private GameObject getNextCoffin()
    {
        int randomIndex = Random.Range(0, _coffinsList.Count - 1);
        GameObject newCoffin = _coffinsList[randomIndex];
        _coffinsList.Remove(newCoffin);
        newCoffin.GetComponent<CoffinAnimator>().RiseCoffin(true);
        return newCoffin;
    }

    private void ReturnCoffinToList(GameObject coffin)
    {
        coffin.GetComponent<CoffinAnimator>().RiseCoffin(false);
        _coffinsList.Add(coffin);
    }

    private IEnumerator SpawnStartingEnemies()
    {
        for(int i = 0; i < _maxEnemyAmmount; i++)
        {
            yield return new WaitUntil(() => _spawnTimer < Time.time);
            StartCoroutine(SpawnNewEnemy());
        }
    }
}
