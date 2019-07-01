using SalesManagerSystem.Controller;
using SalesManagerSystem.Factories;
using SalesManagerSystem.Model;
using SalesManagerSystem.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagerSystem.View
{
    public partial class RegisterUnit : Form
    {
        private CalcTypeController _calcTypeController = null;
        private UnitMeasurementController _unitMeasurementController = null;

        public RegisterUnit()
        {
            InitializeComponent();

            AddItemGetCalcTypes();
        }

        public void SaveUnitMeasurement()
        {
            try
            {
                if (ValidationFieldsRegisterUnit())
                {
                    string key_unit = txtKey.Text;
                    string description_unit = txtName.Text;

                    var calcType = (CalcType)cbxTypeCalc.SelectedItem;
                    int calc_type_id = calcType.Id;

                    _unitMeasurementController = new UnitMeasurementController();
                    _unitMeasurementController.SaveUnitMeasurement(key_unit, description_unit, calc_type_id);

                    MessageBox.Show(Messages.MESSAGE_SAVE_SUCESS, Messages.MESSAGE_SUCESS);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Messages.MESSAGE_FAIL, Messages.MESSAGE_ERROR);
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        private bool ValidationFieldsRegisterUnit()
        {
            string message = string.Empty;
            bool validate = true;

            if (string.IsNullOrEmpty(txtKey.Text))
            {
                message += string.Format("{0}\n", Messages.MESSAGE_UNIT_KEY);
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                message += string.Format("{0}\n", Messages.MESSAGE_DESCRIPTION_UNIT);
            }

            if (cbxTypeCalc.SelectedItem == null)
            {
                message += string.Format("{0}\n", Messages.MESSAGE_CALC_UNIT);
            }

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, Messages.MESSAGE_WARNING);
                validate = false;
            }

            return validate;
        }

        private void ClearFields()
        {
            txtKey.Text = string.Empty;
            txtName.Text = string.Empty;
            cbxTypeCalc.SelectedItem = null;
            txtKey.Focus();
        }

        private void AddItemGetCalcTypes()
        {
            _calcTypeController = new CalcTypeController();
            List<CalcType> calcTypes = _calcTypeController.GetCalcTypes().ToList();

            calcTypes.ForEach(x =>
            {
                cbxTypeCalc.Items.Add(x);
            });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SaveUnitMeasurement();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _calcTypeController = null;
            _unitMeasurementController = null;

            this.Dispose();
        }
    }
}
