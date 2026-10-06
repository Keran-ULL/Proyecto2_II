using UnityEngine;

public class PerseguirMirando : MonoBehaviour
{
    public Transform esfera;

    public float speed = 2.0f;

    public float distanciaParada = 0.1f;

    void Update()
    {
        Vector3 objetivo = new Vector3(esfera.position.x, transform.position.y, esfera.position.z);

        transform.LookAt(objetivo);

        if (Vector3.Distance(transform.position, objetivo) > distanciaParada)
        {
           transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        }
    }
}
