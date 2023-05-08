using UnityEngine;
using System.Collections;
using Mirror;

namespace Player {
  public class FlashlightExample : NetworkBehaviour {
  
      //Variables
      public bool FlashlightActive;
      public GameObject light;
      
      // Update is called once per frame
      void Update () {
          //Only do this if on local player
          if(!isLocalPlayer) {return;}
      
          //if Pressing T, Call funtion.
          if(Input.GetKeyDown(Keycode.T)
          {
            CMD_ToggleLight();
          }
      }
      
      //tell server to run RPC_ToggleLight;
      [Command]
      void CMD_ToggleLight()
      {
        RPC_ToggleLight();
      }
      
      //server tells all clients to toggle the players light.
      [ClientRPC]
      void RPC_ToggleLight()
      {
          if(FlashlightActive = true)
          { //if flashlight is on turn it off
              FlashlightActive = false;
              light.SetActive(FlashlightActive);
              Debug.Log($"Flashlight state has been set to {FlashlightActive}")
          }
          else
          {
          //if flashlight is off, turn it on
              FlashlightActive = true;
              light.SetActive(FlashlightActive);
              Debug.Log($"Flashlight state has been set to {FlashlightActive}")
          }
      }
  }
}
