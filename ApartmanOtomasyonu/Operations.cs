using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonu
{
    public partial class Operations : Form
    {
        public Operations()
        {
            InitializeComponent();
        }

        public void SelectedTab()
        {
            tabControl1.SelectedTab = tp_Expenses;
        }

        ApartmentAutomationEntities1 db = new ApartmentAutomationEntities1();
        private void btn_IncomesAdd_Click(object sender, EventArgs e)
        {
            Incomes ıncomes = new Incomes();
            ıncomes.Amount = nud_IncomesAmount.Value;
            ıncomes.RoomNo = (int)nud_Room.Value;
            ıncomes.Date = dt_IncomesDate.Value;
            db.Incomes.Add(ıncomes);
            db.SaveChanges();
            Operations_Load(sender, e);
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tp_Incomes)
                GetIncomesTable();
            else
                GetExpensesTable();
            ClearControls();
        }

        private void GetExpensesTable()
        {
            dgv_Expenses.DataSource = null;
            dgv_Expenses.DataSource = (from a in db.Expenses join b in db.ExpenseTypes on a.ExpenseType equals b.TypeID select new { a.Date, a.Amount, b.TypeName })
                .ToList()
                .Select(x => new
                {
                    Tür= x.TypeName,
                    Tutar = x.Amount.ToString("C"),
                    Tarih = x.Date,
                })
                .ToList();
        }

        private void GetIncomesTable()
        {
            dgv_Incomes.DataSource = null;
            dgv_Incomes.DataSource = db.Incomes.ToList()
                .Select(x => new
                {
                    DaireNo = x.RoomNo,
                    Tarih = x.Date,
                    Tutar = x.Amount.ToString("C")
                })
                .ToList();
        }

        private int ExpenseTypes()
        {
            if (rbtn_Electricity.Checked)
                return 1;
            else if (rbtn_Water.Checked)
                return 2;
            else if (rbtn_Elevator.Checked)
                return 3;
            else 
                return 4;

        }
        private void btn_ExpensesAdd_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Amount = nud_ExpensesAmount.Value;
            expenses.Date = dt_ExpensesDate.Value;
            expenses.ExpenseType = ExpenseTypes();
            db.Expenses.Add(expenses);
            db.SaveChanges();
            Operations_Load(sender, e);
        }

        private void ClearControls()
        {
            nud_ExpensesAmount.Value = 0;
            nud_IncomesAmount.Value = 0;
            nud_Room.Value = 0;
            dt_ExpensesDate.Value = DateTime.Today;
            dt_IncomesDate.Value = DateTime.Today;
            rbtn_Electricity.Checked = false;
            rbtn_Elevator.Checked = false;
            rbtn_Water.Checked = false;
            rbtn_Cleaning.Checked = false;
        }
        private void Operations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
