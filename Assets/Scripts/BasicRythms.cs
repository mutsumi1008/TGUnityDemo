using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRythms : MonoBehaviour
{
    public TGUnity TGC;
    GameObject Del, The, lAl, hAl, lBe, hBe, lGa, hGa;
    Material mDelta, mTheta, mAlpLow, mAlpHigh, mBetaLow, mBetaHigh, mGammaLow, mGammaHigh;
    Rigidbody rDel, rThe, rlAl, rhAl, rlBe, rhBe, rlGa, rhGa;

    private int DelMax = 0, TheMax = 0, lAlMax = 0, hAlMax = 0, lBeMax = 0, hBeMax = 0, lGaMax = 0, hGaMax = 0;
    private int vDel = 0, vThe = 0, vlAl = 0, vhAl = 0, vlBe = 0, vhBe = 0, vlGa = 0, vhGa = 0;
    private float nDel = 0, nThe = 0, nlAl = 0, nhAl = 0, nlBe = 0, nhBe = 0, nlGa = 0, nhGa = 0;
    private float ppos = 5.5f;
    private int mmas = 200;
    private int shrinkRate = 30;
    private int WaitBRtime = 15;

    private float bRate =4.0f;
    private float scMin = 1.0f;
    // Start is called before the first frame update
    void Start()
    {


        mDelta = Resources.Load("mDelta", typeof(Material)) as Material;
        mTheta = Resources.Load("mTheta", typeof(Material)) as Material;
        mAlpLow = Resources.Load("mAlLow", typeof(Material)) as Material;
        mAlpHigh = Resources.Load("mAlHigh", typeof(Material)) as Material;
        mBetaLow = Resources.Load("mBetaLow", typeof(Material)) as Material;
        mBetaHigh = Resources.Load("mBetaHigh", typeof(Material)) as Material;
        mGammaLow = Resources.Load("mGammaLow", typeof(Material)) as Material;
        mGammaHigh = Resources.Load("mGammaHigh", typeof(Material)) as Material;

        Del = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Del.name = "Del";
        Del.transform.position = new Vector3(ppos, 3, ppos);
        rDel = Del.AddComponent<Rigidbody>();
        rDel.mass = mmas;
        Del.GetComponent<Renderer>().material = mDelta;

        The = GameObject.CreatePrimitive(PrimitiveType.Cube);
        The.name = "The";
        The.transform.position = new Vector3(0, 3, ppos);
        rThe = The.AddComponent<Rigidbody>();
        rThe.mass = mmas;
        The.GetComponent<Renderer>().material = mTheta;

        lAl = GameObject.CreatePrimitive(PrimitiveType.Cube);
        lAl.name = "lAl";
        lAl.transform.position = new Vector3(-ppos, 3, ppos);
        rlAl = lAl.AddComponent<Rigidbody>();
        rlAl.mass = mmas;
        lAl.GetComponent<Renderer>().material = mAlpLow;

        hAl = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hAl.name = "hAl";
        hAl.transform.position = new Vector3(-ppos, 3, 0);
        rhAl = hAl.AddComponent<Rigidbody>();
        rhAl.mass = mmas;
        hAl.GetComponent<Renderer>().material = mAlpHigh;

        lBe = GameObject.CreatePrimitive(PrimitiveType.Cube);
        lBe.name = "lBe";
        lBe.transform.position = new Vector3(-ppos, 3, -ppos);
        rlBe = lBe.AddComponent<Rigidbody>();
        rlBe.mass = mmas;
        lBe.GetComponent<Renderer>().material = mBetaLow;

        hBe = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hBe.name = "hBe";
        hBe.transform.position = new Vector3(0, 3, -ppos);
        rhBe = hBe.AddComponent<Rigidbody>();
        rhBe.mass = mmas;
        hBe.GetComponent<Renderer>().material = mBetaHigh;

        lGa = GameObject.CreatePrimitive(PrimitiveType.Cube);
        lGa.name = "lGa";
        lGa.transform.position = new Vector3(ppos, 3, -ppos);
        rlGa = lGa.AddComponent<Rigidbody>();
        rlGa.mass = mmas;
        lGa.GetComponent<Renderer>().material = mGammaLow;

        hGa = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hGa.name = "hGa";
        hGa.transform.position = new Vector3(ppos, 3, 0);
        rhGa = hGa.AddComponent<Rigidbody>();
        rhGa.mass = mmas;
        hGa.GetComponent<Renderer>().material = mGammaHigh;
    }

    // Update is called once per frame
    void Update()
    {
        if (vDel != TGC.tgd.eegPower.delta) { vDel = TGC.tgd.eegPower.delta; }
        if (vThe != TGC.tgd.eegPower.theta) { vThe = TGC.tgd.eegPower.theta; }
        if (vlAl != TGC.tgd.eegPower.lowAlpha) { vlAl = TGC.tgd.eegPower.lowAlpha; }
        if (vhAl != TGC.tgd.eegPower.highAlpha) { vhAl = TGC.tgd.eegPower.highAlpha; }
        if (vlBe != TGC.tgd.eegPower.lowBeta) { vlBe = TGC.tgd.eegPower.lowBeta; }
        if (vhBe != TGC.tgd.eegPower.highBeta) { vhBe = TGC.tgd.eegPower.highBeta; }
        if (vlGa != TGC.tgd.eegPower.lowGamma) { vlGa = TGC.tgd.eegPower.lowGamma; }
        if (vhGa != TGC.tgd.eegPower.highGamma) { vhGa = TGC.tgd.eegPower.highGamma; }

        if (vDel > DelMax) { DelMax = vDel; }
        if (vThe > TheMax) { TheMax = vThe; }
        if (vlAl > lAlMax) { lAlMax = vlAl; }
        if (vhAl > hAlMax) { hAlMax = vhAl; }
        if (vlAl > lAlMax) { lAlMax = vlAl; }
        if (vhAl > hAlMax) { hAlMax = vhAl; }
        if (vlBe > lBeMax) { lBeMax = vlBe; }
        if (vhBe > hBeMax) { hBeMax = vhBe; }
        if (vlGa > lGaMax) { lGaMax = vlGa; }
        if (vhGa > hGaMax) { hGaMax = vhGa; }


        if (Time.time > WaitBRtime)
        {

            nThe = (nThe * (shrinkRate - 1) + vThe) / shrinkRate;
            rThe.transform.localScale = new Vector3(nThe * bRate / TheMax + scMin, nThe * bRate / TheMax + scMin, nThe * bRate / TheMax + scMin);
            nDel = (nDel * (shrinkRate - 1) + vDel) / shrinkRate;
            rDel.transform.localScale = new Vector3(nDel * bRate / DelMax + scMin, nDel * bRate / DelMax + scMin, nDel * bRate / DelMax + scMin);
            nlAl = (nlAl * (shrinkRate - 1) + vlAl) / shrinkRate;
            rlAl.transform.localScale = new Vector3(nlAl * bRate / lAlMax + scMin, nlAl * bRate / lAlMax + scMin, nlAl * bRate / lAlMax + scMin);
            nhAl = (nhAl * (shrinkRate - 1) + vhAl) / shrinkRate;
            rhAl.transform.localScale = new Vector3(nhAl * bRate / hAlMax + scMin, nhAl * bRate / hAlMax + scMin, nhAl * bRate / hAlMax + scMin);
            nlBe = (nlBe * (shrinkRate - 1) + vlBe) / shrinkRate;
            rlBe.transform.localScale = new Vector3(nlBe * bRate / lBeMax + scMin, nlBe * bRate / lBeMax + scMin, nlBe * bRate / lBeMax + scMin);
            nhBe = (nhBe * (shrinkRate - 1) + vhBe) / shrinkRate;
            rhBe.transform.localScale = new Vector3(nhBe * bRate / hBeMax + scMin, nhBe * bRate / hBeMax + scMin, nhBe * bRate / hBeMax + scMin);
            nlGa = (nlGa * (shrinkRate - 1) + vlGa) / shrinkRate;
            rlGa.transform.localScale = new Vector3(nlGa * bRate / lGaMax + scMin, nlGa * bRate / lGaMax + scMin, nlGa * bRate / lGaMax + scMin);
            nhGa = (nhGa * (shrinkRate - 1) + vhGa) / shrinkRate;
            rhGa.transform.localScale = new Vector3(nhGa * bRate / hGaMax + scMin, nhGa * bRate / hGaMax + scMin, nhGa * bRate / hGaMax + scMin);
        }
    }
}
