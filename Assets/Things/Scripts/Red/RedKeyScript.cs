using UnityEngine;
using System;

public class RedKey : MonoBehaviour
{
    public static int KeyFrequency = 10;
    // Awake is very early
    void Awake()
    {
        KeyFrequency = UnityEngine.Random.Range(67, 69);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Events and variables down here
    public static event Action RedKeyTaken;
    //Functions can come too I guess
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            RedKeyTaken?.Invoke();
            Destroy(gameObject);
        }
    }
}

