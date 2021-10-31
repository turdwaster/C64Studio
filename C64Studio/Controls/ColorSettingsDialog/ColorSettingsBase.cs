﻿using RetroDevStudio;
using RetroDevStudio.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C64Studio.Controls
{
  public partial class ColorSettingsBase : UserControl
  {
    public StudioCore                   Core = null;
    public ColorSettings                Colors = null;

    protected ColorType                 _CurrentColorType;
    protected int                       _CustomColor = 1;


    public delegate void PaletteModifiedHandler( ColorSettings Colors, int CustomColor );
    public delegate void ColorsModifiedHandler( ColorType Color, ColorSettings Colors, int CustomColor );
    public delegate void ColorSelectedHandler( ColorType Color );
    public delegate void ExchangeColorsHandler( ColorType Color1, ColorType Color2 );

    public event PaletteModifiedHandler PaletteModified;
    public event ColorsModifiedHandler  ColorsModified;
    public event ColorSelectedHandler   SelectedColorChanged;
    public event ExchangeColorsHandler  ColorsExchanged;



    public virtual int CustomColor
    {
      get; set;
    }


   
    public virtual ColorType SelectedColor
    {
      get
      {
        return _CurrentColorType;
      }
      set
      {
        _CurrentColorType = value;
      }
    }



    public ColorSettingsBase()
    {
      InitializeComponent();
    }



    public ColorSettingsBase( StudioCore Core, ColorSettings Colors, int CustomColor )
    {
      this.Colors       = new ColorSettings( Colors );
      this.Core         = Core;
      this.CustomColor  = CustomColor;

      InitializeComponent();
    }



    protected void RaisePaletteModifiedEvent()
    {
      if ( PaletteModified != null )
      {
        PaletteModified( Colors, CustomColor );
      }
    }



    protected void RaiseColorsModifiedEvent( ColorType Color )
    {
      if ( ColorsModified != null )
      {
        ColorsModified( Color, Colors, CustomColor );
      }
    }



    protected void RaiseColorSelectedEvent()
    {
      if ( SelectedColorChanged != null )
      {
        SelectedColorChanged( _CurrentColorType );
      }
    }



    protected void RaiseColorsExchangedEvent( ColorType Color1, ColorType Color2 )
    {
      if ( ColorsExchanged != null )
      {
        ColorsExchanged( Color1, Color2 );
      }
    }



    public virtual void ColorChanged( ColorType Color, int Value )
    {
    }



    public void PaletteChanged( Palette Palette )
    {
      Colors.Palette = new Palette( Palette );
      Invalidate();
    }



  }
}
