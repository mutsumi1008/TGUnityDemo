using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChangeMed : MonoBehaviour
{
    
    public TGUnity TGC;
    public bool consF=false;
    private float devBy = 20;
    private Rigidbody rb;

    private int shrinkRate = 60;
    private int frameRate  = 60;
    private float med=0.0f;

    private float medNow= 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Application.targetFrameRate = frameRate;
    }

    // Update is called once per frame
    void Update()
    {
        if( med != TGC.tgd.eSense.meditation){
            med = TGC.tgd.eSense.meditation;
        }

        medNow = (medNow*(shrinkRate-1)+med)/shrinkRate;

        float medSize = medNow/devBy;
        if( medSize < 1 ){
            medSize = 1.0f;
        }
        rb.transform.localScale = new Vector3(medSize, medSize, medSize);
        if( consF){Debug.Log(medSize);}
    }
}
