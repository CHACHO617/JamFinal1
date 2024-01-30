using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript4 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;


    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();

    }

    public GameObject Explosion;
    // OnTriggerEnter2D is called when the Collider2D other enters the trigger.
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HIT");
        // Check if the other collider has the tag "Player".
        if (other.CompareTag("Player"))
        {
            spriteRenderer.enabled = false;
            boxCollider.enabled = false;
            Instantiate(Explosion, transform.position, Quaternion.identity);
            CharacterController4 characterController = other.GetComponent<CharacterController4>();
            characterController.SetIsDead4(true);


            Debug.Log("Hit player");

            // If the collision is with the player, make the enemy object disappear.
            Destroy(gameObject);

        }
    }
}
