using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JellyFish : MonoBehaviour, IPointerClickHandler
{
    public GameObject scene;
    public Renderer m_MeshRenderer;
    private Material m_Material;
    public static Transform mSelectedSpawnPoint;
    private Camera cam;
    void Awake()
    {
        m_Material = m_MeshRenderer.material;
        //Set the main spawn point
        cam = Camera.main;
    }

    void Update()
    {
        transform.LookAt(cam.transform);
    }

    //Pointer or Gaze clicked the jelly fish
    public void OnPointerClick(PointerEventData eventData)
    {
        AppManager.Instance.OnJellyFishCreated(this, transform.position, transform.rotation,scene.transform);
    }

    public void ChangeColor(Color color)
    {
        m_Material.color = color;
    }
}
