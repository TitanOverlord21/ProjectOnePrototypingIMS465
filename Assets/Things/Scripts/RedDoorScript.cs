using UnityEngine;

public class RedDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
