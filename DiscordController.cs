using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{
    public Discord.Discord discord;
    public string details;
    public string state;
    public string LI;

    //Hello modder, I have left these variables public so if you make new levels you can update the status

    void Awake()
    {
        //How to edit this:
        //Step 1: Cry for hours
        //Step 2: Drink 3 cans of monster (the pink one)
        //Step 3: Wake up the next mourning with discord status code :)



        discord = new Discord.Discord(860617980207431720, (System.UInt64)Discord.CreateFlags.NoRequireDiscord);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            Details = details,
            State = state,
            Assets = {
                LargeImage = LI
            }
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res == Discord.Result.Ok)
                Debug.Log("Discord status set!");
            else
                Debug.LogError("Discord status failed");
        });

        GameObject[] objs = GameObject.FindGameObjectsWithTag("discord");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        discord.RunCallbacks();
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            Details = details,
            State = state,
            Assets = {
                LargeImage = LI
            }
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res != Discord.Result.Ok)
                Debug.LogError("Discord status failed");
        });
    }
}
