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
    public partial class CongregationForm : Form
    {
        ClassManager manager = new ClassManager();
        public CongregationForm(bool newCongregation)
        {
            InitializeComponent();

            
            WeekMeetingHourPicker.Maximum = 12;
            WeekMeetingHourPicker.Minimum = 1;
            
            WeekMeetingMinutePicker.Maximum = 59;
            PublicMeetingHourPicker.Maximum = 12;
            PublicMeetingHourPicker.Minimum = 1;
            PublicMeetingMinutePicker.Maximum = 59;
            
            
            
            WeekMeetingDayComboBox.Items.Add("Sunday");
            WeekMeetingDayComboBox.Items.Add("Monday");
            WeekMeetingDayComboBox.Items.Add("Tuesday");
            WeekMeetingDayComboBox.Items.Add("Wednesday");
            WeekMeetingDayComboBox.Items.Add("Thursday");
            WeekMeetingDayComboBox.Items.Add("Friday");
            WeekMeetingDayComboBox.Items.Add("Saturday");

            PublicMeetingDayComboBox.Items.Add("Sunday");
            PublicMeetingDayComboBox.Items.Add("Monday");
            PublicMeetingDayComboBox.Items.Add("Tuesday");
            PublicMeetingDayComboBox.Items.Add("Wednesday");
            PublicMeetingDayComboBox.Items.Add("Thursday");
            PublicMeetingDayComboBox.Items.Add("Friday");
            PublicMeetingDayComboBox.Items.Add("Saturday");

            if(newCongregation==true)
            {
                CreatorUpdateButton.Text = "Create Congregation";
                NewCongregationRadioButton.Checked = true;
            }
            
        }

        public CongregationForm(bool newCongregation, Congregation congo)
        {
            InitializeComponent();
           
            WeekMeetingHourPicker.Maximum = 12;
            WeekMeetingHourPicker.Minimum = 1;
            WeekMeetingMinutePicker.Maximum = 59;
            PublicMeetingHourPicker.Maximum = 12;
            PublicMeetingHourPicker.Minimum = 1;
            PublicMeetingMinutePicker.Maximum = 59;
            
            
            WeekMeetingDayComboBox.Items.Add("Sunday");
            WeekMeetingDayComboBox.Items.Add("Monday");
            WeekMeetingDayComboBox.Items.Add("Tuesday");
            WeekMeetingDayComboBox.Items.Add("Wednesday");
            WeekMeetingDayComboBox.Items.Add("Thursday");
            WeekMeetingDayComboBox.Items.Add("Friday");
            WeekMeetingDayComboBox.Items.Add("Saturday");

            PublicMeetingDayComboBox.Items.Add("Sunday");
            PublicMeetingDayComboBox.Items.Add("Monday");
            PublicMeetingDayComboBox.Items.Add("Tuesday");
            PublicMeetingDayComboBox.Items.Add("Wednesday");
            PublicMeetingDayComboBox.Items.Add("Thursday");
            PublicMeetingDayComboBox.Items.Add("Friday");
            PublicMeetingDayComboBox.Items.Add("Saturday");

            if(newCongregation==false)
            {
                CreatorUpdateButton.Text = "Update Congregation";
                CongregationIdLabel.Text = Convert.ToString(congo.Id);
                AddressTextBox.Text = congo.Address;
                CityTextBox.Text = congo.City;
                StateTextBox.Text = congo.State;
                ZipTextBox.Text = congo.Zipcode;
                WeekMeetingDayComboBox.Text=congo.WeekMeetingDay;
                PublicMeetingDayComboBox.Text = congo.PublicMeetingDay;
                WeekMeetingHourPicker.Value = Convert.ToInt32(congo.WeekMeetingTime.Split(':')[0]);
                WeekMeetingMinutePicker.Value = Convert.ToInt32(congo.WeekMeetingTime.Split(':')[1]);
                
                NewCongregationRadioButton.Checked = false;
                
            }
        }

        private void CreatorUpdateButton_Click(object sender, EventArgs e)
        {
            if(NewCongregationRadioButton.Checked==true)
            {
                
                Congregation newCongo = manager.CreateCongregation(CongregationNameTextBox.Text, AddressTextBox.Text, CityTextBox.Text, StateTextBox.Text, ZipTextBox.Text,
                    WeekMeetingDayComboBox.SelectedItem.ToString(), WeekMeetingHourPicker.Value.ToString() + ":" + WeekMeetingMinutePicker.Value.ToString(), 
                    PublicMeetingDayComboBox.SelectedItem.ToString(), PublicMeetingHourPicker.Value.ToString() + ":" + PublicMeetingMinutePicker.Value.ToString());
                MemberForm newMember = new MemberForm(newCongo.Id,true,false,false,null);
                newMember.WindowState = FormWindowState.Normal;
                this.Close();
                newMember.Show();
            }
            else
            {
                manager.UpdateCongregation(Convert.ToInt32(CongregationIdLabel.Text), CongregationNameTextBox.Text, AddressTextBox.Text, CityTextBox.Text, StateTextBox.Text, ZipTextBox.Text,
                    WeekMeetingDayComboBox.SelectedItem.ToString(), WeekMeetingHourPicker.Value.ToString() + ":" + WeekMeetingMinutePicker.Value.ToString(), 
                    PublicMeetingDayComboBox.SelectedItem.ToString(), PublicMeetingHourPicker.Value.ToString() + ":" + PublicMeetingMinutePicker.Value.ToString());
                MessageBox.Show("Congregation Updated");
                this.Close();
            }
        }
    }
}
