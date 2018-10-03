using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using System;

namespace Wookie.Tools.Controls
{
    public class AccordionControl : DevExpress.XtraBars.Navigation.AccordionControl
    {
        public NavigationFrame NavigationFrame { get; set; } = null;

        protected override AccordionControlForm CreatePopupForm(AccordionControlElement elem)
        {
            AccordionControlForm form = base.CreatePopupForm(elem);
            form.Activated += Form_Activated;
            return form;
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            AccordionControlForm form = sender as AccordionControlForm;

            if (form != null && this.NavigationFrame != null)
            {
                //Adjust width of the popup form
                form.AccordionControl.Width = 150;

                //Adjust height of the popup form, so that it uses the whole height of the ParentForm
                //form.AccordionControl.Height = this.ClientSize.Height - (form.AccordionControl.Margin.Top + form.AccordionControl.Margin.Bottom);
                form.AccordionControl.Height = this.NavigationFrame.Height- (form.AccordionControl.Margin.Top + form.AccordionControl.Margin.Bottom);
                form.CalcContent();

                //Set the popup location for the popup form
                form.SetDesktopLocation(form.Location.X, this.PointToScreen(new System.Drawing.Point(0, 0)).Y);
            }
        }
    }
}
