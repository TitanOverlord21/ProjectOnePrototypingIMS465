using UnityEngine;
using System;

public class MovingPlatformScript : MonoBehaviour
{
    [SerializeField] protected Vector3 CurrentPlace;
    [SerializeField] protected float MoveSpeed;
    [SerializeField] private float DistanceToMove;
    private float DistanceMoved = 0;
    private bool Reversing = false;
    [SerializeField] private bool MoveX = false;
    [SerializeField] private bool MoveY = false;
    [SerializeField] private bool MoveZ = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentPlace = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (DistanceMoved >= DistanceToMove){
            if (Reversing == false){
                Reversing = true;
            }
        }
        if (DistanceMoved <= 0){
            if (Reversing == true){
                Reversing = false;
            }
        }
        
    }

    protected virtual void Move(){
        if (MoveSpeed > 0 && Reversing == true){
            MoveSpeed = MoveSpeed * -1;
        }
        else if (MoveSpeed < 0 && Reversing == false){
            MoveSpeed = MoveSpeed * -1;
            
        }
        if (MoveX == true){
            CurrentPlace.x += MoveSpeed * Time.deltaTime;
            DistanceMoved += MoveSpeed * Time.deltaTime;
        }
        if (MoveY == true){
            CurrentPlace.y += MoveSpeed * Time.deltaTime;
            DistanceMoved += MoveSpeed * Time.deltaTime;
        }  
        if (MoveZ == true){
            CurrentPlace.z += MoveSpeed * Time.deltaTime;
            DistanceMoved += MoveSpeed * Time.deltaTime;
        }
        transform.position = CurrentPlace;
    }
}
