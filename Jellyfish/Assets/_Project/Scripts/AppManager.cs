using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.Core.Fader;

public class AppManager : MonoBehaviour
{
    public static AppManager Instance;

    public Transform firstJellyFish;
    public List<Transform> spawnPoints = new List<Transform>();

    public int jellyFishCount = 0;
    public int noteJellyFish1 = 2;
    public int noteJellyFish2 = 4;
    public int noteJellyFish3 = 6;
    public int noteJellyFish4 = 8;
    public int noteJellyFish5 = 10;
    public int maxJellyFish = 16;

    public Color m_FinalJellyFishColor = Color.green;

    public float minRange = 3;

    private float timeElapsed;

    [SerializeField]
    private float Fade = 0f;

    private void Awake()
    {
        Instance = this;
        firstJellyFish.transform.position = spawnPoints[0].position;
        firstJellyFish.transform.rotation = spawnPoints[0].rotation;
    }

    //This is actually a spwaner script but there's not much in the app
    public void OnJellyFishCreated(JellyFish jellyFish, Vector3 position, Quaternion rotation, Transform parent)
    {
        if (jellyFishCount < maxJellyFish)
        {
            jellyFishCount++;
            OnJellyFishCounted();

            var newJellyFish = Instantiate(jellyFish, position, rotation);
            newJellyFish.transform.parent = parent;
            newJellyFish.transform.position = spawnPoints[jellyFishCount].position;
            newJellyFish.transform.rotation = spawnPoints[jellyFishCount].rotation;

            //newJellyFish.transform.position.Set(5.42f, -5.05f, 9.33f);
        }

        if (jellyFishCount == noteJellyFish1)
        {
            OnJellyFishCounted();

            FindObjectOfType<MusicNotes>().Play("Note1");           
        }

        if (jellyFishCount == noteJellyFish2)
        {
            OnJellyFishCounted();

            FindObjectOfType<MusicNotes>().Play("Note2");
        }

        if (jellyFishCount == noteJellyFish3)
        {
            OnJellyFishCounted();

            FindObjectOfType<MusicNotes>().Play("Note3");
        }

        if (jellyFishCount == noteJellyFish4)
        {
            OnJellyFishCounted();

            FindObjectOfType<MusicNotes>().Play("Note4");
        }

        if (jellyFishCount == noteJellyFish5)
        {
            OnJellyFishCounted();

            FindObjectOfType<MusicNotes>().Play("Note5");
        }
    }


    public void OnJellyFishCounted()
    {
        if (jellyFishCount == maxJellyFish)
        {
            var jellyFishCollection = FindObjectsOfType<JellyFish>();
            foreach (var fish in jellyFishCollection)
            {
                fish.ChangeColor(m_FinalJellyFishColor);
            }
        }
    }

    public void OnJellyFishEnd()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > Fade)
        {
            var fader = ScreenFader.Instance;
            {
                float fadeDuration = 210f;
                Color fadeColor = Color.red;

                fader.FadeTo(fadeColor, fadeDuration);
            }

        }
    }


}



   


