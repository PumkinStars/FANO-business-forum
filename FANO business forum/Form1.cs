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
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void export()
        {
            //Required information AKA very important and must be displayed. Personal info about the person
            var companyApplies = Company_applies.Checked;
            var professionalApplies = Professional_applies.Checked;
            var firstName = First_name_textbox.Text;
            var surName = Surname_textbox.Text;
            var title = Title_textbox.Text;
            var dateOfBirth = Date_of_birth.Text;
            var genderMale = Gender_male_radio.Checked;
            var genderFemale = Gender_female_radio.Checked;
            var address = Address_textbox.Text;
            var postalCode = Postal_code_textbox.Text;
            var cellPhoneNumber = Cellphone_number_textbox.Text;
            var emailAddress = Email_address_textbox.Text;
            //Company info will the the company one works at, any input left empty should be displayed as None the spreadsheet so instead of Job title being an input like Doctor, it would be None
            var companyBusinessName = Comany_business_name_textbox.Text;
            var jobTitleTextbox = Job_title_textbox.Text;
            var workAddressTextbox = Work_address_textbox.Text;
            var workPhoneNumberTextbox = Work_number_textbox.Text;
            var workEmailTextbox = Work_email_textbox.Text;
            var openingBusinessInterestNoRadio = Opening_business_interest_no_radio.Checked;
            var openingBusinessInterestYesRadio = Opening_business_interest_yes_radio.Checked;
            // Company line of industry should be set to:
            // None of no checkbox is ticked and there's no value in the Other textbox
            // The checked box's industry if one or more is selected and the value in other if there's also a value in the Other textbox
            // Only the value in Other if only the Other textbox has a value
            // The checked box's industry if one or more is selected
            var itBusinessCheckbox = IT_business_checkbox.Checked;
            var securityBusinessCheckbox = Security_business_checkbox.Checked;
            var artDesignBusinessCheckbox = Art_design_business_checkbox.Checked;
            var accountingFinanceBusinessCheckbox = Accounting_finance_business_checkbox.Checked;
            var bankingInsuranceBusinessCheckbox = Banking_insurance_business_checkbox.Checked;
            var engineeringBusinessCheckbox = Engineering_business_checkbox.Checked;
            var legalBusinessCheckbox = Legal_business_checkbox.Checked;
            var agricultureBusinessCheckbox = Agriculture_business_checkbox.Checked;
            var advertisingMarketingBusinessCheckbox = Advertising_marketing_business_checkbox.Checked;
            var medicalDentalBusinessCheckbox = Medical_dental_business_checkbox.Checked;
            var beautyBusinessCheckbox = Beauty_business_checkbox.Checked;
            var miningBusinessCheckbox = Mining_business_checkbox.Checked;
            var wholesaleBusinessCheckbox = Wholesale_retail_business_checkbox.Checked;
            var manufacturingBusinessCheckbox = Manufacturing_business_checkbox.Checked;
            var educationTrainingBusinessCheckbox = Education_training_business_checkbox.Checked;
            var consultingBusinessCheckbox = Consulting_business_checkbox.Checked;
            var humanResourcesBusinessCheckbox = Human_resources_business_checkbox.Checked;
            var constructionBusinessCheckbox = Construction_business_checkbox.Checked;
            var tourismBusinessCheckbox = Tourism_business_checkbox.Checked;
            var ngoBusinessCheckbox = NGO_business_checkbox.Checked;
            var salesBusinessCheckbox = Sales_business_checkbox.Checked;
            var otherBusinessTextbox = Other_textbox.Text;
        }
    }

}
