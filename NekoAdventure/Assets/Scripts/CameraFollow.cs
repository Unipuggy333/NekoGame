using UnityEngine;
using System.Collections;
        
public class CameraFollow : MonoBehaviour 
{
    Transform playerTransform;
        	
    public Vector3 cameraOrientationVector = new Vector3 (0, 2.5f, -4.5f);
        	

    void Start () 
    {
        playerTransform = GameObject.Find ("Player").transform;
    }
                
    void LateUpdate () 
    {
        transform.position = playerTransform.position + cameraOrientationVector;
    }
}
