using UnityEngine;

public class movemnt : MonoBehaviour
{ 
     public float speed = .1f;
     public float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * speed;

        if (moveDirection != Vector3.zero)
        {
            transform.forward = moveDirection;
        }
    }
}
