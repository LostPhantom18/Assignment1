using System.Collections;
using System.Collections.Generic;
using HappyHarvest;
using Unity.VisualScripting;
using UnityEngine;

public class ShiftToRun : MonoBehaviour
{
    public GameObject Character;
    //public GameObject playerController;
    //PlayerController playercontroller;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        //playerController = GetComponent<PlayerController>();
        Speed = Character.GetComponent<PlayerController>().Speed;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = 16;
            Debug.Log("Shift key was pressed");
        }
        else
        {
            Speed = 6;
        }
    }
}
