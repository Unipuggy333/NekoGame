using UnityEngine;

public class DialougeScript : MonoBehaviour
{
    public GameObject KeyBindPrompt;
    
    public GameObject DialougeStart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        KeyBindPrompt.SetActive(false);
        DialougeStart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            KeyBindPrompt.SetActive(true);
        }
    }
     void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                DialougeStart.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
         if (other.gameObject.tag == "Player")
        {
            KeyBindPrompt.SetActive(false);
        }
    }
}
