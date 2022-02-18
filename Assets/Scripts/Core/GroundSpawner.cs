using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private float _maxWidth, _minWidth;
    [SerializeField] private Ground _groundPrefab;
    [SerializeField] private float _spawnDelayTime;
    private float _spawnTime;

    private void Start()
    {
        _spawnTime = 0;
    }

    private void Update()
    {
        if (_spawnTime <= 0)
        {
            var ground = Instantiate(_groundPrefab, this.transform);    
            ground.Init(transform.localPosition, Random.Range(_minWidth + Random.Range(-1f, 1f), _maxWidth + Random.Range(-1f, 1f)));
            _spawnTime = _spawnDelayTime + Random.Range(-1f, 1f);
        }
        else
        {
            _spawnTime -= Time.deltaTime;
        }
    }
}
