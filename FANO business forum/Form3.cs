using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FANO_business_forum
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void export()
        {
            var consentDataCheckbox = Consent_data_checkbox.Checked;
            var consentInfoCheckbox = Consent_info_checkbox.Checked;
            var consentUseCheckbox = Consent_use_checkbox.Checked;
            var consentUpdateCheckbox = Consent_update_checkbox.Checked;
            var submitButton = Submit_button;
            // Well I really didn't want it to come to this but we need a third page
            // I ran out of space so a third page, being the consent one will have to connected too
            // Thank you again in advance, all boxes must be checked before you can submit the forum, ALL.
            // The data can be stored as Consented which can be True or False but should always be True as you shouldn't be able to even submit the forum if you haven't ticked all the consent boxes
            // I've gone through the code and I don't believe any more explainations are needed so best of luck!
        }
    }
}
