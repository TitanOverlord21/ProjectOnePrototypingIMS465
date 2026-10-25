using UnityEngine;

public class PrimaryCube : PowerUp
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpinSpeed = .1f;
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    //inherited function
    protected override void GoAway(Collider other){
        base.GoAway(other);
    }
    protected override void Spin(){
        base.Spin();
    }

}
