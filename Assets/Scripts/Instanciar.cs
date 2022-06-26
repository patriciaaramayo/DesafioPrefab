using UnityEngine;

public class Instanciar : MonoBehaviour
{
    public GameObject prefabBala;
    //public Vector3 posicion;
    public Transform positionTorreta;

    void Start()
    {
    
       
    }


    void Update()
    {
        CrearProyectil();
    }

    void CrearProyectil()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(prefabBala, positionTorreta.position, transform.rotation);
        }    
    }
}
