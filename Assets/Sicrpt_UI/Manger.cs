using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Manger : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInpot;
    public TMP_InputField join_Inpot;
    
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInpot.text);
    }
    public void Join_Room()
    {
        PhotonNetwork.JoinRoom(join_Inpot.text);
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
