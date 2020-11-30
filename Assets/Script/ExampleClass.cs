using System.Text;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{

    public float f1;
    public int i1;
    public bool b1;
    public string s1;

    public HingeJoint HJ;
    public SpriteRenderer SR;
    public GameObject GO;
    public AudioSource AS;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //steuert mass sacle von Hinge Joint
        f1 = 3.3f;
        HJ.massScale = f1;

        //steuert Order in Layer bei Sprite Renderer 
        i1 = 3;
        SR.sortingOrder = i1;

        //Ändert Namen des GamebObjects
        s1 = "Übung";
        GO.name = s1;

        //bool steuert Loop der Audio Source
        b1 = true;
        AS.loop = b1;
    }
}
