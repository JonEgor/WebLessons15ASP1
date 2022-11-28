using Microsoft.Extensions.Options;

namespace WebLessons15ASP1
{
    public class ServiceMeeting
    {
        private readonly MeetingSettings _settings;
        public ServiceMeeting(IOptions<MeetingSettings> options)
        {
            _settings = options.Value;
        }

        public string GetSettings()
        {
            return $"MaxPeople:{_settings.MaxPeople} , TimeMeetingMin {_settings.TimeMeetingMin}";
        }
    }
}
