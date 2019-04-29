using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WicNetManager : NetworkManager
{
    
    public void StartHosting()
    {
        SetPort();
        NetworkManager.singleton.StartHost();
        //base.StartHost();
    }

    public void JoinGame()
    {
        SetIpAdress();
        SetPort();
        NetworkManager.singleton.StartClient();
    }


    void SetIpAdress()
    {
        //string ipAdress = GameObject.Find("If_ipAdress").transform.Find("Text").GetComponent<Text>().text;
        string ipAdress = "localhost";
        NetworkManager.singleton.networkAddress = ipAdress;
    }

    void SetPort()
    {
    	if(NetworkManager.singleton.networkPort == null){	
    		NetworkManager.singleton.networkPort = 7777;
    	}else{
    		int ipAdressz = int.Parse(GameObject.Find("If_Port").transform.Find("Text").GetComponent<Text>().text);
    		NetworkManager.singleton.networkPort = ipAdressz;
    	}
    	
        
    }

    void OnLevelWasLoaded(int level)
    {
        if (level == 16)
        {
            //SetUpOnlineMenuButtons();
            //NetworkManager.singleton.StopHost();
        }

        if(level == 1)
        {
			NetworkManager.singleton.StopHost();
		}
        if(level >= 17 && level <= 20){
            //GameObject.Find("BTN_Esc").GetComponent<Button>().onClick.RemoveAllListeners();
            //GameObject.Find("BTN_Esc").GetComponent<Button>().onClick.AddListener(NetworkManager.singleton.StopHost);
        }
    }

    public void SetUpOnlineMenuButtons()
    {

        //GameObject.Find("btn_CreateGame").GetComponent<Button>().onClick.AddListener(StartHosting);
        //GameObject.Find("btn_JoinGame").GetComponent<Button>().onClick.AddListener(JoinGame);
    }

    public void SetUpDisconectButton()
    {
        GameObject.Find("BTN_MainMenu").GetComponent<Button>().onClick.RemoveAllListeners();
        GameObject.Find("BTN_MainMenu").GetComponent<Button>().onClick.AddListener(NetworkManager.singleton.StopHost);
    }
}
