using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    [SerializeField] GameObject Effect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!(collision.gameObject.tag == "Player"))
        {
            if (!(collision.gameObject.tag == "Coin"))

            {           
                Destroy(gameObject);
                if (collision.gameObject.CompareTag("Enemy"))
                {
                    Destroy(collision.gameObject);
                    GameObject.Find("LevelManager").GetComponent<LevelManager>().AddScore(100);
                    Instantiate(Effect, collision.gameObject.transform.position, Quaternion.identity);
                }
            }
        }
    }
    private void onbecameınvisible()
    {
        Destroy(gameObject);    //arrowcontroller'a sahip obje demek
    }
}
