using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    private Dictionary<Vector3, GridTile> tiles;
    private void Start()
    {
        tiles = new Dictionary<Vector3, GridTile>();
    }

    public void AddTile(Vector3 position, GridTile tile)
    {
        tiles.Add(position, Instantiate(tile, position, Quaternion.identity,this.transform));
    }

    public bool IsTileTaken(Vector3 position)
    {
        return tiles.ContainsKey(position);
    }

    public void RemoveTile(Vector3 position)
    {
        GridTile tile;
        if (tiles.TryGetValue(position, out tile))
        {
            Destroy(tile.gameObject);
            tiles.Remove(position);
        }
    }
}
