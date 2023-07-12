using Kimtoo.BindingProvider;
using Kimtoo.ValidationProvider;
using Newtonsoft.Json.Linq;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Scheduler.Dialog
{
    public partial class Form_AddEvent : Form
    {
        private Event_Scheduler.Models.EventModel _record;
        private Event_Scheduler.Models.EventModel _oldRecord;
        public Dictionary<string, object> FixedValues = new Dictionary<string, object>();

        public Func<Event_Scheduler.Models.EventModel, Event_Scheduler.Models.EventModel, bool> BeforeSave { get; set; } = null;
        public Action<Event_Scheduler.Models.EventModel> AfterSave { get; set; } = null;

        public Form_AddEvent(Color themeColor, Event_Scheduler.Models.EventModel record = null, bool readOnly = false)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            //enable double buffer
            pnlContent.GetType()
               .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
               .SetValue(pnlContent, true, null);

            if (record == null)
                _record = new Event_Scheduler.Models.EventModel(); //create new recoded
            else
                _record = record; //assign existing record

            //bind data to dropdowns
            var db = Kt.Db;
            //reference

            //disable controls if read-only mode
            if (readOnly)
            {
                foreach (Control ctrl in pnlContent.Controls)
                {
                    if (ctrl.GetType() != typeof(Label))
                        ctrl.Enabled = false;
                    btnCancel.Enabled = true;
                }
            }
            JengaInit(themeColor);
            Cursor.Current = Cursors.Default;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //check validation
                if (validationProvider.Validate().Length > 0)
                {
                    Alert.Show(this, "Vaidation Error", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    return;  //Return when validation fails
                }
                if (BeforeSave != null)
                    if (!BeforeSave.Invoke(_oldRecord, _record))
                        return;
                Kt.Db.Save(_record); //save changes to database
                if (AfterSave != null)
                    AfterSave.Invoke(_record);
                Alert.Show(this, "Successfull", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
            }
            catch (Exception err)
            {
                Alert.Show(this, err.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            //check fixed Values
            if (this.FixedValues.Count() > 0)
            {
                //disable mentioned controls
                foreach (Control ctrl in pnlContent.Controls)
                    if (bindingProvider.GetLink(ctrl) != null && FixedValues.ContainsKey(bindingProvider.GetLink(ctrl).Data))
                        ctrl.Enabled = false;

                //merge the pased values
                var tmp = JObject.FromObject(_record);
                foreach (var prop in this.FixedValues)
                    tmp[prop.Key] = JToken.Parse(prop.Value.ToString());

                _record = tmp.ToObject<Event_Scheduler.Models.EventModel>();
            }

            //bind record to controls
            bindingProvider.Bind(_record);
            /**load**/
        }
        /**global**/
    }
}
