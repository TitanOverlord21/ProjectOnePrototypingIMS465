using UnityEngine;

public class RedDoor : MonoBehaviour
{
    void Start(){
        Debug.Log(RedKey.KeyFrequency);
    }
    private void OnEnable()
    {
        RedKey.RedKeyTaken += Die;//listening
    }
    private void OnDisable()
    {
        RedKey.RedKeyTaken -= Die;//done listening
    }
    private void Die(){
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
