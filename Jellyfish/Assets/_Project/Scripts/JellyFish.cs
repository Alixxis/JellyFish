using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JellyFish : MonoBehaviour
{
    public GameObject scene;
    public Renderer m_MeshRenderer;
    private Material m_Material;
    public static Transform mSelectedSpawnPoint;
    private Collider _collider;
    private Camera cam;
    void Awake()
    {
        m_Material = m_MeshRenderer.material;
        //Set the main spawn point
        cam = Camera.main;
        _collider = GetComponent<Collider>();
    }

    void Update()
    {
        transform.LookAt(cam.transform);
    }

    //Pointer or Gaze clicked the jelly fish
    public void OnTriggerEnter(Collider collider)
    {
        AppManager.Instance.OnJellyFishCreated(this, transform.position, transform.rotation,scene.transform);
    }

    public void ChangeColor(Color color)
    {
        m_Material.color = color;
    }
}
