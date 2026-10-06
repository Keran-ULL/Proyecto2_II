using UnityEngine;

public class PerseguirEsfera : MonoBehaviour
{
    public Transform esfera;
    public float speed = 2.0f;
    public float distanciaParada = 0.1f;

    void Update()
    {
        Vector3 direccion = esfera.position - transform.position;
        direccion.y = 0.0f;

        if (direccion.magnitude > distanciaParada)
        {
            transform.Translate(direccion.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}
