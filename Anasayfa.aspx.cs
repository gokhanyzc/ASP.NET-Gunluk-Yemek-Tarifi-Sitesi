﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Anasayfa : System.Web.UI.Page
{

    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand komut = new SqlCommand("Select * From Tbl_Yemekler", bgl.baglanti());
        SqlDataReader dr = komut.ExecuteReader();  //dr=DataReader.
        DataList2.DataSource=dr;
        DataList2.DataBind();

    }
}