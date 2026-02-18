
using UnityEngine;
using UnityEngine.InputSystem;

public class jugador : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidad = 5f;
    private float movimientoX;
    private Rigidbody2D rb;

    public float fuerzaSalto = 4;
    private bool estaEnSuelo;
    public LayerMask layerSuelo;
    public float radioSuelo = 0.1f;
    public Transform compruebaSuelo;

    private Animator animator;
    private Vector3 posicionInicial;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        posicionInicial = transform.position;
    }

    private void FixedUpdate()
    {
        estaEnSuelo = Physics2D.OverlapCircle(compruebaSuelo.position, radioSuelo, layerSuelo); //2
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(movimientoX * velocidad, rb.linearVelocity.y);

        if (movimientoX == 0)
        {
            animator.SetBool("estaCorriendo", false);
        }

        void OnMove(InputValue inputMove)
        {
            movimientoX = inputMove.Get<Vector2>().x;
            animator.SetBool("estaCorriendo", true);

            if (movimientoX != 0)
            {
                transform.localScale = new Vector3(Mathf.Sign(movimientoX), 1, 1);
            }
        }

        void OnJump(InputValue inputJump)
        {
            if (estaEnSuelo)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
            }
        }

    }

}