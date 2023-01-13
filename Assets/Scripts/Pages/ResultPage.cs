using Ivannuari;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultPage : Page
{
    [SerializeField] Hasil[] resultData;

    //reference object
    [SerializeField] Image icon;
    [SerializeField] TMP_Text label_result;
    [SerializeField] TMP_Text label_rewardAmount;
    [SerializeField] TMP_Text label_level;
    [SerializeField] TMP_Text label_timer;

    [SerializeField] int timer = 3;

    public void GameOver(bool menang)
    {
        StartCoroutine(CountDownToPage());
    }

    IEnumerator CountDownToPage()
    {
        int t = 3;
        for (int i = 0; i < timer; i++)
        {
            label_timer.text = $"lanjut dalam {t} detik.";
            yield return new WaitForSeconds(1f);
            t--;
        }
    }
}





[System.Serializable]
public class Hasil
{
    public string hasilText;

    public Sprite icon;
}
