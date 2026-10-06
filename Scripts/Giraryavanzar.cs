using UnityEngine;

public class GirarYAvanzar : MonoBehaviour
{
    public float speed = 2.0f;

    public float velocidadGiro = 90.0f;

    public float longitudRayo = 3.0f;

    void Update()
    {
        float giro = Input.GetAxis("Horizontal");

        transform.Rotate(0.0f, giro * velocidadGiro * Time.deltaTime, 0.0f);

       transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);

        Debug.DrawRay(transform.position, transform.forward * longitudRayo, Color.red);
    }
}
