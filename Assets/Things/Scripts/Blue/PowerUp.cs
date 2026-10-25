using UnityEngine;

public class PowerUp : MonoBehaviour
{
   protected float x = 1f;
   protected float y = 1f;
   protected float z = 1f;
   protected float SpinSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spin();
        
    }
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            GoAway(other);
        }
    }
    protected virtual void GoAway (Collider other){
        Destroy(gameObject);
    }

    protected virtual void Spin(){
        x += SpinSpeed;
        y += SpinSpeed;
        z += SpinSpeed;
        this.transform.eulerAngles = new Vector3(x,y,z);
    }
    
}
