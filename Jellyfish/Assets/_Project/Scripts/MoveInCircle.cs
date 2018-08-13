using Liminal.SDK.Core;
using UnityEngine;

public class MoveInCircle : MonoBehaviour {
    public GameObject Jellyfish;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        OrbitAround();
	}

    void OrbitAround()
    {
        transform.RotateAround (Jellyfish.transform.position, Vector3.up, speed * Time.deltaTime);

    }

}

