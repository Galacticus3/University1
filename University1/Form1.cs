using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DAL;


namespace University1
{
    public partial class Form1 : Form
    {

        DataAccess da = new DataAccess(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

               
        public Form1()
        {
            InitializeComponent();
        }

        public bool txtFieldNotEmpty(TextBox field, Label label)
        {
            if (field.Text.Trim() == "") { label.ForeColor = Color.Red; return false; }
            label.ForeColor = Color.Black; return true;
        }
        public bool cmbFieldNotEmpty(ComboBox field, Label label)
        {
            if (field.Text.Trim() == "") { label.ForeColor = Color.Red; return false; }
            label.ForeColor = Color.Black; return true;
        }
        public bool txtFieldIsInt32(TextBox field, Label label)
        {
            int number;
            if ((Int32.TryParse(field.Text.Trim(),out number)) == false ) { label.ForeColor = Color.Red; return false; }
            label.ForeColor = Color.Black; return true;
        }
        public bool cmbValueMemeberIsInt32(string cmbValueMemeber, Label label)
        {
            int number;
            if ((Int32.TryParse(cmbValueMemeber.Trim(), out number)) == false) { label.ForeColor = Color.Red; return false; }
            label.ForeColor = Color.Black; return true;
        }

        void setcmbStudGroup()
        {
            cmbStudGroup.ValueMember = "Id";
            cmbStudGroup.DisplayMember = "Name";
            cmbStudGroup.DataSource = da.LoadAllGroups();

        }
        void setcmbGrSbjGroup()
        {
            cmbGrSbjGroup.ValueMember = "Id";
            cmbGrSbjGroup.DisplayMember = "Name";
            cmbGrSbjGroup.DataSource = da.LoadAllGroups();
        }
        void setcmbGrSbjSubject()
        {
            cmbGrSbjSubject.ValueMember = "Id";
            cmbGrSbjSubject.DisplayMember = "Name";
            cmbGrSbjSubject.DataSource = da.LoadAllSubjects();
        }


        private void btnShowAllGroups_Click(object sender, EventArgs e)
        {

            dtGridGroups.DataSource = da.LoadAllGroups();
        }

        private void btnShowAllSubjects_Click(object sender, EventArgs e)
        {

            dtGridSubjects.DataSource = da.LoadAllSubjects();
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {

            dtGridStudents.DataSource = da.LoadAllStudents();
            setcmbStudGroup();
        }

        private void btnShowAllGropSubj_Click(object sender, EventArgs e)
        {
            dtGridGroupStud.DataSource = da.LoadAllGroupSubject();
            setcmbGrSbjGroup();
            setcmbGrSbjSubject();
        }


       
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            bool isValid = txtFieldNotEmpty(txtGroup, lblGroup);
            if (!isValid)
            {
                return;
            }

            da.AddNewGroup(txtGroup.Text.Trim()); // add group
            dtGridGroups.DataSource = da.LoadAllGroups(); //Update table
            MessageBox.Show(da.SqlAnswerString);
            txtGroup.Text = "";
            setcmbStudGroup();
            setcmbGrSbjGroup();
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(dtGridGroups.CurrentRow.Cells[0].Value);
            bool isValid = txtFieldNotEmpty(txtGroup, lblGroup);
            if ((dtGridGroups.DataSource == null) || !isValid)
            {
                return;
            }
            da.UpdateCurrentGroup(curRowId, txtGroup.Text.Trim()); //Update group
            dtGridGroups.DataSource = da.LoadAllGroups(); //Update table    
            MessageBox.Show(da.SqlAnswerString);
            setcmbStudGroup();
            setcmbGrSbjGroup();
            dtGridGroupStud.DataSource = da.LoadAllGroupSubject();
        }

        private void btnDeleteCurrentGroup_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(dtGridGroups.CurrentRow.Cells[0].Value);
            if (dtGridGroups.DataSource == null)
            {
                return;
            }
            da.DeleteCurrentGroup(curRowId); //delete group
            dtGridGroups.DataSource = da.LoadAllGroups(); //Update table    
            MessageBox.Show(da.SqlAnswerString);
            setcmbStudGroup();
            setcmbGrSbjGroup();
        }

     
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            bool isValid = txtFieldNotEmpty(txtSubject, lblSubject);
            if (!isValid)
            {
                return;
            }

            da.AddNewSubject(txtSubject.Text.Trim()); // add subject
            dtGridSubjects.DataSource = da.LoadAllSubjects(); //Update table
            MessageBox.Show(da.SqlAnswerString);
            txtSubject.Text = "";
            setcmbGrSbjSubject();
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(dtGridSubjects.CurrentRow.Cells[0].Value);
            bool isValid = txtFieldNotEmpty(txtSubject, lblSubject);
            if ((dtGridSubjects.DataSource == null) || !isValid)
            {
                return;
            }
            da.UpdateCurrentSubject(curRowId, txtSubject.Text.Trim()); //Update group
            dtGridSubjects.DataSource = da.LoadAllSubjects(); //Update table    
            MessageBox.Show(da.SqlAnswerString);
            setcmbGrSbjSubject();
            dtGridGroupStud.DataSource = da.LoadAllGroupSubject();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(dtGridSubjects.CurrentRow.Cells[0].Value);
            if (dtGridSubjects.DataSource == null)
            {
                return;
            }
            da.DeleteCurrentSubject(curRowId); //delete group
            dtGridSubjects.DataSource = da.LoadAllSubjects(); //Update table    
            MessageBox.Show(da.SqlAnswerString);
            setcmbGrSbjSubject();
        }


        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            DataRowView cmbView = cmbStudGroup.SelectedItem as DataRowView;
            bool isValid = txtFieldNotEmpty(txtStudFName, lblStudFirstName) && txtFieldNotEmpty(txtStudLName, lblStudLastName) &&
                           txtFieldNotEmpty(txtStudAge, lblStudAge) && txtFieldIsInt32(txtStudAge, lblStudAge) &&
                           cmbFieldNotEmpty(cmbStudGroup, lblStudGroup) && cmbValueMemeberIsInt32(cmbView["Id"].ToString(), lblStudGroup);
            if (!isValid)
            {
                return;
            }

