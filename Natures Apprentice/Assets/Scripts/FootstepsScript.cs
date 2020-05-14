using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsScript : MonoBehaviour
{
    [SerializeField]
    PlayerScript ps;
    [SerializeField]
    AudioSource asWalk;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<PlayerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ps.isMoving == true && asWalk.isPlaying == false)
        {
            asWalk.Play();
        }
    }
}
