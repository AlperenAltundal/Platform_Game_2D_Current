using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerControlll : MonoBehaviour
{
    [SerializeField] GameObject player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<PlayerController>().onGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player.GetComponent<PlayerController>().onGround = false;

    }
}
