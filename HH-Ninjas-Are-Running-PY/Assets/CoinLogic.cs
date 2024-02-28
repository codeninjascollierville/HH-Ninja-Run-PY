using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLogic : MonoBehaviour
{

    public ParticleSystem Pickup;
    public GameObject door;
    public GameObject gem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        Destroy(door);
        Destroy(gem);
    }



}
