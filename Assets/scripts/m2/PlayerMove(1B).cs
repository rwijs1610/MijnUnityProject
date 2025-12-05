using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float snelheid = 5.0f;
    void Start()
    {
        
    }

    void Update()
    {
        
        Vector3 positie = transform.position;

        
        if (Input.GetKey(KeyCode.W))
        {
            positie.y = positie.y + snelheid * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.S))
        {
            positie.y = positie.y - snelheid * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.A))
        {
            positie.x = positie.x - snelheid * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.D))
        {
            positie.x = positie.x + snelheid * Time.deltaTime; 
        }

        transform.position = positie;
    }

}
