unit UnitTest;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
  private
    function IsEqual(const Value1, Value2: string): Boolean;
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

uses
  ComObj;

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
  if Self.IsEqual('breno', 'martinusso') then
    ShowMessage('"breno" and "martinusso" are not equal');

  if Self.IsEqual('breno', 'breno') then
    ShowMessage('"breno" and "breno" are equal');
end;

function TForm1.IsEqual(const Value1, Value2: string): Boolean;
var
  olObjeto: OleVariant;
begin
  // bool isEqual(string value1, string value2);
  olObjeto := CreateOleObject('NativeDLL.Test');
  try
    Result := olObjeto.isEqual(Value1, Value2);
  finally
    olObjeto := null;
  end;
end;

end.
