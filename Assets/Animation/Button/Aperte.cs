using UnityEngine;

public class Aperte : MonoBehaviour
{
    public Porta Port;

    private Animator anima;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("apert"))
    {
         anima.SetInteger("Apertar", 1);
         Port.OnMove();
        
    }
}
  
   private void OnCollisionExit(Collision collision)
  {
    if (collision.gameObject.CompareTag("apert"))
    {

      anima.SetInteger("Apertar",2);

    }
    
   }

    
     
}
