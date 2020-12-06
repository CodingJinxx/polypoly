using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class TileList : MonoBehaviour
{
    private VisualElement document;
    private VisualElement tileList;

    [SerializeField]
    private VisualTreeAsset emptyTileEntry;

    [SerializeField] private GridInteractionController gridController;

    private void OnEnable()
    {
        document = GetComponent<UIDocument>().rootVisualElement;
        tileList = document.Q<VisualElement>("TileList");
        
        LoadPrefabs();
    }


    public void AddEntry(string tileEntryLable, Action tileEntrySelectedCallback)
    {
        var entry = emptyTileEntry.CloneTree();
        entry.Q<Label>("TileEntryLabel").text = tileEntryLable;
        tileList.Add(entry);
    }

    public void LoadPrefabs()
    {
        List<GridTile> prefabs = PrefabLoader.LoadAllPrefabsOfType<GridTile>("Assets/Prefabs/GridTiles");

        foreach (var tile in prefabs)
        {
            AddEntry(tile.Name, () =>
            {
                gridController.CurrentTile = tile;
            });
        }
    }
}
