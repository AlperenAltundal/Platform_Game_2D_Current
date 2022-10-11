using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperLinks : MonoBehaviour
{
    public void OpenDiscord()
    {
        Application.OpenURL("https://discord.gg/hTnyhsVMMB");
    }

    public void OpenLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/ahmet-alperen-altundal-b26737236/");
    }

    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/KEKSPEREN");
    }

    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
}
