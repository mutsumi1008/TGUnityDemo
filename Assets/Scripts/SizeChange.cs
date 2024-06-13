using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    
    public TGUnity TGC;
    public bool consF=false;
    private float devBy = 20;
    private Rigidbody rb;

    private int shrinkRate = 60;
    private int frameRate  = 60;
    private float att=0.0f;
    private float med=0.0f;

    private float attNow= 0.0f;
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
        if( att != TGC.tgd.eSense.attention){
            att = TGC.tgd.eSense.attention;
        }
        if( med != TGC.tgd.eSense.meditation){
            med = TGC.tgd.eSense.meditation;
        }

        attNow = (attNow*(shrinkRate-1)+att)/shrinkRate;
        medNow = (medNow*(shrinkRate-1)+med)/shrinkRate;

        float attSize = attNow/devBy;
        if( attSize < 1 ){
            attSize = 1.0f;
        }
        float medSize = medNow/devBy;
        if( medSize < 1 ){
            medSize = 1.0f;
        }
        rb.transform.localScale = new Vector3(medSize, attSize, (attSize+medSize)/2.0f);
        if( consF ){
            Debug.Log( attNow +";" + att + " -- " + medNow + ";" +med);
        }
    }
}
