﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oficina3B17.UI
{
    class LimpaForm
    {
        public LimpaForm(ControlCollection controls)
        {
            foreach (Control ctrControl in controls)
            {
                if (ctrControl is TextBox)
                    ((TextBox)ctrControl).Text = string.Empty;
                else if (ctrControl is DropDownList)
                    ((DropDownList)ctrControl).ClearSelection();
                else if (ctrControl is CheckBox)
                    ((CheckBox)ctrControl).Checked = false;
                else if (ctrControl is RadioButton)
                    ((RadioButton)ctrControl).Checked = false;
                else if (ctrControl is Calendar)
                    ((Calendar)ctrControl).SelectedDate = DateTime.Now;
            }
        }

    }
}
