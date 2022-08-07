using System;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Text CoinsCollectText;
    public GameObject WinPanel;
    
    public int Coins;
    public int CoinsNeedCollect;

    private void Start() => 
        RefreshText();

    private void Update()
    {
        if (Coins == CoinsNeedCollect) 
            WinPanel.SetActive(true);
    }

    public void RefreshText() => 
        CoinsCollectText.text = $"{Coins}/{CoinsNeedCollect}";
}