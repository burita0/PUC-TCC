using UnityEngine;
using UnityEngine.InputSystem;

public class EM_Purrar : MonoBehaviour
{
   bool pertoDaCaixa = false;
   private Rigidbody rb;
   public Mov mover;

void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("apert"))
    {
        pertoDaCaixa = true;
        
         
    }
}

void OnCollisionExit(Collision collision)
{
    if (collision.gameObject.CompareTag("apert"))
    {
        pertoDaCaixa = false;
        rb.isKinematic = true;
       
    }
}

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mover = GameObject.FindGameObjectWithTag("apert").GetComponent<Mov>();
    }

    void Update()
{
    if (pertoDaCaixa && Keyboard.current.eKey.isPressed)
    {
        rb.isKinematic = false;
         mover.OnEmpurrar();
    }
    else
    {
        rb.isKinematic = true;
        mover.OnEmpurrarExi();
    }
}
}
