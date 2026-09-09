
using UnityEngine;
using UnityEngine.InputSystem;


public class mover : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    public float speed = 5f;

    private Vector3 moveInput;
    private Rigidbody rb;


    public GameObject Objeto;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation; // Evita tombar
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


}

