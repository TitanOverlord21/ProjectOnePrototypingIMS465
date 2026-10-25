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
            CharacterController controller = other.GetComponent<CharacterController>();//Note to self that ai CONCEPTUALLY wrote this line and I copy pasted it in the right place.
            controller.enabled = false;
            other.transform.position = new Vector3(-30.704f,0f,72.4399f);
            other.transform.eulerAngles = new Vector3(0f,329.579f,0f);

            // Debug.Log("hit");
            controller.enabled = true;
            Destroy(gameObject);
        }}
}
