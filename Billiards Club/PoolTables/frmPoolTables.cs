using BilliardsBusinessLayer;
using Pool_Club;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.PoolTables
{
    public partial class frmPoolTables : Form
    {
         
        public frmPoolTables()
        {
            InitializeComponent();
        }
        int AvailableTablesCount = 0;
        private async Task _LoadPoolTables()
        {
            List<clsPoolTableStatus>  poolTables = await clsPoolTableStatus.GetAllPoolTablesStatusAsync();
            flowLayoutPanel1.Controls.Clear();
            foreach (clsPoolTableStatus tableStatus in poolTables)
            {
                ctrlPoolTable ctrl = new ctrlPoolTable(tableStatus);
                ctrl.TableFinished += Ctrl_TableFinished;
                ctrl.TableSelected += Ctrl_TableSelected;
                flowLayoutPanel1.Controls.Add(ctrl);
                if(ctrl.PoolTableStatus.IsAvailable)
                    AvailableTablesCount++;
            }
        }

        private void Ctrl_TableSelected(object? sender, ctrlPoolTable.TableEventArgs e)
        {
            AvailableTablesCount--;
            lblAvailableTable.Text = AvailableTablesCount.ToString();
        }

        private async void frmPoolTables_Load(object sender, EventArgs e)
        {
            await _LoadPoolTables();
            lblAvailableTable.Text = AvailableTablesCount.ToString();

        }
        private void Ctrl_TableFinished( object? sender, ctrlPoolTable.TableEventArgs e)
        {
            AvailableTablesCount++;
            lblAvailableTable.Text = AvailableTablesCount.ToString();
            // e.Player
            // e.Payment
            // e.Table
        }
    }
}
