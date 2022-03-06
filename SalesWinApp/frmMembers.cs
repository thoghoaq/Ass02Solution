using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        public frmMembers()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this member?";
            string title = "Confirm Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            try
            {
                var mem = GetMemberObject();
                memberRepository.DeleteMember(mem.MemberID);
                LoadMemberList();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        public void LoadMemberList()
        {
            var mems = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = mems;

                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (mems.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                } else
                {
                    btnDelete.Enabled = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            };
        }

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private MemberObject GetMemberObject()
        {
            MemberObject mem = null;
            try
            {
                mem = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return mem;
        }
    }
}
