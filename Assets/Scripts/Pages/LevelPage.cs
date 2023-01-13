using Ivannuari;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPage : Page
{
    [SerializeField] Button b_back;
    [SerializeField] Button b_sound;
    [SerializeField] List<GameLevel> levels = new List<GameLevel>();

    [SerializeField] string prevLevelName;
    [SerializeField] string nextLevelName;

    [SerializeField] LevelButton levelButton;
    [SerializeField] Transform buttonContent;

    private void Start()
    {
        b_back.onClick.AddListener(() => ChangeScene(prevLevelName));

        for (int i = 0; i < levels.Count; i++)
        {
            LevelButton b = Instantiate(levelButton, Vector2.zero, Quaternion.identity);

            b.transform.SetParent(buttonContent);
            b.transform.localScale = Vector3.one;
            b.InitButton(levels[i]);
        }
    }

    public void ChangeSceneToGame()
    {
        ChangeScene(nextLevelName);
    }
}
