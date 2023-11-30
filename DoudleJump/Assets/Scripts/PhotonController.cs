using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;
using TMPro;
public class PhotonController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    TextMeshProUGUI debug;
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    private void Update()
    {
        debug.text = PhotonNetwork.NetworkClientState.ToString();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
    }
}
