using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    // Pipe
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Pipe"))
            {
                Score.instance.UpdateScore();
            }
            else if (gameObject.CompareTag("Coin"))
            {
                CoinCounter.instance.UpdateCoin();
            }
            }
        }
    }
