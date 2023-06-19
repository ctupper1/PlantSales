using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSalesApp
{
    public class Comment    
    {
        private int plantId;
        private int userId;
        private string commentText;
        private DateTime commentDate;

        public int PlantId
        {
            get { return plantId; }
            set { plantId = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string CommentText
        {
            get { return commentText; }
            set { commentText = value; }
        }
        public DateTime CommentDate
        {
            get { return commentDate; }
            set { commentDate = value; }
        }

    }
}
