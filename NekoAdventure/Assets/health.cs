using UnityEngine;

public class health : MonoBehaviour




{
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int HowManyTillDeath = 5;


    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
        
    {
       
        if (col.gameObject.tag =="fireball")
       {
        HowManyTillDeath = HowManyTillDeath -1;
       {
        if (HowManyTillDeath <=0);
       }
         Destroy(gameObject);
        }
        
    
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
