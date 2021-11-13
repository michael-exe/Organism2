using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SubstanceGFX : MonoBehaviour
{
    public AIPath aiPath;

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}

//2D Pathfinding https://www.youtube.com/watch?v=jvtFUfJ6CP8
