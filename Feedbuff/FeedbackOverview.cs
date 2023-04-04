﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuff
{
    public partial class FeedbackOverview : Form
    {
        public FeedbackOverview() { 
            InitializeComponent();
            Feedback DummyFeedback = new Feedback(1, DateTime.Now, "a", "a", "a", "A", true);
            feedbackFromDatabaseLstBx.Items.Add(DummyFeedback.Read()[0].GivenFeedback);

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview overview = new Overview();
            overview.ShowDialog();
            this.Close();
        }

        
    }
}
