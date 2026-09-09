using UnityEngine;

public class Porta : MonoBehaviour
{
    public Animator anima;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove()
    {
        anima.SetInteger("Porta", 1);
    }
}
