using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;
using System;
using Android.Util;

namespace SignalR.Xamarin.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private HubConnection _connection = null;

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            await Connect();
        }

        public async Task<bool> Connect()
        {
            try
            {
                _connection = new HubConnectionBuilder()
                    .WithUrl($"http://10.0.2.2:29834/chat/1.0")
                    .WithConsoleLogger(LogLevel.Error)
                    .WithTransport(Microsoft.AspNetCore.Sockets.TransportType.WebSockets)
                    .Build();

                await _connection.StartAsync();
                AttachHandlers();

                await this.PostMessage("Namaste");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void AttachHandlers()
        {
            _connection.On<string>("OnSend", (message) =>
            {
                Log.Info("SignalR", message);
            });
        }

        public async Task<bool> PostMessage(string message)
        {
            try
            {
                await _connection.InvokeAsync<string>("PostMessage", message);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

