using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magier : MonoBehaviour
{
    public string nameOfCharacter;
    public float heigth;
    public float age;
    public bool smart;
    public GameObject go;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        nameOfCharacter = "Hans";
        heigth = 1.80f;
        age = 40;
        smart = true;
       rb.useGravity = false;
       rb.mass = 80;
       go.name = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
