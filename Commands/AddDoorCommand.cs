using Rocket.API;
using Rocket.Unturned.Chat;
using SDG.Unturned;
using System.Collections.Generic;
using DoorPlugin;
using System.Data.SQLite;
using Rocket.Unturned.Player;
using System;

namespace DoorPlugin
{
    public class AddDoorCommand : IRocketCommand
    {

        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "AddDoor";

        public string Help => "/AddDoor адрес(можно писать любую хуйню), Государство(будет показано в качестве владельца), 1";

        public string Syntax => "";

        public List<string> Aliases => new List<string> { "adddoor", "AD" };

        public List<string> Permissions => new List<string> { "add.door" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            var raycast = DoorPlugin.Raycast(caller);
            if(raycast != null)
            {
                if (raycast.GetComponent<InteractableDoorHinge>() != null)
                {
                    InteractableDoorHinge doorHinge = raycast.GetComponent<InteractableDoorHinge>();
                    DoorPlugin.Instance.Configuration.Instance.SaveData(raycast.parent.parent, command, caller);

                    UnturnedPlayer player = (UnturnedPlayer)caller;
                    
                    Models.Main_inf_door door1 = new Models.Main_inf_door(doorHinge.GetInstanceID().ToString(), command[0], command[1], Convert.ToInt32(command[2]));
                    ApplicationContxt db = new ApplicationContxt();
                    db.main_inf_doors.Add(door1);

                    

                    InteractableDoor door = doorHinge.door;
                    bool open = !door.isOpen;
                    Interactable hinge = raycast.GetComponent<Interactable>();
                    ///door.updateToggle(open);
                    BarricadeManager.ServerSetDoorOpen(doorHinge.door, open);



                    UnturnedChat.Say(caller, "id door: " + doorHinge.GetInstanceID() + ", id player: " + player.CSteamID, UnityEngine.Color.green);
                }
                else
                {
                    UnturnedChat.Say(caller, "На дверь сомтри, чурркаш", UnityEngine.Color.red);
                }

            }   
        }
    }
}
