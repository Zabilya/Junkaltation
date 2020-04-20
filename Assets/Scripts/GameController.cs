using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    public GameObject cube;

    private MapClass _map;
        
    // Start is called before the first frame update
    void Start()
    {
        _map = new MapClass(14);
        for (int i = 0; i < _map.numOfVertices; i++)
        {
            Instantiate(cube, _map.mapPoints[i].coordinates, Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
