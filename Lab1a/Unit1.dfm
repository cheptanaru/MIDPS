object Form1: TForm1
  Left = 192
  Top = 169
  Width = 696
  Height = 480
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 248
    Top = 48
    Width = 32
    Height = 13
    Caption = 'Label1'
  end
  object Button1: TButton
    Left = 200
    Top = 120
    Width = 121
    Height = 49
    Caption = 'Incrementeaza'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 200
    Top = 192
    Width = 121
    Height = 49
    Caption = 'Decrementeaza'
    TabOrder = 1
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 224
    Top = 264
    Width = 75
    Height = 25
    Caption = 'Exit'
    TabOrder = 2
    OnClick = Button3Click
  end
  object Edit1: TEdit
    Left = 368
    Top = 160
    Width = 49
    Height = 21
    TabOrder = 3
    Text = 'Edit1'
  end
end
