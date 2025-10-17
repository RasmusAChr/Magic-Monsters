using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;

public class MenuScript : MonoBehaviour
{
    private string path;
    public void StartSingleplayer()
    {
        Process mProcess = new Process();
        string path = Directory.GetCurrentDirectory() + @"\PM_Singleplayer\Pocket Monster.exe";
        mProcess.StartInfo.FileName = path;
        print(path);
        mProcess.Start();
    }

    public void StartMultiplayer()
    {
        Process mProcess = new Process();
        string path = Directory.GetCurrentDirectory() + @"\PM_Multiplayer\Pocket Monster.exe";
        mProcess.StartInfo.FileName = path;
        mProcess.Start();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
