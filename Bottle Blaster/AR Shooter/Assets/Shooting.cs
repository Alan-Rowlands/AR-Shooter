using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject Explosion;
    public GameObject ARCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Shoot()
    {

        RaycastHit hit;

        if(Physics.Raycast(ARCamera.transform.position, ARCamera.transform.forward, out hit))
        {

            if(hit.transform.name == "Coke Bottle")
            {
                Destroy(hit.transform.gameObject);
                GameObject go = Instantiate(Explosion, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }

    }

}
