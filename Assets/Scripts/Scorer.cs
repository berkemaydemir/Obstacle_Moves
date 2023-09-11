using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits=0;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            Debug.Log("You've bumped into a tihng this many time: " + hits++);

        }

        
        
    }
}
