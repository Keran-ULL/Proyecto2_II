using UnityEngine;

public class MoverConTeclasDeltaTime : MonoBehaviour
{
    public float speed = 5.0f;

    public bool usarDeltaTime = true;

    public KeyCode teclaArriba = KeyCode.UpArrow;
    public KeyCode teclaAbajo = KeyCode.DownArrow;
    public KeyCode teclaIzquierda = KeyCode.LeftArrow;
    public KeyCode teclaDerecha = KeyCode.RightArrow;

    void Update()
    {
        float vertical = 0.0f;
        float horizontal = 0.0f;

        if (Input.GetKey(teclaArriba)) vertical = 1.0f;
        if (Input.GetKey(teclaAbajo)) vertical = -1.0f;
        if (Input.GetKey(teclaDerecha)) horizontal = 1.0f;
        if (Input.GetKey(teclaIzquierda)) horizontal = -1.0f;

        Vector3 direccion = new Vector3(horizontal, vertical, 0.0f);
        float tiempo = usarDeltaTime ? Time.deltaTime : 1.0f;

        transform.Translate(direccion * speed * tiempo, Space.World);
    }
}
