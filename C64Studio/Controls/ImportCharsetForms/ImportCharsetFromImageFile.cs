﻿using C64Studio.Formats;
using C64Studio.Types;
using GR.Memory;
using RetroDevStudio;
using RetroDevStudio.Formats;
using RetroDevStudio.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static C64Studio.BaseDocument;

namespace C64Studio.Controls
{
  public partial class ImportCharsetFromImageFile : ImportCharsetFormBase
  {
    public ImportCharsetFromImageFile() :
      base( null )
    { 
    }



    public ImportCharsetFromImageFile( StudioCore Core ) :
      base( Core )
    {
      InitializeComponent();
    }



    public override bool HandleImport( CharsetProject Charset, CharsetEditor Editor )
    {
      string filename;

      if ( !Editor.OpenFile( "Import Charset from Image", C64Studio.Types.Constants.FILEFILTER_IMAGE_FILES, out filename ) )
      {
        return false;
      }

      GR.Image.FastImage imgClip = Core.Imaging.LoadImageFromFile( filename );

      Editor.characterEditor.PasteImage( filename, imgClip, false );
      return true;
    }



  }
}
