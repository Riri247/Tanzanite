using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;
using HashPass;

namespace FRONTEND
{
    public partial class EditUser : System.Web.UI.Page
    {
        RentEaseClient Rs = new RentEaseClient();
        int UseID;
        String Name, Eemail, Pass, Type, surname;
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                if (Session["U_type"] != null) {
                    if (Session["U_type"].ToString() == "Adm") {
                        UseType.Visible = true;
                    }
                }
                LoadUser();
            }
        }

        private void LoadUser()
        {

            if (Request.QueryString["ID"] != null)
            {
                UseID = Convert.ToInt32(Request.QueryString["ID"].ToString());

               
                SysUser Temp = Rs.getUser(UseID);
                txtName.Value = Temp.U_Name;
                txtEmail.Value = Temp.Email;
                txtPass.Value = Temp.password;
                txtType.Value = Temp.User_Type;
                TxtSur.Value = Temp.Surname;


            } else if (Request.QueryString["Val"] != null) {
                PassDiv.Visible = true;
                SysUser Temp = Rs.getUser(Convert.ToInt32(Session["ID"].ToString()));
                txtName.Value = Temp.U_Name;
                txtEmail.Value = Temp.Email;
                //txtPass.Value = Temp.password;
                txtType.Value = Temp.User_Type;
                TxtSur.Value = Temp.Surname;
            }
            else {

                if (Request.QueryString["Action"] == null) {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {

                Name = txtName.Value.ToString();
                Eemail = txtEmail.Value.ToString();
                Pass = Secrecy.HashPassword(txtPass.Value.ToString());
                Type = txtType.Value.ToString();
                surname = TxtSur.Value.ToString();

                SysUser Temp = Rs.getUser(Convert.ToInt32(Session["ID"].ToString()));



                if (Request.QueryString["ID"] != null || Request.QueryString["Val"] != null) //edit else you create the user
                {

                    SysUser DTemp = new SysUser
                    {
                        Id = Temp.Id,
                        U_Name = txtName.Value.ToString(),
                        Email = txtEmail.Value.ToString(), //added other e to tell difference
                        password = Secrecy.HashPassword(txtPass.Value.ToString()),
                        User_Type = txtType.Value.ToString(),
                        Surname = TxtSur.Value.ToString()

                    };
                    Rs.EditUserData(DTemp);

                    Response.Redirect("Home.aspx");

                } else {

                    Rs.Register(Eemail, Pass, Name, surname);
                    Response.Redirect("ManageU.aspx");
                }

              
            }
            catch (Exception)
            {
               
            }
        }
    }
}