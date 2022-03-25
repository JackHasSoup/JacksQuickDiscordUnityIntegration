using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateDiscord : MonoBehaviour
{
    public GameObject DC;
    public DiscordController DCS;
    public string StateT;
    public string imageT;

    // Start is called before the first frame update
    void Awake()
    {
        if(DC == null)
        {
            DC = GameObject.FindGameObjectWithTag("discord");
        }

        DCS = DC.GetComponent<DiscordController>();

        DCS.state = StateT;
        DCS.LI = imageT;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
