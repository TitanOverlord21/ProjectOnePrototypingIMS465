using UnityEngine;
using System;

public class EmptyMachineScript : MonoBehaviour
{
    private bool Fillable = false;
    private bool PlayerNear = false;
    private float NumberFilled = 0f;
    private Vector3 InSlotPosition;
    private Quaternion InSlotRotation;

    [SerializeField] public GameObject GoalObject;

    public static event Action Filled;

    void Start(){
        InSlotPosition = transform.position + new Vector3 (0f,0.58f,0f);
        InSlotRotation = transform.rotation * Quaternion.Euler(90f, 0f, -60f);
    }
    private void OnEnable()
    {
        GoalScript.GoalReached += Open;//listening
        EmptyMachineScript.Filled += Close;
    }
    private void OnDisable()
    {
        GoalScript.GoalReached -= Open;//done listening
        EmptyMachineScript.Filled -= Close;
    }
    private void Open(){
       Fillable = true;
    }
    private void Close(){
        Fillable = false;
        NumberFilled += 1f;
        if (NumberFilled >= 3f){
            Debug.Log ("The Energy has been restored");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            PlayerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")){
            PlayerNear = false;
        }
    }

    private void Update(){
    if (PlayerNear == true && Fillable == true){
        if (Input.GetKeyDown(KeyCode.E)){
            Fill();
        };
    };
    }

    // The important one that actually does stuff
    private void Fill(){
        // Debug.Log("Time to fill");
        Instantiate(GoalObject, InSlotPosition, InSlotRotation);
        Filled?.Invoke();
    }
}
