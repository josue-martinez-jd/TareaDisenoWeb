﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    User user = new User();
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }



    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        user.Login(txtUsernameLogin.Text, txtPasswordLogin.Text);
    }
}