            da.AddNewStudent(txtStudFName.Text.Trim(), txtStudLName.Text.Trim(), Convert.ToInt32(txtStudAge.Text.Trim()), Convert.ToInt32(cmbView["Id"].ToString()));
            dtGridStudents.DataSource = da.LoadAllStudents();
            txtStudFName.Text = "";
            txtStudLName.Text = "";
            txtStudAge.Text = "";
            MessageBox.Show(da.SqlAnswerString);
        }

        private void btnUpdateCurStud_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(dtGridStudents.CurrentRow.Cells[0].Value);
            DataRowView cmbView = cmbStudGroup.SelectedItem as DataRowView;
            bool isValid = txtFieldNotEmpty(txtStudFName, lblStudFirstName) && txtFieldNotEmpty(txtStudLName, lblStudLastName) &&
                           txtFieldNotEmpty(txtStudAge, lblStudAge) && txtFieldIsInt32(txtStudAge, lblStudAge) &&
                           cmbFieldNotEmpty(cmbStudGroup, lblStudGroup) && cmbValueMemeberIsInt32(cmbView["Id"].ToString(), lblStudGroup);
            if ((dtGridStudents.DataSource == null) || !isValid)
            {
                return;
            }
            da.UpdateCurrentStudent(curRowId, txtStudFName.Text.Trim(), txtStudLName.Text.Trim(), Convert.ToInt32(txtStudAge.Text.Trim()), Convert.ToInt32(cmbView["Id"].ToString())); //Update student
            dtGridStudents.DataSource = da.LoadAllStudents(); //Update table    
            MessageBox.Show(da.SqlAnswerString);
        }

        private void btnDelCurStud_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(dtGridStudents.CurrentRow.Cells[0].Value);
            if (dtGridStudents.DataSource == null)
            {
                return;
            }            
            da.DeleteCurrentStudent(curRowId); //delete student
            dtGridStudents.DataSource = da.LoadAllStudents(); //Update table    
            MessageBox.Show(da.SqlAnswerString);
        }

              
        private void btnAddGrSubj_Click(object sender, EventArgs e)
        {
            DataRowView cmbViewGr = cmbGrSbjGroup.SelectedItem as DataRowView;
            DataRowView cmbViewSbj = cmbGrSbjSubject.SelectedItem as DataRowView;
            bool isValid = cmbFieldNotEmpty(cmbGrSbjGroup, lblGrSbjGroup) && cmbFieldNotEmpty(cmbGrSbjSubject, lblGrSbjSubject) &&
                 cmbValueMemeberIsInt32(cmbViewGr["Id"].ToString(), lblGrSbjGroup) && cmbValueMemeberIsInt32(cmbViewSbj["Id"].ToString(), lblGrSbjSubject);
            if (!isValid)
            {
                return;
            }

            da.AddNewGroupSubj(Convert.ToInt32(cmbViewGr["Id"].ToString()), Convert.ToInt32(cmbViewSbj["Id"].ToString()));
            dtGridGroupStud.DataSource = da.LoadAllGroupSubject();
            MessageBox.Show(da.SqlAnswerString);
        }

        private void btnUpdateGrSubj_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnDeleteGrSubj_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(dtGridGroupStud.CurrentRow.Cells[0].Value);
            if (dtGridGroupStud.DataSource == null)
            {
                return;
            }
            da.DeleteCurrentGroupSubj(curRowId);        // delete group - subject
            dtGridGroupStud.DataSource = da.LoadAllGroupSubject(); //Update table    
            MessageBox.Show(da.SqlAnswerString);
        }


        private void dtGridGroups_SelectionChanged(object sender, EventArgs e)
        {
            int RowIndex = Convert.ToInt32(dtGridGroups.CurrentRow.Index);

            txtGroup.Text = dtGridGroups.Rows[RowIndex].Cells[1].Value.ToString();
        }
        private void dtGridSubjects_SelectionChanged(object sender, EventArgs e)
        {
            int RowIndex = Convert.ToInt32(dtGridSubjects.CurrentRow.Index);

            txtSubject.Text = dtGridSubjects.Rows[RowIndex].Cells[1].Value.ToString();
        }
        private void dtGridStudents_SelectionChanged(object sender, EventArgs e)
        {
            int RowIndex = Convert.ToInt32(dtGridStudents.CurrentRow.Index);

            txtStudFName.Text = dtGridStudents.Rows[RowIndex].Cells[1].Value.ToString();
            txtStudLName.Text = dtGridStudents.Rows[RowIndex].Cells[2].Value.ToString();
            txtStudAge.Text = dtGridStudents.Rows[RowIndex].Cells[3].Value.ToString();
            cmbStudGroup.Text = dtGridStudents.Rows[RowIndex].Cells[4].Value.ToString();
        }
        private void dtGridGroupStud_SelectionChanged(object sender, EventArgs e)
        {
            int RowIndex = Convert.ToInt32(dtGridGroupStud.CurrentRow.Index);

            cmbGrSbjGroup.Text = dtGridGroupStud.Rows[RowIndex].Cells[1].Value.ToString();
            cmbGrSbjSubject.Text = dtGridGroupStud.Rows[RowIndex].Cells[2].Value.ToString();
        }









        private void lblStudent_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void dtGridGroups_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtStudFName_TextChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

    }
}
