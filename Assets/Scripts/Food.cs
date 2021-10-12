using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Food : MonoBehaviour
    {
        [SerializeField] AudioClip foodPickUpSFX;
        [SerializeField] int pointsForPickUp = 100;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            FindObjectOfType<GameSession>().AddToScore(pointsForPickUp);
            AudioSource.PlayClipAtPoint(foodPickUpSFX, Camera.main.transform.position);
            Destroy(gameObject);
            FindObjectOfType<player>().Grow();


        }



    }




