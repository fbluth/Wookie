using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Wookie.Ressource.Contact.Control
{
    public partial class ucSelectedContact : DevExpress.XtraEditors.XtraUserControl
    {
        private Wookie.Ressource.Database.tblContact SelectedContact = null;

        public ucSelectedContact(Wookie.Ressource.Database.tblContact contact)
        {
            InitializeComponent();

            this.SelectedContact = contact;

            this.picId.Image = Wookie.Tools.Image.Converter.GetImageFromBinary(contact.Picture);
            this.lblName.Text = contact.tlkpContactPrefix.Name+" "+this.FullName;
            this.lblStreet.Text = contact.Street;
            this.lblTown.Text = contact.tlkpCity.Zipcode + " " + contact.tlkpCity.Name;
            this.lblFederalState.Text = contact.tlkpCity.tlkpFederalState.Name;

            Image flag = Wookie.Tools.Image.Converter.GetImageFromBinary(contact.tlkpCity.tlkpFederalState.tlkpCountry.Picture);
            this.lblCountry.ImageOptions.Image = Wookie.Tools.Image.Converter.ResizeImage(flag, 16, 16);
            this.lblCountry.Text = contact.tlkpCity.tlkpFederalState.tlkpCountry.Name;
        }

        /// <summary>
        /// Returns the concated name (Surname + Middlename + Name) from the current selected contact.        
        /// </summary>
        private string FullName
        {
            get
            {
                if (this.SelectedContact == null) return null;

                string fullname = null;

                fullname = this.SelectedContact.Surname != null ? this.SelectedContact.Surname.Trim() : "";
                fullname += this.SelectedContact.Middlename != null ? (" " + this.SelectedContact.Middlename.Trim()) : "";
                fullname += this.SelectedContact.Name != null ? (" " + this.SelectedContact.Name.Trim()) : "";

                return fullname;
            }
        }







        /// <summary>
        /// Returns the concated address (Zipcode + City + Street) from the current selected contact.        
        /// </summary>
        private string Address
        {
            get
            {
                if (this.SelectedContact == null) return "";

                string address = null;

                address = this.SelectedContact.tlkpCity.Zipcode.ToString() + ", ";
                address += this.SelectedContact.tlkpCity.Name + ", ";
                address += this.SelectedContact.Street;

                return address;
            }
        }

        
    }
}
