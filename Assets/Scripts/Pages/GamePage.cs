using Ivannuari;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePage : Page
{
    //for hp
    [SerializeField] Image[] hearts;

    [SerializeField] TMP_Text label_coinAmount;
    [SerializeField] TMP_Text label_targetAmount;

    [SerializeField] Button b_tap;

    private void Start()
    {
        GameMechanism.Instance.OnHealthChange += Instance_OnHealthChange;

        label_coinAmount.text = GameManager.Manager.totalCoin.ToString();
    }

    private void OnDisable()
    {
        GameMechanism.Instance.OnHealthChange -= Instance_OnHealthChange;
    }

    private void Instance_OnHealthChange(int amount)
    {
        SetHeart(amount);
    }

    public void SetHeart(int hp)
    {
        foreach (var h in hearts)
        {
            h.enabled = false;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = true;
        }
    }

    public void SetCoinAmount(int coin)
    {
        label_coinAmount.text = coin.ToString();
    }

    public void SetTargetAmount(int sisaTarget)
    {
        label_targetAmount.text = sisaTarget.ToString();
    }
}
