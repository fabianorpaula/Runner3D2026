
using Unity.Properties;
using UnityEngine;
using UnityEngine.Rendering;

public class Movimento : MonoBehaviour
{
    private Rigidbody Corpo;
    public float VelocidadeX = 3;
    public float VelocidadeZ = 5;

    void Start()
    {
        Corpo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    void Mover()
    {
        

        Corpo.linearVelocity = new Vector3(0, 0,VelocidadeZ);
    }

}
