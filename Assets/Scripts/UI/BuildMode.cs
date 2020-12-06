using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BuildMode : MonoBehaviour
{
    [SerializeField]
    private GridInteractionController gridInteraction;
    private VisualElement document;
    private Label ModeLabel;

    private void OnEnable()
    {
        document = GetComponent<UIDocument>().rootVisualElement;
        ModeLabel = document.Q<Label>("ModeLabel");
        gridInteraction.BuildModeChanged += UpdateModeLabel;
        UpdateModeLabel();
    }

    private void UpdateModeLabel()
    {
        ModeLabel.text = gridInteraction.IsBuildMode ? "Build" : "";
    }
}
