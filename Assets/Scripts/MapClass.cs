using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapClass 
{
    public struct MapPoint
    {
        public Vector3 coordinates;
        public Vector3[] neighbours;
    }

    // TODO private with getters and setters
    public MapPoint[] map;
    
    public MapClass(int numOfVertices)
    {
        int[,] graph = GenerateGraph(numOfVertices);
        map = GenerateMap(graph);
    }

    private int[,] GenerateGraph(int numOfVertices)
    {
        if (numOfVertices % 2 != 0)
        {
            // TODO: throw handmade exception
            throw new Exception();
        }
        // TODO write algo to create cubic graph with x vertices https://stackoverflow.com/questions/3112818/generating-a-random-cubic-graph-with-uniform-probability-or-less
        return new int[2, 3] {{1, 2, 3}, {1, 2, 3}};
    }

    private MapPoint[] GenerateMap(int[,] graph)
    {
        // TODO write algo to create map from graph
        return new MapPoint[14];
    }
}
