using Billiards_Club.People.CustomControl;
using Billiards_Club.Properties;
using BilliardsBusinessLayer;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static BilliardsBusinessLayer.clsPerson;

namespace Billiards_Club.People
{
    public partial class frmAddEditPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        public enum eMode { AddNew, Update }
        eMode Mode;
        int? _PersonID;
        clsPerson _Person;
        public frmAddEditPerson()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
        }
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            Mode = eMode.Update;
            _PersonID = PersonID;
        }
        private void _ResetDefoaltValues()
        {
            if (Mode == eMode.AddNew)
            {
                this.Text = "Add New Person";
                lblHeader.Text = "Add New Person";
                _Person = new clsPerson();
                llRemove.Visible = pbPersonImage.ImageLocation != null;
                ccTextBoxFirstName.Text = "";
                ccTextBoxSecondName.Text = "";
                ccTextBoxThirdName.Text = "";
                ccTextBoxLastName.Text = "";
                ccTextBoxNationalNo.Text = "";
                ccTextBoxPhone.Text = "";
                ccTextBoxEmail.Text = "";
                ccTextBoxAddress.Text = "";
                rbMale.Checked = true;
            }
            else
            {
                this.Text = "Edit Person";
                lblHeader.Text = "Edit Person";

            }

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-15);


        }
        private async Task _LoadData()
        {

            _Person = await clsPerson.FindAsync((int)_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("Person not Found");
                this.Close();
                return;
            }

            lblPersonID.Text = _PersonID.ToString();
            ccTextBoxFirstName.Text = _Person.FirstName;
            ccTextBoxSecondName.Text = _Person.SecondName;
            ccTextBoxThirdName.Text = _Person.ThirdName;
            ccTextBoxLastName.Text = _Person.LastName;
            ccTextBoxNationalNo.Text = _Person.NationalNo;
            ccTextBoxEmail.Text = _Person.Email;
            ccTextBoxPhone.Text = _Person.Phone;
            ccTextBoxAddress.Text = _Person.Address;
            dateTimePicker1.Value = _Person.DateOfBirth;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;


            if (!string.IsNullOrWhiteSpace(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }
            llRemove.Visible = _Person.ImagePath != null;
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private async void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefoaltValues();
            if (Mode == eMode.Update)
            {
                await _LoadData();
            }

        }
        private bool _HandlePersonImage()
        {
            //لو الاتنين مختلفين معناها هو مسحها او غيرها
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {

                //هنا بقا بشوف لو هو حط واحده بدالها ولا لا

                if (pbPersonImage.ImageLocation != null)
                {
                    string Source = pbPersonImage.ImageLocation.ToString();
                    if (clsSharedUtil.CopyImageToProjectImagesFolder(ref Source))
                    {
                        pbPersonImage.ImageLocation = Source;

                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }

                //لو غيرها او مسحها امسح القديمه
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    try
                    {
                        if (File.Exists(_Person.ImagePath))
                        {
                            File.Delete(_Person.ImagePath);
                        }
                    }
                    catch (IOException iox)
                    {
                        string Location = "frmAddEditPersonInfo → _HandlePersonImage";
                        clsEventLogger.LogEvent(iox, Location, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }

                }

            }
            return true;
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Complete Requaired Fields");

                return;
            }
            if (!_HandlePersonImage())
            {
                return;
            }


            _Person.FirstName = ccTextBoxFirstName.Text.Trim();
            _Person.SecondName = ccTextBoxSecondName.Text.Trim();
            _Person.ThirdName = ccTextBoxThirdName.Text.Trim();
            _Person.LastName = ccTextBoxLastName.Text.Trim();
            _Person.NationalNo = ccTextBoxNationalNo.Text.Trim();
            _Person.Address = ccTextBoxAddress.Text.Trim();
            _Person.Phone = ccTextBoxPhone.Text.Trim();
            _Person.Email = ccTextBoxEmail.Text.Trim();

            _Person.Gender = (byte)(rbMale.Checked == true ? 0 : 1);
            _Person.DateOfBirth = dateTimePicker1.Value;

            if (pbPersonImage.ImageLocation != null)
            {
                _Person.ImagePath = pbPersonImage.ImageLocation;
            }
            else
            {
                _Person.ImagePath = null;
            }

            if (await _Person.SaveAsync())
            {
                MessageBox.Show("Saved Succefully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode = eMode.Update;
                lblHeader.Text = "Edit Person";
                this.Text = "Edit Person";

                lblPersonID.Text = _Person.PersonID.ToString();
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Save Failed", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ccTextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (ccTextBoxEmail.Text.Length == 0)
            {
                return;
            }
            if (!Regex.IsMatch(ccTextBoxEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(ccTextBoxEmail, "Invalid Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ccTextBoxEmail, "");
            }

        }

        void _Valedite(object sender, CancelEventArgs e)
        {
            ccTextBox field = (ccTextBox)sender;
            if (!field.IsValid())
            {
                e.Cancel = true;
                field.Focus();
                errorProvider1.SetError(field, "Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(field, "");
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pbPersonImage.Load(selectedFilePath);
                llRemove.Visible = true;
                // ...
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            llRemove.Visible = false;
            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = rbMale.Checked ? Resources.Male_512 : Resources.Female_512;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
