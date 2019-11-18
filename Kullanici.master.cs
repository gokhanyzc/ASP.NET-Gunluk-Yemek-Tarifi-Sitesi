using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //sql bağlantısı için kütüphane uzantısı.

public partial class Kullanici : System.Web.UI.MasterPage
{


    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand komut = new SqlCommand("Select * From Tbl_Kategoriler", bgl.baglanti());   //sql sorgusu için kullanılır.
        //bgl baglantısı sqlsinif.cs ye gidiyor buradan ve baglantı methoduna ulaşıyor.
        SqlDataReader oku = komut.ExecuteReader();
        DataList1.DataSource = oku;  //DataList: veri çekme işlemine yarıyor.
        DataList1.DataBind(); //bu işlemle methodları dataliste aktar.

    }                       
}
