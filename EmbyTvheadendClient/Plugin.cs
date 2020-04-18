using System.Collections.Generic;
using System.IO;
using EmbyTvheadendClient.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace EmbyTvheadendClient
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages, IHasThumbImage
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public ImageFormat ThumbImageFormat
        {
            get
            {
                return ImageFormat.Png;
            }
        }

        public override string Name
        {
            get
            {
                return "EmbyTvheadendClient";
            }    
        }

        public override string Description
        {
            get
            {
                return "Live TV streaming client for Tvheadend instances, using HTSP as its primary protocol";
            }
        }

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = this.Name,
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.configPage.html"
                }
            };
        }

        public Stream GetThumbImage()
        {
            var type = GetType();
            return type.Assembly.GetManifestResourceStream(type.Namespace + ".Images.Plugin.png");
        }

        public static Plugin Instance { get; private set; }
    }
}