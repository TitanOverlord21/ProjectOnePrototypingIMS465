using UnityEngine;

public class GoalScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            CharacterController controller = other.GetComponent<CharacterController>();
            controller.enabled = false;
            other.transform.position = new Vector3(0,0,-4);
            Debug.Log("hit");
            controller.enabled = true;
            Destroy(gameObject);
        }}
}
