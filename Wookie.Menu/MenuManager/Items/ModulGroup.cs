﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Svg;
using System.Data.Linq;
using Wookie.Tools.Image;
using DevExpress.XtraBars.Navigation;

namespace Wookie.Menu.MenuManager
{
    public class ModulGroup
    {
        private string caption = null;
        private SvgImage svgImage = null;
        private ModulCollection moduls = null;
        private AccordionControlElement accordionControlElement = new AccordionControlElement();
        private MenuManager menuManager = null;

        public ModulGroup(string caption)
        {
            this.moduls = new ModulCollection(this.MenuManager,this);
            this.caption = caption;            
        }

        public ModulGroup(string caption, SvgImage svgImage):this(caption)
        {
            this.svgImage = svgImage;
        }

        public ModulGroup(string caption, Binary binary):this(caption)
        {
            this.svgImage = Converter.GetSvgImageFromBinary(binary);
        }

        public string Caption
        {
            get { return this.caption; }
            set { if (accordionControlElement != null) accordionControlElement.Text = value; this.caption = value; }
        }

        public SvgImage SvgImage
        {
            get { return this.svgImage; }
            set { if (this.accordionControlElement != null) accordionControlElement.ImageOptions.SvgImage = value; this.svgImage = value; }
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set { this.menuManager = value; this.moduls.MenuManager = value; }
        }

        public ModulCollection Moduls
        {
            get { return this.moduls; }          
        }

        public AccordionControlElement AccordionControlElement
        {
            get
            {
                if (accordionControlElement == null)
                {
                    accordionControlElement = new AccordionControlElement();
                    accordionControlElement.Text = this.caption;
                    accordionControlElement.ImageOptions.SvgImage = this.svgImage;                    
                }
                return accordionControlElement;
            }
        }
    }
}