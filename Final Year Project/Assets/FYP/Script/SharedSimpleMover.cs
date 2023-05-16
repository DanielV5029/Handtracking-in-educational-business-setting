using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SharedSimpleMover : MonoBehaviourPunCallbacks
{
    private bool joined;
    private bool owner;
    public override void OnJoinedRoom()
    {
        joined = true;
        if (this.photonView.Owner == null && PhotonNetwork.LocalPlayer.IsMasterClient)
            TakeOver();
    }

    void Update()
    {
        if (!joined)
            return;
        if (Input.GetKeyDown(KeyCode.X) && !owner)
            TakeOver();
        if (owner)
            transform.Translate(10 * new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * Time.deltaTime);
    }

    private void TakeOver()
    {
        this.photonView.TransferOwnership(PhotonNetwork.LocalPlayer);
    }

    private void LateUpdate()
    {
        if (!joined)
            return;
        owner = this.photonView.Owner != null & this.photonView.Owner.ActorNumber == PhotonNetwork.LocalPlayer.ActorNumber;
    }
}
