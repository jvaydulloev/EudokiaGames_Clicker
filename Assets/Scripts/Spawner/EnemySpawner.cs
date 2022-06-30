using System.Collections;
using UnityEngine;

public class EnemySpawner : ObjectPool
{
    [SerializeField] private GameObject _prefabForSpawn;
    [SerializeField] private CountingScore _points;

    private Enemy _enemy;
    private Complication _complication;
    private bool _premissionToSpawn=true;

    private void Awake()
    {
        _complication = new Complication();
        _premissionToSpawn = true;
    }
    private void Start()
    {
        Initialize(_prefabForSpawn);
        StartCoroutine(Spawning());
    }

    private void OnEnable()
    {
        CountingScore.OnScoreChanged += _complication.Complicate;
    }
    private void OnDisable()
    {
        CountingScore.OnScoreChanged -= _complication.Complicate;
    }
    private void SpawnEnemy()
    {
        if (TryGetObject(out GameObject temp))
        {
            _enemy = temp.GetComponent<Enemy>();
            _enemy.ReviveEnemy(1+_complication.Difficulty,1+_complication.Difficulty/10);


            Vector3 position = RandomPosition.GetRandomPosition();
            temp.transform.position = position;

            GameMode.OnSpawned?.Invoke();
        }
    }

    private IEnumerator Spawning() 
    {
        while (true) 
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
            if (_premissionToSpawn)
                SpawnEnemy();
            
        }
    }

    public void SetPremissionToSpawn(bool current) 
    {
        _premissionToSpawn = current;
    }
}
