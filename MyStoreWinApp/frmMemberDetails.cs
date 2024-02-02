using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repos;
using BusinessObject;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member MemberInfo { get; set; }
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) //update
            {
                txtID.Text = MemberInfo.MemberID.ToString();
                txtName.Text = MemberInfo.MemberName.ToString();
                txtEmail.Text = MemberInfo.Email.ToString();
                txtPassword.Text = MemberInfo.Password.ToString();
                txtCity.Text = MemberInfo.City.ToString();
                txtCountry.Text = MemberInfo.Country.ToString();
            }
        }//end frmMemberDetails_Load    

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }//end btnSave_Click

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
