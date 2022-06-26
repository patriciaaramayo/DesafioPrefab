using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed = 5.0f;
    public int damage = 0;
    public Vector3 direccion = new Vector3(1,0,0);

    void Start()
    {
        
    }

    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        transform.position += direccion * speed * Time.deltaTime;
    }

}
