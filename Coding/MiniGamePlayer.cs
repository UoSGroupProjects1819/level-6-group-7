using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayer : MonoBehaviour
{
    public GameObject mini_game_manager;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MiniGameEnemy>())
        {
            mini_game_manager.GetComponent<MiniGame>().NotifyCollision();
        }
    }
}