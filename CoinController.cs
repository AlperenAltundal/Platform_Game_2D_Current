using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    [SerializeField] Text scoreValueText;
    private void Update()
    {
        transform.Rotate(new Vector3(0f, 1.85f, 0f));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("LevelManager").GetComponent<LevelManager>().AddScore(50); ;
            Destroy(gameObject);
        }
    }
}
