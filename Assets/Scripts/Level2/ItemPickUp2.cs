using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemPickUp2 : MonoBehaviour
{
    public CharacterController characterController;
    private SpriteRenderer spriteRenderer;
    private AudioSource ad;
    //public GameManager1 GameManager1;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        ad = GetComponent<AudioSource>();
        //GameManager1 = GameObject.FindObjectOfType<GameManager1>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CharacterController2 characterController = collision.GetComponent<CharacterController2>();
            ad.Play();
            spriteRenderer.enabled = false;
            characterController.SetNextLevel2(true);
            Debug.Log("Item Recogido");
            Invoke("ChangeScene1", 4f);
        }
    }

    void ChangeScene1()
    {
        SceneManager.LoadScene("Intro3");
    }
}
