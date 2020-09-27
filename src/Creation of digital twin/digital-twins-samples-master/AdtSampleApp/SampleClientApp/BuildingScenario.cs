using System.Threading.Tasks;

namespace SampleClientApp
{
    public class BuildingScenario
    {
        private readonly CommandLoop cl;
        public BuildingScenario(CommandLoop cl)
        {
            this.cl = cl;
        }

        public async Task InitBuilding()
        {
            Log.Alert($"Deleting all twins...");
            await cl.DeleteAllTwinsAsync();
            Log.Out($"Creating 1 floor, 33 rooms and 33 thermostats...");
            await InitializeGraph();
        }

        private async Task InitializeGraph()
        {
            string[] modelsToUpload = new string[3] { "CreateModels", "ThermostatModel", "SpaceModel" };
            Log.Out($"Uploading {string.Join(", ", modelsToUpload)} models");

            await cl.CommandCreateModels(modelsToUpload);

            Log.Out($"Creating SpaceModel and Thermostat...");
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "floor1",
                    "DisplayName", "string", "Floor 1",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room101",
                    "DisplayName", "string", "Room 101",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room102",
                    "DisplayName", "string", "Room 102",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });

            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room103",
                    "DisplayName", "string", "Room 103",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room104",
                    "DisplayName", "string", "Room 104",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room105",
                    "DisplayName", "string", "Room 105",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room106",
                    "DisplayName", "string", "Room 106",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room107",
                    "DisplayName", "string", "Room 107",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room108",
                    "DisplayName", "string", "Room 108",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room109",
                    "DisplayName", "string", "Room 109",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room110",
                    "DisplayName", "string", "Room 110",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room111",
                    "DisplayName", "string", "Room 110",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room112",
                    "DisplayName", "string", "Room 112",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room113",
                    "DisplayName", "string", "Room 113",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room113",
                    "DisplayName", "string", "Room 113",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room114",
                    "DisplayName", "string", "Room 114",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room115",
                    "DisplayName", "string", "Room 115",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room116",
                    "DisplayName", "string", "Room 116",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room117",
                    "DisplayName", "string", "Room 117",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room118",
                    "DisplayName", "string", "Room 118",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room119",
                    "DisplayName", "string", "Room 119",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room120",
                    "DisplayName", "string", "Room 120",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room121",
                    "DisplayName", "string", "Room 121",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room122",
                    "DisplayName", "string", "Room 122",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room123",
                    "DisplayName", "string", "Room 123",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room124",
                    "DisplayName", "string", "Room 124",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room125",
                    "DisplayName", "string", "Room 125",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "room126",
                    "DisplayName", "string", "Room 126",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "ot2",
                    "DisplayName", "string", "OT2",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "ot1",
                    "DisplayName", "string", "OT1",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "Reception",
                    "DisplayName", "string", "Reception",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "wc",
                    "DisplayName", "string", "WC",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "waitingroom",
                    "DisplayName", "string", "Waiting Room",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "w1",
                    "DisplayName", "string", "W1",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[15]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Space;1", "w2",
                    "DisplayName", "string", "W2",
                    "Location", "string", "Puget Sound",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat101",
                    "DisplayName", "string", "Thermostat 101",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat102",
                    "DisplayName", "string", "Thermostat 102",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat103",
                    "DisplayName", "string", "Thermostat 103",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat104",
                    "DisplayName", "string", "Thermostat 104",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat105",
                    "DisplayName", "string", "Thermostat 105",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat106",
                    "DisplayName", "string", "Thermostat 106",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat107",
                    "DisplayName", "string", "Thermostat 107",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat108",
                    "DisplayName", "string", "Thermostat 108",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat109",
                    "DisplayName", "string", "Thermostat 109",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat110",
                    "DisplayName", "string", "Thermostat 110",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat111",
                    "DisplayName", "string", "Thermostat 111",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat112",
                    "DisplayName", "string", "Thermostat 112",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat113",
                    "DisplayName", "string", "Thermostat 113",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat114",
                    "DisplayName", "string", "Thermostat 114",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat115",
                    "DisplayName", "string", "Thermostat 115",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat116",
                    "DisplayName", "string", "Thermostat 116",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat117",
                    "DisplayName", "string", "Thermostat 117",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat118",
                    "DisplayName", "string", "Thermostat 118",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat119",
                    "DisplayName", "string", "Thermostat 119",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat120",
                    "DisplayName", "string", "Thermostat 120",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat121",
                    "DisplayName", "string", "Thermostat 121",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat122",
                    "DisplayName", "string", "Thermostat 122",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat123",
                    "DisplayName", "string", "Thermostat 123",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat124",
                    "DisplayName", "string", "Thermostat 124",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat125",
                    "DisplayName", "string", "Thermostat 125",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermostat126",
                    "DisplayName", "string", "Thermostat 126",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermreception",
                    "DisplayName", "string", "Thermostat Reception",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermwheelchair",
                    "DisplayName", "string", "Thermostat Wheelchair",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermw1",
                    "DisplayName", "string", "Thermostat W1",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermw2",
                    "DisplayName", "string", "Thermostat W2",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermot1",
                    "DisplayName", "string", "Thermostat OT1",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            await cl.CommandCreateDigitalTwin(new string[18]
                {
                    "CreateTwin", "dtmi:contosocom:DigitalTwins:Thermostat;1", "thermot2",
                    "DisplayName", "string", "Thermostat OT2",
                    "Location", "string", "Puget Sound",
                    "FirmwareVersion", "string", "1.3.9",
                    "Temperature", "double", "0",
                    "ComfortIndex", "double", "0"
                });
            Log.Out($"Creating edges between the Floor, Room and Thermostat");
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "floor1", "contains", "room101", "floor_to_room_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room102", "relationship0",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room103", "relationship1",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room104", "relationship2",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room105", "relationship3",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room106", "relationship4",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room107", "relationship5",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room108", "relationship6",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room109", "relationship7",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room110", "relationship8",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room111", "relationship9",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room112", "relationship10",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room113", "relationship11",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room114", "relationship12",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room115", "relationship13",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room116", "relationship14",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room117", "relationship15",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room118", "relationship16",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room119", "relationship17",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room120", "relationship18",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room121", "relationship19",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room122", "relationship20",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room123", "relationship21",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room124", "relationship22",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room125", "relationship23",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "room126", "relationship24",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "ot1", "relationship25",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "ot2", "relationship26",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "Reception", "relationship27",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "wc", "relationship28",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "waitingroom", "relationship29",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "w1", "relationship30",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
              {
                    "CreateEdge", "floor1", "contains", "w2", "relationship31",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
              });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room101", "contains", "thermostat101", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room102", "contains", "thermostat102", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room103", "contains", "thermostat103", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room104", "contains", "thermostat104", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room105", "contains", "thermostat105", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room106", "contains", "thermostat106", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room107", "contains", "thermostat107", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room108", "contains", "thermostat108", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room109", "contains", "thermostat109", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room110", "contains", "thermostat110", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room111", "contains", "thermostat111", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room112", "contains", "thermostat112", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room113", "contains", "thermostat113", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room114", "contains", "thermostat114", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room115", "contains", "thermostat115", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room116", "contains", "thermostat116", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room117", "contains", "thermostat117", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room118", "contains", "thermostat118", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room119", "contains", "thermostat119", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room120", "contains", "thermostat120", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room121", "contains", "thermostat121", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room122", "contains", "thermostat122", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room123", "contains", "thermostat124", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room124", "contains", "thermostat125", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room125", "contains", "thermostat125", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "room126", "contains", "thermostat126", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "Reception", "contains", "thermreception", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "wc", "contains", "thermwheelchair", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "w1", "contains", "thermw1", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "w2", "contains", "thermw2", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "ot1", "contains", "thermot1", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
            await cl.CommandCreateRelationship(new string[11]
                {
                    "CreateEdge", "ot2", "contains", "thermot2", "room_to_therm_edge",
                    "ownershipUser", "string", "Contoso",
                    "ownershipDepartment", "string", "Comms Division"
                });
        }
    }
}