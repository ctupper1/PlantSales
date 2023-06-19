using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSalesApp
{
    public class Comment
    {
        private int plantID;
        private int userID;
        private string commentMsg;
        private DateTime commentDate;

        public int PlantID
        {
            get { return plantID; }
            set { plantID = value; }
        }
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string CommentMsg
        {
            get { return commentMsg; }
            set { commentMsg = value; }
        }
        public DateTime CommentDate
        {
            get { return commentDate; }
            set { commentDate = value; }
        }

    }
}
