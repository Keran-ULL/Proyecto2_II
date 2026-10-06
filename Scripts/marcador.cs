using UnityEngine;

public class marcador : MonoBehaviour
{
    public Objetodesplazable objeto1;
    public Objetodesplazable objeto2;
    public Objetodesplazable objeto3;
   
    public Vector3 desplazamiento1;
    public Vector3 desplazamiento2;
    public Vector3 desplazamiento3;

    private bool desplazados = false;
    private bool espacioPulsadoAntes = false;

    void Start()
    {
        // El marcador asigna a cada objeto su desplazamiento
        objeto1.desplazamiento = desplazamiento1;
        objeto2.desplazamiento = desplazamiento2;
        objeto3.desplazamiento = desplazamiento3;
    }

    void Update()
    {
        bool espacioPulsado = Input.GetAxis("Jump") > 0;
        if (espacioPulsado && !espacioPulsadoAntes)
        {
            desplazados = !desplazados;
            if (desplazados)
            {
                objeto1.Desplazar();
                objeto2.Desplazar();
                objeto3.Desplazar();
            }
            else
            {
                objeto1.VolverAlOrigen();
                objeto2.VolverAlOrigen();
                objeto3.VolverAlOrigen();
            }
        }
        espacioPulsadoAntes = espacioPulsado;
    }
}
