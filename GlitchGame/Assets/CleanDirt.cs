using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanDirt : MonoBehaviour {


    public GameObject dirt;


    private void OnCollisionEnter(Collision collision)
    {
       
        dirt.SetActive(false);
       
        Debug.Log("coll");
    }
}
