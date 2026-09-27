using UnityEngine;

public class YellowDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        YellowKey.YellowKeyTaken += Die;//listening
    }
    private void OnDisable()
    {
        YellowKey.YellowKeyTaken -= Die;//done listening
    }
    private void Die(){
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
