using Ivannuari;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingPage : Page
{
    [SerializeField] Button b_mulai;
    [SerializeField] Button b_sound;
    [SerializeField] string nextSceneName;

    private void Start()
    {
        b_mulai.onClick.AddListener(() => ChangeScene(nextSceneName));
    }
}
