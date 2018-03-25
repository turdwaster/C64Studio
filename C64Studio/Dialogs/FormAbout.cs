﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C64Studio
{
  public partial class FormAbout : Form
  {
    public FormAbout()
    {
      InitializeComponent();

      labelInfo.Text = labelInfo.Text.Replace( "<v>", StudioCore.StudioVersion );
    }

    private void btnOK_Click( object sender, EventArgs e )
    {
      Close();
    }

  }
}
