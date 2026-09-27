using UnityEngine;
using System;

public class YellowKey : MonoBehaviour
{
    // Awake is very early
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Events and variables down here
    public static event Action YellowKeyTaken;
    //Functions can come too I guess
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            YellowKeyTaken?.Invoke();
            Destroy(gameObject);
        }
    }
}

