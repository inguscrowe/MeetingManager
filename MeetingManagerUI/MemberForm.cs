using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeetingManager;

namespace MeetingManagerUI
{
    public partial class MemberForm : Form
    {
        ClassManager manager = new ClassManager();
        Congregation congo = new Congregation();
        CommonControls cc = new CommonControls();
        bool firstMember = new bool();
        bool neccessaryFieldsOnly = new bool();
        bool update = new bool();
        EditMembersForm emf;
        
        public MemberForm(int congregationId,bool isFirstMember,bool essentialFieldsOnly, bool isUpdate, EditMembersForm editForm)
        {
            InitializeComponent();
            congo = manager.CongregationByCongregationId(congregationId);
            firstMember = isFirstMember;
            neccessaryFieldsOnly = essentialFieldsOnly;
            update = isUpdate;
            emf = editForm;


            if (neccessaryFieldsOnly == true)
            {
                UserNameLabel.Visible = false;
                UserNameTextBox.Visible = false;
                PasswordLabel.Visible = false;
                PasswordTextBox.Visible = false;
                MiddleName.Visible = false;
                MiddleNameLabel.Visible = false;
                DateOfBirthPicker.Visible = false;
                DateOfBirthLabel.Visible = false;
                BaptismDateLabel.Visible = false;
                BaptismDatePicker.Visible = false;
                if(update==true)
                {
                    FirstName.Text = emf.SelectedMember.FirstName;
                    LastName.Text = emf.SelectedMember.LastName;
                    PreferredName.Text = emf.SelectedMember.PreferredName;
                    AddUpdateButton.Text = "Update Member";
                }
            }
        }

        private void AddUpdateMember_Click(object sender, EventArgs e)
        {
            Member newMember = new Member();
            if (neccessaryFieldsOnly == false) //check to see if username and password are not duplicated
            {
                int count = manager.MemberByUsername(UserNameTextBox.Text.Replace(" ", ""));
                if (count==0)
                {
                  newMember = manager.CreateMember(FirstName.Text, MiddleName.Text, LastName.Text, PreferredName.Text, DateOfBirthPicker.Value, BaptismDatePicker.Value, Email.Text,
                ContactNumber.Text.Replace("-", ""), UserNameTextBox.Text, PasswordTextBox.Text, congo.Id);
                }
                else
                {
                    MessageBox.Show("Username is already taken.");
                    return;
                }
            }
            else if (update==false)
            {

               newMember= manager.CreateMember(FirstName.Text, PreferredName.Text, LastName.Text, Email.Text,ContactNumber.Text, congo.Id);
               emf.CurrentMembersGridBox = cc.CurrentMembersBox(emf.CurrentMembersGridBox, congo.Id);
            }
            else
            {
                newMember.Id = emf.SelectedMember.Id;
                newMember.FirstName = FirstName.Text;
                newMember.LastName = LastName.Text;
                newMember.PreferredName = PreferredName.Text;
                newMember.ContactNumber = ContactNumber.Text;
                newMember.Email = Email.Text;
                emf.SelectedMember = manager.UpdateMember(newMember,true);
                emf.CurrentMembersGridBox = cc.CurrentMembersBox(emf.CurrentMembersGridBox, congo.Id);
                this.Close();
                if (emf.SelectedMember.PreferredName == null || emf.SelectedMember.PreferredName == "")
                {
                    MessageBox.Show(emf.SelectedMember.FirstName + " " + emf.SelectedMember.LastName + " profile has been updated.");
                }
                else
                {
                    MessageBox.Show(emf.SelectedMember.PreferredName + " profile has been update.");
                }
                return;
            }
            
            if(firstMember==true)
            {
                Assignment scheduler = manager.CreateAssignment("Assignment Scheduler", "Creates and schedules assignments for the meetings.", congo.Id, null,null, newMember.Id);
                manager.CreateAssignment("Sound Box", "Handles sound duties for meeting.", congo.Id, 1, 1, newMember.Id);
                manager.CreateAssignment("Stage", "Handles stage duties for meeting.", congo.Id, 1, 2, newMember.Id);
                manager.CreateAssignment("Microphone", "Handles microphone for meeting.", congo.Id, 2, 3, newMember.Id);
                manager.CreateAssignment("Attendant", "Greets, sits, and takes count of congregation for meetings.", congo.Id, 2, 4, newMember.Id);
               manager.CreateAssignment("Elder", "Elder in congregation.", congo.Id, null,null,newMember.Id);
               manager.CreateAssignment("Ministerial Servant", "Ministerial Servant in congregation.", congo.Id, null,null, newMember.Id);
                MemberAssignment schedulermember = manager.CreateMemberAssignment(newMember.Id, scheduler.Id,newMember.CongregationId);
            }
            this.Close();
            if(newMember.PreferredName==null||newMember.PreferredName=="")
            {
                MessageBox.Show(newMember.FirstName + " " + newMember.LastName + " have been added to Members."); 
            }
            else
            {
                MessageBox.Show(newMember.PreferredName+ " have been added to Members."); 
            }
            
        }

        
    }
}
