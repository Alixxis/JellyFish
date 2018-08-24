using UnityEngine;
using System.Collections;
using Liminal.SDK.VR;
using Liminal.SDK.VR.Input;

public class MushroomEmitter : MonoBehaviour
{
    public GameObject Emitter;
    public GameObject MushroomBullet;
    public float MushroomBullet_Up_Force;

    // Update is called once per frame
    void Update()
    {
        if (VRDevice.Device.GetButtonUp(VRButton.Primary))

            //(Input.GetKeyDown("space"))
        {
            GameObject Temporary_MushroomBullet_Handler;
            Temporary_MushroomBullet_Handler = Instantiate(MushroomBullet, Emitter.transform.position, Emitter.transform.rotation) as GameObject;

            Temporary_MushroomBullet_Handler.transform.Rotate(Vector3.forward * 0);

            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_MushroomBullet_Handler.GetComponent<Rigidbody>();

            Temporary_RigidBody.AddForce(transform.up * MushroomBullet_Up_Force);

            Destroy(Temporary_MushroomBullet_Handler, 3.0f);
        }
    }
}
