using CorrectifSecu_WEB_DAL.Entities;
using Newtonsoft.Json;

namespace CorrectifSecu_WEB.Tools
{
    public class SessionManager
    {
        private ISession _session;

        public SessionManager(IHttpContextAccessor accessor)
        {
            _session = accessor.HttpContext.Session;
        }

        public AppUser CurrentUser
        {
            get {
                AppUser appUser = JsonConvert.DeserializeObject<AppUser>(_session.GetString("user"));
                if (appUser is null) return null;
                return appUser; 
            }
            set { _session.SetString("user", JsonConvert.SerializeObject(value)); }
        }
    }
}
