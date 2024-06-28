using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleOutput : MonoBehaviour
{
    public Text versionTxt;
    public Text packagesTxt;
    

    void Start()
    {
        versionTxt.text = "远端资源版本为" + AssetManagerRuntime.Instance.RemoteAssetVersion;

        packagesTxt.text = "Packages下载完成" + Path.Combine(AssetManagerRuntime.Instance.DownloadPath,
            AssetManagerRuntime.Instance.RemoteAssetVersion.ToString(), "AllPackages");

    }


    public static ConsoleOutput instance;
    public static Text packageTxt; 
    private List<string> logs = new List<string>();
    private int maxLogLines = 50; // 设置最大行数

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void Log(string message)
    {
        instance.logs.Add(message);
        if (instance.logs.Count > instance.maxLogLines)
        {
            instance.logs.RemoveAt(0);
        }
        instance.UpdateLogText();
    }

    void UpdateLogText()
    {
        string logString = "";
        for (int i = 0; i < logs.Count; i++)
        {
            logString += logs[i] + "\n";
        }
        packageTxt.text = logString;
    }

}




