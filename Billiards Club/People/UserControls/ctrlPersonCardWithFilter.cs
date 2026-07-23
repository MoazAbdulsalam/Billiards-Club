using BilliardsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Billiards_Club.People.UserControls.ctrlPersonCardWithFilter;

namespace Billiards_Club.People.UserControls
{

    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public class OnPersonSelectedEventArgs : EventArgs
        {
            public int? PersonID { get; }
            public clsPerson? SelectedPerson { get; }
            public OnPersonSelectedEventArgs(int? PersonId, clsPerson? SelectedPerson)
            {
                this.PersonID = PersonId;
                this.SelectedPerson = SelectedPerson;
            }
        }
        public event EventHandler<OnPersonSelectedEventArgs> OnPersonSelected;
        protected virtual void RaiseOnPersonSelected(OnPersonSelectedEventArgs e)
        {
            OnPersonSelected?.Invoke(this, e);
        }
      

        private bool _ShowAddPerson = true;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set { _ShowAddPerson = value; btnAddNewPerson.Visible = _ShowAddPerson; }
        }

        private bool _FilterEnabled = true;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set { _FilterEnabled = value; gbFilter.Enabled = _FilterEnabled; }
        }
        public int? PersonID { get { return ctrlPersonCard1.PersonID; } }
        public clsPerson SelectedPersonInfo { get { return ctrlPersonCard1.SelectedPersonInfo; } }

        public enum eSearchBy { PersonId, NationalNo }
        eSearchBy _SearchBy;
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        public Task LoadPersonInfoAsync(int PersonID)
        {
            cbFilter.SelectedIndex = 0;
            ccTextBoxSearch.Text = PersonID.ToString();
            return _FindPersonAsync();
        }
        async Task _FindPersonAsync()
        {
            if (!ccTextBoxSearch.IsValid())
                return;
            switch (_SearchBy)
            {
                case eSearchBy.PersonId:
                    await ctrlPersonCard1.LoadPersonAsync(Convert.ToInt32(ccTextBoxSearch.Text));
                    break;
                case eSearchBy.NationalNo:
                    await ctrlPersonCard1.LoadPersonAsync(ccTextBoxSearch.Text.Trim());
                    break;
            }
            if (_FilterEnabled)
                RaiseOnPersonSelected(new OnPersonSelectedEventArgs(ctrlPersonCard1.PersonID, ctrlPersonCard1.SelectedPersonInfo));
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchBy = (eSearchBy)cbFilter.SelectedIndex;
            ccTextBoxSearch.InputType = _SearchBy == eSearchBy.PersonId ? CustomControl.ccTextBox.InputTypeEnum.NumberInput : CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxSearch.Text = "";
            ctrlPersonCard1.Refresh();
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            btnSearch.Enabled = false;
        }

        private void ccTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (ccTextBoxSearch.IsValid())
            {
                btnSearch.Enabled = true;

            }
            else
                btnSearch.Enabled = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await _FindPersonAsync();
        }
        public void FilterFocus()
        {
            ccTextBoxSearch.Focus();
        }
        async void _DataBackEvent(object sender, int PersonID)
        {
           await LoadPersonInfoAsync(PersonID);
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataBack += _DataBackEvent;
            frm.ShowDialog();
        }

        private async void ccTextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               await _FindPersonAsync();
            }
        }
    }
}
