using System;
using System.Collections;
using System.Collections.Generic;
using PlayerBase;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CoinCollector coinCollector = other.GetComponent<CoinCollector>();
        if (coinCollector)
        {
            coinCollector.Coins++;
            coinCollector.RefreshText();
            Destroy(gameObject);
        }
    }
}