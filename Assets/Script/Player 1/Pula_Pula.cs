using UnityEngine;

public class Pula_Pula : MonoBehaviour
{
    public float forcaPulo = 15f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("apert"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);
                rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            }
        }
    }
}
