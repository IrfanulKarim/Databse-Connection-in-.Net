﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.userTableAdapter adapter = new DataSetTableAdapters.userTableAdapter();

        DataSet.userDataTable table = adapter.GetData();

        foreach(DataSet.userRow row in table)
        {
            Response.Write(row[0]);  
        }

    }
}