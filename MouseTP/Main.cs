using MelonLoader;
using UnityEngine;

namespace MouseTP
{
    public static class BuildInfo
    {
        public const string Name = "Mouse Teleport"; // Name of the Mod.
        public const string Author = "404#0004"; // Author of the Mod.
        public const string Company = "I am not a company -Kappa-"; // Company that made the Mod.
        public const string Version = "1.0.0"; // Version of the Mod.
        public const string DownloadLink = "https://github.com/l-404-l/Mouse-Teleport/releases"; // Download Link for the Mod.
    }
    public class Main : MelonMod
    {
        public override void OnUpdate()
        {
            if (RoomManagerBase.field_Internal_Static_ApiWorld_0 == null ||
                RoomManagerBase.field_Internal_Static_ApiWorldInstance_0 == null)
                return;
             
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Mouse0))
            {
                var r = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                if (Physics.Raycast(r, out RaycastHit raycastHit))
                {
                    VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position = raycastHit.point;
                }
            }
        }
    }
}
