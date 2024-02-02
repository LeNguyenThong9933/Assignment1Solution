using BusinessObject;
using DataAccess.Repos;
using System.ComponentModel;
using System.Windows.Forms;
namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;

        }

        private void DgvMemberList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberByObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
        public void LoadMemberList()
        {
            var member = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = member;
                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtEmail.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberID");
                txtName.DataBindings.Add("Text", source, "MemberName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtEmail.DataBindings.Add("Text", source, "Email");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (member.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
        }//end LoadMemberList

        private void ClearText()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        private Member? GetMemberByObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    Password = dgvMemberList.CurrentRow.Cells["Password"].Value.ToString(),
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };

            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberByObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortMembersByNameDescending();
        }
        private void SortMembersByNameDescending()
        {
            var members = memberRepository.GetMembers().OrderByDescending(m => m.MemberName).ToList();
            source.DataSource = members;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchMembers();
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            SortMembersByNameDescending();
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchMembers();
        }

        private void SearchMembers()
        {
            var searchCriteria = cboSearch.SelectedItem?.ToString();
            var searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchCriteria) || string.IsNullOrEmpty(searchText))
            {
                LoadMemberList(); // If search criteria or text is empty, load all members
                return;
            }

            try
            {
                IEnumerable<Member> filteredMembers;

                switch (searchCriteria)
                {
                    case "ID":
                        int searchId;
                        if (int.TryParse(searchText, out searchId))
                        {
                            filteredMembers = memberRepository.GetMembers().Where(m => m.MemberID == searchId);
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID format.", "Search Error");
                            return;
                        }
                        break;

                    case "Name":
                        filteredMembers = memberRepository.GetMembers().Where(m => m.MemberName.Contains(searchText, StringComparison.OrdinalIgnoreCase));
                        break;

                    default:
                        MessageBox.Show("Invalid.", "Search Error");
                        return;
                }

                source.DataSource = new BindingList<Member>(filteredMembers.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Error");
            }
        }
    }
}
