using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class kropivny : MonoBehaviour
{
    public float speed;
   
    void Start()
    {
        
    }

    
    void Update() {
        float distance = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * distance);
        
    }
}
