using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownloadScene : MonoBehaviour
{
    public Button DownloadBtn;//下载场景按钮

    void Start()
    {
        DownloadBtn.onClick.AddListener(Download);

    }

    void Download()
    {
        
        Debug.Log("下载按钮按下");
    }
}

