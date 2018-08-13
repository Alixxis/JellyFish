using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeperationTest : MonoBehaviour
{
    void OnEnable()
    {

    }

    public void ComputeSeperation(Transform targetA, Transform targetB, float minRange)
    {
        //Check distance
        var dist = Vector3.Distance(targetB.position, targetA.position);

        if (dist <= minRange)
        {
            //Spawn by dir

            //Get Direction to TargetB from TargetA
            var dir = targetB.position - targetA.position;

            //Normalize it so it's not above 1
            dir.Normalize();

            //Push the target away from the jelly --- This will need to be animated afterwards
            targetB.position += dir * minRange;
        }
    }
}
