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

                if (UseID == Convert.ToInt32(Session["ID"].ToString()))
                {
                    PassDiv.Visible = true;
                }
                SysUser Temp = Rs.getUser(UseID);
                txtName.Value = Temp.U_Name;
                txtEmail.Value = Temp.Email;
                txtPass.Value = Temp.password;
                txtType.Value = Temp.User_Type;
                TxtSur.Value = Temp.Surname;
                

            }
            else {
                PassDiv.Visible = true;
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {

                Name = txtName.Value;
                Eemail = txtEmail.Value;
                Pass = Secrecy.HashPassword(txtPass.Value.ToString());
                Type = txtType.Value;
                surname = TxtSur.Name;

                
                if (Request.QueryString["ID"] != null) //edit else you create the user
                {

                    SysUser Temp = new SysUser
                    {
                        U_Name = Name,
                        Email = Eemail, //added other e to tell difference
                        password = Pass,
                        User_Type = Type,
                        Surname = surname

                    };
                    Rs.EditUserData(Temp);

                } else {

                    Rs.Register(Eemail, Pass, Name, surname);
                }

              
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}