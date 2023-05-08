using UnityEngine;
using System.Collections;
using Mirror;

namespace Player {
  public class FlashlightExample : MonoBehaviour {
      public bool FlashlightActive;
      public GameObject light;

      // Update is called once per frame
      void Update () {
          if(Input.GetKeyDown(Keycode.T)
          {
          
          }
      }
      
      [Command]
      void CMD_ToggleLight()
      {
        RPC_ToggleLight();
      }
      
      void RPC_ToggleLight()
      {
          if(FlashlightActive = true)
          {
              FlashlightActive = false;
              light.SetActive(FlashlightActive);
              Debug.Log($"Flashlight state has been set to {FlashlightActive}")
          }
          else
          {
              FlashlightActive = true;
              light.SetActive(FlashlightActive);
              Debug.Log($"Flashlight state has been set to {FlashlightActive}")
          }
      }
  }
}
