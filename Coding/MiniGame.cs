using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    int scoreAccumulated;

    public bool player_collided = false;
    public bool begin_game = false;
    int itemCounter = 0;

    void Start()
    {
        if (begin_game)
        {
            StartCoroutine(PlayGame());
            if (scoreAccumulated != 0)
            {
                //increase score of both players by the accumulated
            }
        }
    }

    public void NotifyItemCollected() {
        itemCounter++;
        if (itemCounter == 2) begin_game = true;
    }

    IEnumerator PlayGame() {
        float countdown = 20;
        while (countdown > 0) {
            yield return new WaitForSeconds(1.0f);
            if(!player_collided) {
                scoreAccumulated += 5;
                countdown--;
            } else {
                scoreAccumulated = 0;
            }
        }
    }

    public void NotifyCollision() {
        player_collided = true;
    }
}