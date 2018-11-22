using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameItem : MonoBehaviour
{
    public GameObject mini_game_manager;

    public void OnCollisionEnter(Collision collision)
    {
            mini_game_manager.GetComponent<MiniGame>().NotifyItemCollected();
    }
}