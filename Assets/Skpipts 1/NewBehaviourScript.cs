using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int a, s, d, f, g;
    
    void Start(){
        Debug.Log("Приве мир!!!");
    }

    // Update is called once per frame
    void Update(){
        Debug.Log("ведите первое значение");
        Debug.Log("Дебуг ведите второе значение");
        Debug.Log("Ведите третье значение");
        Debug.Log("Ведите пятое значение");
        Debug.Log("ведите шестое значение");
        Debug.Log(a + s + d + f + g);
    }
}
