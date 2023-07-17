using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player player;
    public Score scoreObject;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Coin")
        {
            Debug.Log("We hit something !!!!!!!!");
            scoreObject.updateScore();
            collision.gameObject.SetActive(false);
        }
        else if(collision.collider.tag == "Grass"){
                player.enabled = false;

            FindObjectOfType<GameManager>().GameOver();
        }
        
    }
}
