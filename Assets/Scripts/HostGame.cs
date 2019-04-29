using UnityEngine;
using UnityEngine.Networking;

public class HostGame : MonoBehaviour {

	[SerializeField]
	private uint roomSize = 2;

	private string roomName;

	private NetworkManager networkManager;

	public GameObject warning;

	void Start ()
	{
		warning.SetActive(true);
		networkManager = NetworkManager.singleton;
		if (networkManager.matchMaker == null)
		{
			networkManager.StartMatchMaker();
		}
	}

	public void SetRoomName (string _name)
	{
		roomName = _name;
	}

	public void CreateRoom ()
	{
		if (roomName != "" && roomName != null)
		{
			Debug.Log("Creating Room: " + roomName + " with room for " + roomSize + " players.");
			networkManager.matchMaker.CreateMatch(roomName, roomSize, true, "", "", "", 0, 0, networkManager.OnMatchCreate);
		}else{Debug.Log("falta nombre wey");}
	}

	public void GotTheWarning(){
		warning.SetActive(false);
	}

}
