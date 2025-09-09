using Unity.VisualScripting;
using UnityEngine;

public class Fireball : MonoBehaviour
{


    public GameObject projectile;
    public float LaunchVelocity = 750f;





    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject Launchedobject = Instantiate(projectile, transform.position, transform.rotation);
            Launchedobject.GetComponent<Rigidbody>(). AddRelativeForce(new Vector3(0, LaunchVelocity, 0));
        }
    }
}
    
