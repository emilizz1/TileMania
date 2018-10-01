using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickuypSFX;
    [SerializeField] int pointsForPickup = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsForPickup);
        AudioSource.PlayClipAtPoint(coinPickuypSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }

}
