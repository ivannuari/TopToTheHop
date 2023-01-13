using Ivannuari;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvasManager : MonoBehaviour
{
    [SerializeField] Page[] pages;

    private void Start()
    {
        GameMechanism.Instance.OnGamePlayStateChange += Instance_OnGamePlayStateChange;
    }

    private void OnDisable()
    {
        GameMechanism.Instance.OnGamePlayStateChange -= Instance_OnGamePlayStateChange;
    }

    private void Instance_OnGamePlayStateChange(GameMechanism.GameplayState gameplayState)
    {
        switch (gameplayState)
        {
            case GameMechanism.GameplayState.STARTGAME:
                if (GameManager.Manager.levelNumber == 1)
                {
                    SetPage(0);
                }
                else
                {
                    SetPage(1);
                }
                break;
            case GameMechanism.GameplayState.ENDGAME:
                SetPage(2);
                break;
        }
    }

    public void SetPage(int v)
    {
        foreach (var p in pages)
        {
            p.gameObject.SetActive(false);
        }
        pages[v].gameObject.SetActive(true);
    }
}
