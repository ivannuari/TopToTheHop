using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] TMP_Text label_level;

    [SerializeField] TMP_Text label_reward;
    [SerializeField] Image icon_reward;

    [SerializeField] Sprite[] frames;
    [SerializeField] Image b_play;

    private Image buttonFrame;
    private Button button;

    private void OnEnable()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(HandleSelectLevel);
    }

    private void HandleSelectLevel()
    {
        //move to game level
        LevelPage levelPage = GetComponentInParent<LevelPage>();
        levelPage.ChangeSceneToGame();
    }

    public void InitButton(GameLevel gameLevel)
    {
        label_level.text = "0" + gameLevel.levelNumber.ToString();

        label_reward.text = gameLevel.rewardAmount.ToString();
        icon_reward.sprite = gameLevel.rewardIcon;

        buttonFrame = GetComponent<Image>();
        button = GetComponent<Button>();

        switch (gameLevel.levelState)
        {
            case LevelState.NotReady:
                b_play.color = Color.gray;
                buttonFrame.sprite = frames[0];
                button.interactable = false;

                break;
            case LevelState.Ready:
                b_play.color = Color.red;
                buttonFrame.sprite = frames[1];
                button.interactable = true;
                break;
            case LevelState.Complete:
                b_play.color = Color.yellow;
                buttonFrame.sprite = frames[2];
                button.interactable = true;
                break;

        }
    }
}