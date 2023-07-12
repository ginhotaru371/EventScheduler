using Bunifu.UI.WinForms;
using Event_Scheduler.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Event_Scheduler
{
    public partial class FormMain : Form
    {
        public List<GoogleCalendar> googleEvents = new List<GoogleCalendar>();

        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Event Scheduler";

        static int timeOutNotify = 180000;
        static TimeSpan timeSpan = new System.TimeSpan(0, 5, 0);

        public FormMain()
        {
            a:
            try
            {
                var db = Kt.Db;
                InitializeComponent();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Kimtoo.DbManager.Connections.Show();

                goto a;
            }
        }

        private void hgScheduler_OnAferRender(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                this.Opacity = 1;
                Init.Start();
            }
        }

        private void Init_Tick(object sender, EventArgs e)
        {
            loadData();
            Init.Stop();
        }

        private void buttonViewType_OnSelectionChange(object sender, EventArgs e)
        {
            if (sender.ToString() == "Day")
            {
                btnAdd.Visible = true;
                hgScheduler.Options.ViewType = Hourglass.ViewTypes.Day;
                hgScheduler.Render();
                return;
            }
            if (sender.ToString() == "Week")
            {
                btnAdd.Visible = true;
                hgScheduler.Options.ViewType = Hourglass.ViewTypes.Week;
                hgScheduler.Render();
                return;
            }
            if (sender.ToString() == "Month")
            {
                btnAdd.Visible = false;
                hgScheduler.Options.ViewType = Hourglass.ViewTypes.Month;
                hgScheduler.Render();
                return;
            }

        }

        void loadData()
        {
            var eventList = Kt.Db.Select<EventModel>();

            hgScheduler.RemoveAll();

            //filter 
            if (!checkPersonal.Checked)
                eventList = eventList.Where(r => r.Category != "Personal").ToList();

            if (!checkWork.Checked)
                eventList = eventList.Where(r => r.Category != "Work").ToList();

            if (!checkUrgent.Checked)
                eventList = eventList.Where(r => r.Category != "Urgent").ToList();

            foreach (var _event in eventList)
            {
                hgScheduler.AddEvent(
                    new Hourglass.HourglassEvent
                    {
                        Id = _event.Id.ToString(),
                        BarColor = _event.GetColor()[0],
                        BackColor = _event.GetColor()[1],
                        Start = _event.Start,
                        End = _event.End,
                        Text = _event.Title,
                        Tooltip = _event.Description,
                    });
            }
                
        }

        void loadDatafrGoogle()
        {
            if (checkGoogle.Checked)
            {
                loadData();
                getGoogleEvent();
            } else
            {
                loadData();
            }
        }

        private void checkPersonal_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            loadData();
        }

        private void checkWork_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            loadData();
        }

        private void checkUrgent_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            loadData();
        }
        private void checkGoogle_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            loadDatafrGoogle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var selection = hgScheduler.GetSelection();

                EventModel tukioEvent = new EventModel
                {
                    Start = selection.start.Value,
                    End = selection.end.Value
                };

                new Dialog.Form_AddEvent(Color.SteelBlue, tukioEvent).ShowDialog();

                if (tukioEvent.Id > 0)
                    loadData();

            }
            catch (Exception)
            {
                Alert.Show(this, "Select time range on calendar", BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void calendarControl1_DateTimeChanged(object sender, EventArgs e)
        {
            hgScheduler.Options.StartDate = calendarControl1.DateTime.Date;
            hgScheduler.Render();
        }

        private void hgScheduler_OnEventEdit(object Sender, Hourglass.RangeCalendarEvent e)
        {
            if (e.@event.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                return;
            }

            if (e.@event.BackColor == Color.FromArgb(255, 211, 196))
            {
                e.Cancel = true;
                return;
            }


            //save on db
            var ev = Kt.Db.Single<EventModel>(r => r.Id.ToString() == e.@event.Id);
            ev.Title = e.@event.Text;
            ev.Start = e.@event.Start;
            ev.End = e.@event.End;

            Kt.Db.Save(ev);
        }

        Hourglass.HourglassEvent lastEvent = null;
        private void hgScheduler_OnEventRightClick(object Sender, Hourglass.HourglassEvent _event)
        {
            if (_event.BackColor == Color.FromArgb(255, 211, 196))
            {
                return;
            } else
            {
                lastEvent = _event;
                contextMenu.Show(MousePosition);
            }
        }

        private void hgScheduler_OnEventClick(object Sender, Hourglass.HourglassEvent _event)
        {

            if (_event.BackColor == Color.FromArgb(255, 211, 196))
            {
                return;
            }
            else
            {
                lastEvent = _event;
                var ev = Kt.Db.Single<EventModel>(r => r.Id.ToString() == lastEvent.Id);
                new Dialog.Form_AddEvent(Color.BlueViolet, ev).ShowDialog();
                loadData();
            }

            
        }

        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ev = Kt.Db.Single<EventModel>(r => r.Id.ToString() == lastEvent.Id);
            Kt.Db.Delete(ev);
            lastEvent.Remove();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Visible = false;
                btnNormal.Visible = true;
            } else
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.Visible = true;
                btnNormal.Visible = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            getGoogleEvent();
        }

        void getGoogleEvent ()
        {
            try
            {
                UserCredential credential;

                // Load client secrets.
                using (var stream =
                       new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    /* The file token.json stores the user's access and refresh tokens, and is created
                     automatically when the authorization flow completes for the first time. */
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                var service = new CalendarService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });

                // Define parameters of request.
                EventsResource.ListRequest request = service.Events.List("primary");
                request.TimeMin = DateTime.Now;
                request.ShowDeleted = false;
                request.SingleEvents = true;
                request.MaxResults = 10;
                request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

                // List events.
                Events events = request.Execute();

                foreach (var eventItem in events.Items)
                {
                    hgScheduler.AddEvent(
                        new Hourglass.HourglassEvent
                        {
                            Id = eventItem.Id,
                            BarColor = Color.FromArgb(255, 192, 128),
                            BackColor = Color.FromArgb(255, 211, 196),
                            Start = (DateTime)eventItem.Start.DateTime,
                            End = (DateTime)eventItem.End.DateTime,
                            Text = eventItem.Summary,
                            Tooltip = eventItem.Description,
                        });
                }

            }
            catch (FileNotFoundException g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void getEvent_Tick(object sender, EventArgs e)
        {
            calendarControl1.Refresh();
            loadDatafrGoogle();
        }

        private void notifyTimer_Tick(object sender, EventArgs e)
        {
            var comingEvents = Kt.Db.Select<EventModel>();
            if (comingEvents == null)
                return;

            DateTime currentTime = DateTime.Now;
            DateTime notifyTime = currentTime.Add(timeSpan);

            foreach(var _event in comingEvents)
            {
                if (notifyTime.Hour == _event.Start.Hour && 
                    notifyTime.Minute == _event.Start.Minute && 
                    notifyTime.Second == _event.Start.Second)
                {
                    notify.ShowBalloonTip(timeOutNotify, "Sắp diễn ra", string.Format("{0} lúc {1}", _event.Title, _event.Start), ToolTipIcon.Warning);
                }
                else if (currentTime.Hour == _event.Start.Hour && 
                    currentTime.Minute == _event.Start.Minute && 
                    currentTime.Second == _event.Start.Second)
                {
                    notify.ShowBalloonTip(timeOutNotify, "Sắp diễn ra", string.Format("{0} - ngay bây giờ", _event.Title), ToolTipIcon.Warning);
                }

            }
            
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Visible = false;
                btnNormal.Visible = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.Visible = true;
                btnNormal.Visible = false;
            }
        }

        private void calendarControl1_Click(object sender, EventArgs e)
        {

        }
    }
}