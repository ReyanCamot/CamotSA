using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamotIPT.CamotFramework.Models;
using CamotIPT.CamotFramework.Queries;
using CamotIPT.CamotFramework.DTOs;

namespace CamotIPT.CamotFramework.Queries
{
    public class GetAllYouTubeViewersQuery : IGetAllYouTubeViewersQuery
    {
        private readonly YouTubeViewersDbContextFactory _contextFactory;

        public GetAllYouTubeViewersQuery(YouTubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<YouTubeViewer>> Execute()
        {
            using (YouTubeViewersDbContext context = _contextFactory.Create())
            {
                IEnumerable<YouTubeViewerDto> youTubeViewerDtos = await context.YouTubeViewers.ToListAsync();

                return youTubeViewerDtos.Select(y => new YouTubeViewer(y.Id, y.Username, y.IsSubscribed, y.IsMember));
            }
        }
    }
}
