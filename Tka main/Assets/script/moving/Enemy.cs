using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float Rotation;
    int distance;
    Vector2 TargertPos;
    GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("main char");
    }

    // Update is called once per frame
    void Update()
    {
        Rotation = GameObject.Find("main char").GetComponent<Player_controller>().lastRotation * -1;
        TargertPos = GameObject.Find("main char").GetComponent<Transform>().position;
        distance = 
    }
}
