using UnityEngine;
using UnityEngine.InputSystem;


public class Mov : MonoBehaviour
{

     private Animator anima;
     

    [Header("Configurações de Movimento")]
    public float speed = 5f;

    private Vector3 moveInput;
    private Rigidbody rb;
     public float forcaEmpurrao = 10f;


    public GameObject Objeto;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation; // Evita tombar
         anima = GetComponent<Animator>();
    }

        void Update()
    {
        
    }

    // Chamado automaticamente pelo Player Input
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector3>();
    }

    void FixedUpdate()
    {
        // Converte o input em vetor 3D (X e Z)
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);

        // Calcula posição final respeitando a física
        Vector3 targetPosition = rb.position + move.normalized * speed * Time.fixedDeltaTime;

        // Move o player
        rb.MovePosition(targetPosition);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Empurrar"))
    
     {
        if (Keyboard.current.spaceKey.isPressed)
            {
                Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
                Debug.Log("Abrir porta");
                 if (rb != null)
                {
                    Vector3 direcao = new Vector3(moveInput.x, 0, moveInput.y);

                    rb.AddForce(direcao.normalized * forcaEmpurrao);
                }
            }
     }
    } 
}


