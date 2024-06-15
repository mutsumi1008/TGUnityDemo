using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSetup : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        Material newMat = Resources.Load("GroundSurface", typeof(Material)) as Material;

        GameObject wallWest = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wallWest.name = "wallWest";
        wallWest.transform.position = new Vector3(-10, 0.5f, 0);
        wallWest.transform.localScale= new Vector3(1, 1, 20);
        wallWest.GetComponent<Renderer>().material = newMat;
        wallWest.transform.parent = this.gameObject.transform;

        GameObject wallEast = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wallEast.name = "wallEast";
        wallEast.transform.position = new Vector3(10, 0.5f, 0);
        wallEast.transform.localScale = new Vector3(1, 1, 20);
        wallEast.GetComponent<Renderer>().material = newMat;
        wallEast.transform.parent = this.gameObject.transform;

        GameObject wallNorth = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wallNorth.name = "wallNorth";
        wallNorth.transform.position = new Vector3(0, 0.5f, 10);
        wallNorth.transform.localScale = new Vector3(20, 1, 1);
        wallNorth.GetComponent<Renderer>().material = newMat;
        wallNorth.transform.parent = this.gameObject.transform;

        GameObject wallSouth = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wallSouth.name = "wallSouth";
        wallSouth.transform.position = new Vector3(0, 0.5f, -10);
        wallSouth.transform.localScale = new Vector3(20, 1, 1);
        wallSouth.GetComponent<Renderer>().material = newMat;
        wallSouth.transform.parent = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}