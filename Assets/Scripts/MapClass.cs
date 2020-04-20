using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapClass 
{
    public struct MapPoint
    {
        public int num;
        public Vector3 coordinates;
        public int[] neighbours;

        public MapPoint(int num, Vector3 coordinates, int[] neighbours)
        {
            this.num = num;
            this.coordinates = coordinates;
            this.neighbours = neighbours;
        }
    }

    // TODO private with getters and setters
    public MapPoint[] mapPoints;
    public int numOfVertices;
    
    public MapClass(int numOfVertices)
    {
        this.numOfVertices = numOfVertices;
        int[,] graph = GenerateGraph(numOfVertices);
        mapPoints = GenerateMap(graph);
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
        // return new MapPoint[14];
        
        MapPoint[] points = new MapPoint[14];
        points[0] = new MapPoint(0, new Vector3(0.0f, 0.0f, 24.5f), new int[3] {1, 12, 4});
        points[1] = new MapPoint(1, new Vector3(0.0f, 0.0f, 75.3f), new int[3] {0, 2, 13});
        points[2] = new MapPoint(2, new Vector3(48.1f, 0.0f, 91.0f), new int[3] {1, 3, 9});
        points[3] = new MapPoint(3, new Vector3(77.7f, 0.0f, 49.9f), new int[3] {2, 6, 4});
        points[4] = new MapPoint(4, new Vector3(48.4f, 0.0f, 9.1f), new int[3] {3, 0, 5});
        points[5] = new MapPoint(5, new Vector3(49.6f, 0.0f, 24.2f), new int[3] {4, 6, 7});
        points[6] = new MapPoint(6, new Vector3(60.8f, 0.0f, 40.9f), new int[3] {3, 5, 7});
        points[7] = new MapPoint(7, new Vector3(40.9f, 0.0f, 42.2f), new int[3] {5, 6, 8});
        points[8] = new MapPoint(8, new Vector3(45.8f, 0.0f, 55.8f), new int[3] {7, 9, 10});
        points[9] = new MapPoint(9, new Vector3(41.6f, 0.0f, 74.9f), new int[3] {8, 2, 10});
        points[10] = new MapPoint(10, new Vector3(27.1f, 0.0f, 61.6f), new int[3] {8, 9, 11});
        points[11] = new MapPoint(11, new Vector3(24.8f, 0.0f, 46.9f), new int[3] {10, 12, 13});
        points[12] = new MapPoint(12, new Vector3(7.7f, 0.0f, 37.6f), new int[3] {11, 13, 0});
        points[13] = new MapPoint(13, new Vector3(8.1f, 0.0f, 57.5f), new int[3] {1, 12, 11});
        return points;
    }
}
