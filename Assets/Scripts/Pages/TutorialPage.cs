using Ivannuari;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPage : Page
{
    [SerializeField] Button b_skip;
    [SerializeField] Button b_sound;

    GameCanvasManager canvasManager;

    private void Start()
    {
        canvasManager = GetComponentInParent<GameCanvasManager>();

        b_skip.onClick.AddListener(() => canvasManager.SetPage(1));
    }
}
