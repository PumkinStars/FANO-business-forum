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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void export()
        {
            var printingMediaPersonalCheckbox = Print_media_personal_checkbox.Checked;
            var vehicleTransportPersonalCheckbox = Vehicle_personal_checkbox.Checked;
            var agricultureStockPersonalCheckbox = Agriculture_personal_checkbox.Checked;
            var tradePersonalCheckbox = Trade_personal_checkbox.Checked;
            var digitalPersonalCheckbox = Digital_personal_checkbox.Checked;
            var retailPersonalCheckbox = Retail_personal_checkbox.Checked;
            var servicesPersonalCheckbox = Services_personal_checkbox.Checked;
            var defencePersonalCheckbox = Defence_personal_checkbox.Checked; 
            var consultingPersonalCheckbox = Consulting_personal_checkbox.Checked;
            var healthPersonalCheckbox = Health_personal_checkbox.Checked;
            var constructionPersonalCheckbox = Construct_material_personal_checkbox.Checked;
            var logisticsPersonalCheckbox = Logistics_personal_checkbox.Checked;
            var metalPersonalCheckbox = Metal_personal_checkbox.Checked;
            var leatherPersonalCheckbox = Leather_personal_checkbox.Checked;
            var chemistryPersonalCheckbox = Chemistry_personal_checkbox.Checked;
            var machinePersonalCheckbox = Machine_personal_checkbox.Checked;
            var energyPersonalCheckbox = Energy_personal_checkbox.Checked;
            var travelPersonalCheckbox = Travel_personal_checkbox.Checked;
            var educationPersonalCheckbox = Education_personal_checkbox.Checked;
            var furniturePersonalCheckbox = Furniture_personal_checkbox.Checked;
            var foodPersonalCheckbox = Food_personal_checkbox.Checked;
            var constructionMaterialPersonalCheckbox = Construct_material_personal_checkbox.Checked;
            var ngoPersonalCheckbox = NGO_personal_checkbox.Checked;
            var otherPersonalTextbox = Other_personal_textbox.Text;
            var microCompanyRadio = Micro_company_radio.Checked;
            var smallCompanyRadio = Small_company_radio.Checked;
            var mediumCompanyRadio = Medium_company_radio.Checked;
            var fundingCollabCheckbox = Funding_collab_checkbox.Checked;
            var globalCollabCheckbox = Global_collab_checkbox.Checked;
            var skillTransferCollabCheckbox = SkillTransfer_collab_checkbox.Checked;
            var relationshipCollabCheckbox = Relationships_collab_checkbox.Checked;
            var distributorCollabCheckbox = Distributor_collab_checkbox.Checked;
            var fanoMemberYesRadio = FANO_member_yes_radio.Checked;
            var fanoMemberNoRadio = FANO_member_no_radio.Checked;
            var involvementYesRadio = Involvement_yes_radio.Checked;
            var involvementNoRadio = Involvement_no_radio.Checked;
            
            // Any empty values should be displayed as None but all radio button must be selected and if not the forum cannot be submmited
            // The information should be displayed in an excel spreadsheet as we talked about so all the people are in a single spreadsheet
            // You mentioned you won't do the search feature today but that's totally okay since I believe you can search things on excel anyway as that's a very important feature
            // For the future though it would basically allow me to search all the males who have micro business and members and I'd get them in a PDF or spreadsheet. Whatever you believe would work best
            // Last part is for you to work your magic and somehow turn this into something that functions as intended
            // I owe you big for this one dude, thanks a whole ton for all the help! And happy belated birthday once more, hope you enjoy the celebration
        }
    }

}
