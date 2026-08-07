using Billiards_Club.Properties;
using BilliardsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.People.UserControls
{
    public partial class ctrlPersonCard : UserControl
    {
        clsPerson _Person;
        int? _PersonID = null;
        public int? PersonID { get { return _PersonID; } }
        public clsPerson SelectedPersonInfo { get { return _Person; } }

        private void _ResetPersonInfo()
        {
            lblPersonID.Text = "[???]";
            lblName.Text = "[???]";
            lblNationalNo.Text = "[???]";
            lblGender.Text = "[???]";
            lblEmail.Text = "[???]";
            lblAddress.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblPhone.Text = "[???]";
            pbPersonImage.Image = Resources.Male_512;
            llEditPersonInfo.Enabled = false;
            _PersonID = null;

        }
        private void _LoadPersonImage()
        {
            pbGenderImage.Image = _Person.Gender == 0 ? Resources.Man_32 : Resources.Woman_32;
            if (!string.IsNullOrEmpty(_Person.ImagePath))
                if (File.Exists(_Person.ImagePath))
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                else
                    MessageBox.Show("Coud not Find this image: " + _Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                pbPersonImage.Image = _Person.Gender == 0 ? Resources.Male_512 : Resources.Female_512; 


        }
        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName();
            lblNationalNo.Text = _Person.NationalNo.ToString();
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email ?? "";
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("d");
            lblPhone.Text = _Person.Phone;
            _LoadPersonImage();
        }
        public async Task LoadPersonAsync(int PersonID)
        {
            _Person = await clsPerson.FindAsync(PersonID);
            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person With PersonID =" + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public async Task LoadPersonAsync(string NationalNo)
        {
            _Person = await clsPerson.FindAsync(NationalNo);
            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person With NationalNo =" + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private async  void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_Person.PersonID);
            frm.ShowDialog();
           await LoadPersonAsync(_Person.PersonID);
        }
        public void Reset()
        {
            _ResetPersonInfo();
        }
    }
}
