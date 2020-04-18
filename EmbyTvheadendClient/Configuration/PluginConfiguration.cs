namespace EmbyTvheadendClient.Configuration
{
    /// <summary>
    /// Configuration properties for this plugin
    /// </summary>
    public class PluginConfiguration : MediaBrowser.Model.Plugins.BasePluginConfiguration
    {
        public string RemoteHostName { get; set; }
        public int    HttpPort       { get; set; }
        public int    HtspPort       { get; set; }
        public string Username       { get; set; }
        public string Password       { get; set; }

        public PluginConfiguration()
        {
            RemoteHostName = "localhost";
            HttpPort       = 9981;
            HttpPort       = 9982;
            Username       = string.Empty;
            Password       = string.Empty;
        }
    }
}