using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownloadScene : MonoBehaviour
{
    public Button DownloadBtn;//���س�����ť

    void Start()
    {
        DownloadBtn.onClick.AddListener(Download);

    }

    void Download()
    {
        
        Debug.Log("���ذ�ť����");
    }
}

