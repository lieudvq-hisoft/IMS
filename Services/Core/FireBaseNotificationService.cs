using Microsoft.Extensions.Options;
using CorePush.Google;
using System.Text;
using Data.DataAccess;
using Data.Models;
using static Data.Models.GoogleNotification;
using FcmResponse = Data.Models.FcmResponse;
using System.Runtime;
using DocumentFormat.OpenXml.InkML;

namespace Services.Core
{
    public interface IFireBaseNotificationService
    {
        Task<HttpResponseMessage> SendNotification(NotificationFcmModel notificationModel);
    }
    public class FireBaseNotificationService : IFireBaseNotificationService
    {
        private readonly FcmNotificationSetting _fcmNotificationSetting;
        private readonly string fcmServerKey;
        private readonly HttpClient httpClient;
        public FireBaseNotificationService(IOptions<FcmNotificationSetting> settings)
        {
            _fcmNotificationSetting = settings.Value;
            fcmServerKey = fcmServerKey = _fcmNotificationSetting.ServerKey;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://fcm.googleapis.com/fcm/");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"key={fcmServerKey}");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
        }

        public async Task<HttpResponseMessage> SendNotification(NotificationFcmModel notificationModel)
        {
            {
                HttpResponseMessage result = new HttpResponseMessage();
                try
                {
                    FcmSettings settings = new FcmSettings()
                    {
                        SenderId = _fcmNotificationSetting.SenderId,
                        ServerKey = _fcmNotificationSetting.ServerKey
                    };
                    GoogleNotification notification = new GoogleNotification();
                    DataPayload dataPayload = new DataPayload();
                    dataPayload.title = notificationModel.Title;
                    dataPayload.body = notificationModel.Body;
                    dataPayload.sound = "default";

                    notification.registration_ids = notificationModel.RegistrationIds;
                    notification.data = notificationModel.Data;
                    notification.notification = dataPayload;

                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(notification);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    result = await httpClient.PostAsync("send", content);
                }
                catch (Exception ex)
                {
                }
                return result;
            }
        }
    }
}

