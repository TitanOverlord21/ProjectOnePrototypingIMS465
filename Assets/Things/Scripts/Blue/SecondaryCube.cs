using UnityEngine;

public class SecondaryCube : PowerUp
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpinSpeed = -.2f;
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    //Inherited fucntion
    protected override void GoAway(Collider other){
        base.GoAway(other);
    }

        protected override void Spin(){
        base.Spin();
    }
}
