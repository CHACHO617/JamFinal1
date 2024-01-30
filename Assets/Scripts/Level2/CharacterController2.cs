using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController2 : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;
    private bool mirandoDerecha = true;
    public float fuerzaSalto;
    public LayerMask Tilemap;
    public int saltosMaximos;
    private int saltosRestantes;
    private Animator animator;



    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        saltosRestantes = saltosMaximos;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        procesarMovimiento();
        ProcesarSalto();
    }

    private void procesarMovimiento()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");

        if (inputMovimiento != 0f && EstaEnElSuelo() == true)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        rigidbody.velocity = new Vector2(inputMovimiento * velocidad, rigidbody.velocity.y);

        GestionarOrientacion(inputMovimiento);
    }

    void GestionarOrientacion(float inputMovimiento)
    {
        if ((mirandoDerecha == true && inputMovimiento < 0) || mirandoDerecha == false && inputMovimiento > 0)
        {
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    void ProcesarSalto()
    {
        if (EstaEnElSuelo())
        {
            saltosRestantes = saltosMaximos;
        }

        if (Input.GetKeyDown(KeyCode.Space) && saltosRestantes > 0)
        {
            saltosRestantes = saltosRestantes - 1;
            rigidbody.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }

    bool EstaEnElSuelo()
    {
        RaycastHit2D raycasthit = Physics2D.BoxCast(boxCollider.bounds.center, new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y), 0f, Vector2.down, 0.5f, Tilemap);

        return raycasthit.collider != null;
    }

    public void SetIsDead2(bool value)
    {

        animator.SetBool("isDead", value);
        Invoke("LooseLoadScene", 1.19f);
    }

    private void LooseLoadScene()
    {
        SceneManager.LoadScene("Loose");
    }

    public void SetNextLevel2(bool value)
    {
        //animator.SetBool("isWon", value);
        Invoke("WinLoadScene", 1.5f);
    }

    private void WinLoadScene()
    {
        SceneManager.LoadScene("Objective3");
    }
}
