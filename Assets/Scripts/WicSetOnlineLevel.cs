using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
[RequireComponent(typeof(Button))]
public class WicSetOnlineLevel : MonoBehaviour {
    public string levelScene;
    public GameObject OController;
    private Button _btn;
    public void Start()
    {
        _btn = GetComponent<Button>();
        _btn.onClick.AddListener(SetOnlineLevel);
    }
    public void SetOnlineLevel()
    {
        WicNetManager.singleton.onlineScene = levelScene;
        WicNetManager.singleton.playerPrefab = OController;

    }
}
