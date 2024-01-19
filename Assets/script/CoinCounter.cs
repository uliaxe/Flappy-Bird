using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
    [SerializeField] private TextMeshProUGUI _coinText;

    private int _coin;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }   

    private void Start()
    {
        _coinText.text = _coin.ToString();
    }

    public void UpdateCoin()
    {
        _coin++;
        _coinText.text = _coin.ToString();
    }
}
