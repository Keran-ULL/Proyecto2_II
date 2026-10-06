using UnityEngine;

public class Objetodesplazable : MonoBehaviour
{
    public Vector3 desplazamiento;

    private Vector3 posicionOriginal;

    void Start()
    {
        posicionOriginal = transform.position;
    }

    public void Desplazar()
    {
        transform.position = posicionOriginal + desplazamiento;
    }

    public void VolverAlOrigen()
    {
        transform.position = posicionOriginal;
    }
}
