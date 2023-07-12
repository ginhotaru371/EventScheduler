using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Event_Scheduler.Models
{
    [AutoGenerateTable(0)]
    [JengaEntity]
    [Alias("Events")]
    public class EventModel
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        [JengaIdentifier]
        public string Title { get; set; }
        [JengaTextArea]
        public string Description { get; set; }

        [JengaOptions("Work,Personal,Urgent")]
        public string Category { get; set; } = "Work";

        public DateTime Start { get; set; }
        public DateTime End { get; set; }


        public List<Color> GetColor()
        {
            var ret = new List<Color>();

            if (this.Category == "Personal")
            {
                ret.Add(Color.FromArgb(74, 220, 168));
                ret.Add(Color.FromArgb(194, 243, 226));
            }
            else if (this.Category == "Urgent")
            {
                ret.Add(Color.FromArgb(255, 102, 147));
                ret.Add(Color.FromArgb(255, 204, 219));
            }
            else
            {
                ret.Add(Color.FromArgb(30, 144, 255));
                ret.Add(Color.FromArgb(153, 207, 255));
            }

            return ret;
        }

    }
}
