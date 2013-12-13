using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MovieApp.Models.DB_Model;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class FeatureController : ApiController
    {
        private IUnitOfWork _unitOfWork = new UnitOfWork();

        [ResponseType(typeof(FeatureViewModel))]
        public async Task<IHttpActionResult> GetFeature(int id)
        {
            Feature feature = await _unitOfWork.FeaturesRepository().getFeature(id);
            if (feature == null)
            {
                return NotFound();
            }

            return Ok(FeatureViewModel.MapProfile(feature));
        }
        [Route("api/{Controller}/{feature_id}/Episode/{episode_id}")]
        [ResponseType(typeof(EpisodeViewModel))]
        public async Task<IHttpActionResult> GetEpisode(int feature_id, int episode_id)
        {
            Feature feature = await _unitOfWork.FeaturesRepository().getFeature(feature_id);
            if (feature == null)
            {
                return NotFound();
            }

            return Ok(EpisodeViewModel.MapProfile(feature.Episodes.Where(x=>x.episode1 == episode_id).Single()));
        }

        [Route("api/User/{user_name}/{Controller}/{feature_id}")]
        [ResponseType(typeof(EpisodeViewModel))]
        public async Task<IHttpActionResult> GetFeatureForUser(string user_name, int feature_id)
        {
            Feature feature = await _unitOfWork.FeaturesRepository().getFeature(feature_id);
            UserFeatureInfo userInfo = feature.UserFeatureInfoes.Where(x => x.AspNetUser.UserName == user_name && x.episode_id == null).Single();
            if (feature == null)
            {
                return NotFound();
            }

            return Ok(FeatureViewModel.MapUserProfile(feature, userInfo));
        }

        [Route("api/User/{user_name}")]
        [ResponseType(typeof(EpisodeViewModel))]
        public async Task<IHttpActionResult> GetAllFeatureForUser(string user_name)
        {
            AspNetUser user = await _unitOfWork.FeaturesRepository().getUser(user_name);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(FeatureViewModel.EnumerateUserProfile(user));
        }
    }
}