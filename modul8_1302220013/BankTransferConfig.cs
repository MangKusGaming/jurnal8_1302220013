using System.Text.Json;


public class BankTransferConfig
{
    private const string configFile = "bank_transfer_config.json";
    private JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
    {
        WriteIndented = true
    };
    private ConfigData configData;

    public BankTransferConfig()
    {
        if (File.Exists(configFile))
        {
            string configText = File.ReadAllText(configFile);
            configData = JsonSerializer.Deserialize<ConfigData>(configText);
        }
        else
        {
             configData = new ConfigData();
             SimpanPerubahan();
        }
    }

    public string Lang
    {
        get { return configData.Lang; }
        set { configData.Lang = value; }
    }

    public TransferConfig Transfer
    {
        get { return configData.Transfer; }
    }

    public string[] Methods
    {
        get { return configData.Methods; }
    }

    public ConfirmationConfig Confirmation
    {
        get { return configData.Confirmation; }
    }

    public void SimpanPerubahan()
    {
        string json = JsonSerializer.Serialize(configData, serializerOptions);
        File.WriteAllText(configFile, json);
    }

    public class ConfigData
    {
        public string Lang { get; set; }
        public TransferConfig Transfer { get; set; }
        public string[] Methods { get; set; }
        public ConfirmationConfig Confirmation { get; set; }
    }

    public class TransferConfig
    {
        public int Threshold { get; set; }
        public int LowFee { get; set; }
        public int HighFee { get; set; }
    }

    public class ConfirmationConfig
    {
        public string En { get; set; }
        public string Id { get; set; }
    }

}