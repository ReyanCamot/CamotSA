using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamotIPT.CamotFramework.Models;

namespace CamotIPT.CamotFramework.Commands
{
    public interface ICreateYouTubeViewerCommand
    {
        Task Execute(YouTubeViewer youTubeViewer);
    }
}
