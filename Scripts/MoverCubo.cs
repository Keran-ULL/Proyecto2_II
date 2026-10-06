using UnityEngine;

public class MoverCubo : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1.0f, 0.0f, 0.0f);
    public float speed = 2.0f;
    public Space sistemaReferencia = Space.Self;

    void Update()
    {
        float factor = speed * Time.deltaTime;
        transform.Translate(moveDirection.x * factor,
                            moveDirection.y * factor,
                            moveDirection.z * factor,
                            sistemaReferencia);
    }
}
