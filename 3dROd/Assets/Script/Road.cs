using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public Car CloneTarget = null;
    public Transform GenerationPos = null;
    public int GenerationPersent = 50;

    public float CloneDelaySec = 2f;

    protected float NextSecToClone = 0;

     void Update()
    {
        float currSec=Time.time;
        if (NextSecToClone <= Time.time)
        {
            CloneCar();

            NextSecToClone = Time.time + CloneDelaySec;
        }
    }

    void CloneCar()
    {
        Transform clonepos = GenerationPos;
        Vector3 offsetpos = clonepos.position;
        offsetpos.y = 1f;

        GameObject cloneobj=GameObject.Instantiate(CloneTarget.gameObject, offsetpos, GenerationPos.rotation,this.transform);

        cloneobj.SetActive(true);
    }


}
