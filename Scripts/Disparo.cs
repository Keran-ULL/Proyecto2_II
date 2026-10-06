using UnityEngine;

public class Disparo : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("¡Disparo!");
        }
    }
}
