using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour 

{       //located on Lose Collider on Background in Game Scene
        [SerializeField] AudioClip loseSFX;

        private void OnTriggerEnter2D(Collider2D collision)
        {

        FindObjectOfType<GameSession>().HandleLoseCondition(); //calling from other script "GameSession"
        AudioSource.PlayClipAtPoint(loseSFX, Camera.main.transform.position);
        // Debug.Log("out of bounds");
        }
}
