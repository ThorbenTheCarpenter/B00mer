using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDoor : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool rightDoorOpen;
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
       rightDoorOpen = !rightDoorOpen;
       door.GetComponent<Animator>().SetBool("IsRightOpen", rightDoorOpen);  
    }
}


