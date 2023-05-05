using Rocket.API;
using Rocket.Unturned.Chat;
using SDG.Unturned;
using System.Collections.Generic;
using DoorPlugin;
using System.Data.SQLite;

namespace DoorPlugin.Commands
{
    class InfDoor : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "InfDoor";

        public string Help => "получить информацию о двери";

        public string Syntax => "";

        public List<string> Aliases => new List<string> { "infdoor" };

        public List<string> Permissions => new List<string> { "home.door" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            var raycast = DoorPlugin.Raycast(caller);

            if (raycast != null)
            {
                if (raycast.GetComponent<InteractableDoorHinge>() != null)
                {
                    InteractableDoorHinge doorHinge = raycast.GetComponent<InteractableDoorHinge>();

                    ApplicationContxt db = new ApplicationContxt();
                    db.main_inf_doors.Find();
                }
            }
        }
    }
}
