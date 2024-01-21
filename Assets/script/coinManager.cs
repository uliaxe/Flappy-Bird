using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinManager : MonoBehaviour
{
    public static coinManager instance;
    public TextMeshProUGUI text;

    int score;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    public void ChangeCoin(int coinValue)
    {
        score += coinValue;
        text.text = "X"+score.ToString();
    }
}
