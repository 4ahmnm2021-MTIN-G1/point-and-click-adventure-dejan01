using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArea : MonoBehaviour
{    

    public PlayerMovement pm;
    public SpriteRenderer spriterend;
    public int orderLayer;

    public void OnMouseDown()
    {
        pm.SetNewDestination();
        Debug.Log("Click erkannt");
        spriterend.sortingOrder = orderLayer;
    }
}
