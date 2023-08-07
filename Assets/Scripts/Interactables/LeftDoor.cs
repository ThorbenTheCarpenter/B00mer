using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoor : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool leftDoorOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Interact()
    {
       leftDoorOpen = !leftDoorOpen;
       door.GetComponent<Animator>().SetBool("IsLeftOpen", leftDoorOpen);  
    }
}

