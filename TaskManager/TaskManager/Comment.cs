﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Comment : TaskEvent
    {
        public String comment;
        public int empId;

        public Comment() { }

        public Comment(String comment)
        {
            this.comment = (String)comment.Clone();
        }

        public void setComment(String Comment)
        {
            this.comment = (String)comment.Clone();
        }

        public String getComment()
        {
            return comment;
        }
        
        public void setEmployeeId(int empId)
        {
            this.empId = empId;
        }

        public int getEmployeeId()
        {
            return empId;
        }
    }
}
