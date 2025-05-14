using UnityEngine;

public class Test : MonoBehaviour
{
    void Update()
    {
        // Para el clic izquierdo del mouse
        if (Input.GetMouseButtonDown(0)) // 0 es el botón izquierdo, 1 el derecho, 2 el central
        {
            Debug.Log("¡Clic IZQUIERDO del mouse detectado por Input.GetMouseButtonDown!");
        }

        // Para una tecla específica, por ejemplo, la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("¡Tecla ESPACIO detectada por Input.GetKeyDown!");
        }

        // Si quieres probar una tecla que podrías estar usando para "seleccionar" en tu simulación
        if (Input.GetKeyDown(KeyCode.E)) // Cambia KeyCode.E a la tecla que uses
        {
            Debug.Log("¡Tecla E detectada por Input.GetKeyDown!");
        }
    }
}
