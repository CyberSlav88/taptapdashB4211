using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    [SerializeField] private Transform _player;
    [SerializeField] private Transform _startPoint;

    [SerializeField] private List<GameObject> _chunks;
    private List<GameObject> _spawnedchunks;

    private GameObject startChunkPoint;
    private GameObject endChunkPoint;

    private Vector3 _startNextPoint;
    void Start()
    {
        _startNextPoint = SpawnNewChunk(_startPoint.position);
    }

    void Update()
    {
        
    }

    private Vector3 SpawnNewChunk(Vector3 startPoint)
    {
        GameObject newChunk = Instantiate(_chunks[Random.Range(0, _chunks.Count)]); //создать рандомный элемент из списка наших чанков

        startChunkPoint = newChunk.transform.GetChild(0).gameObject;
        endChunkPoint = newChunk.transform.GetChild(1).gameObject;

        newChunk.transform.position = startPoint + (transform.position + startChunkPoint.transform.localPosition);

        startPoint = endChunkPoint.transform.position;

        _spawnedchunks.Add(newChunk);
        return startPoint;
    }
}
