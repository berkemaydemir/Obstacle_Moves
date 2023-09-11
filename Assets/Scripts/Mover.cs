using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the Game");
        Debug.Log("Move your player with wasd or arrow keys");
        Debug.Log("Dont hit the obstacles!");

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);

    }


}
