﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task task = new Task("Test", 0);

            task.Forward(new Forward(0));
            task.Forward(new Forward(1));

            Attachment attachment = new Attachment("C:\\Users\\shaks");
            task.addAttachment(attachment);

            attachment = new Attachment("C:\\Users\\shakshak");
            task.addAttachment(attachment);

            Description description = new Description("Bla bla bla");
            task.editDescription(description);

            description = new Description("Bla bla blaaaaaaaaaaaaaaaaaaaaaa");
            task.editDescription(description);

            
            task.addComment(new Comment("comment"));
            task.addComment(new Comment("commmmmmmmmmment"));

            Task.readTasks();
            task.taskId = Task.tasks.Count;
            Task.tasks.Add(task);
            Task.writeTasks();
        }
    }
}
