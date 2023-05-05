using Rocket.API;
using Rocket.Unturned.Chat;
using SDG.Unturned;
using System.Collections.Generic;

namespace DoorPlugin
{
    public class Door : IRocketCommand
    {
        public static Rocket.Unturned.Permissions.UnturnedPermissions UPerms;
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "Door";

        public string Help => "You Can Use /Door Or Just Punch The Door With Left Click";

        public string Syntax => "";

        public List<string> Aliases => new List<string> { "D", "door", "d" };

        public List<string> Permissions => new List<string> { "D.Door" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            var raycast = DoorPlugin.Raycast(caller);
            if(raycast != null)
            {
                if (raycast.GetComponent<InteractableDoorHinge>() != null)
                {
                    DoorPlugin.Instance.Execute(caller);
                }
                else
                {
                    UnturnedChat.Say(caller, DoorPlugin.Instance.Translations.Instance.Translate("NoDoor"), UnityEngine.Color.red);
                }

            }    
        }      
    }
}
