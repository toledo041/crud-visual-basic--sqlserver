<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        NameTxt = New TextBox()
        EmailTxt = New TextBox()
        PhoneTxt = New TextBox()
        AdressTxt = New TextBox()
        IdNumberTxt = New TextBox()
        AccionBtn = New Button()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 3
        Label4.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 15)
        Label5.TabIndex = 4
        Label5.Text = "Identification number"
        ' 
        ' NameTxt
        ' 
        NameTxt.Location = New Point(20, 27)
        NameTxt.MaxLength = 50
        NameTxt.Name = "NameTxt"
        NameTxt.Size = New Size(402, 23)
        NameTxt.TabIndex = 5
        ' 
        ' EmailTxt
        ' 
        EmailTxt.Location = New Point(20, 80)
        EmailTxt.MaxLength = 50
        EmailTxt.Name = "EmailTxt"
        EmailTxt.Size = New Size(402, 23)
        EmailTxt.TabIndex = 6
        ' 
        ' PhoneTxt
        ' 
        PhoneTxt.Location = New Point(18, 135)
        PhoneTxt.MaxLength = 10
        PhoneTxt.Name = "PhoneTxt"
        PhoneTxt.Size = New Size(404, 23)
        PhoneTxt.TabIndex = 7
        ' 
        ' AdressTxt
        ' 
        AdressTxt.Location = New Point(17, 198)
        AdressTxt.MaxLength = 50
        AdressTxt.Name = "AdressTxt"
        AdressTxt.Size = New Size(402, 23)
        AdressTxt.TabIndex = 8
        ' 
        ' IdNumberTxt
        ' 
        IdNumberTxt.Location = New Point(17, 254)
        IdNumberTxt.MaxLength = 50
        IdNumberTxt.Name = "IdNumberTxt"
        IdNumberTxt.Size = New Size(399, 23)
        IdNumberTxt.TabIndex = 9
        ' 
        ' AccionBtn
        ' 
        AccionBtn.Location = New Point(165, 357)
        AccionBtn.Name = "AccionBtn"
        AccionBtn.Size = New Size(75, 23)
        AccionBtn.TabIndex = 10
        AccionBtn.Text = "Save"
        AccionBtn.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 291)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 15)
        Label6.TabIndex = 11
        Label6.Text = "Sector"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(17, 309)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(399, 23)
        ComboBox1.TabIndex = 12
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 400)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(AccionBtn)
        Controls.Add(IdNumberTxt)
        Controls.Add(AdressTxt)
        Controls.Add(PhoneTxt)
        Controls.Add(EmailTxt)
        Controls.Add(NameTxt)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register company"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents PhoneTxt As TextBox
    Friend WithEvents AdressTxt As TextBox
    Friend WithEvents IdNumberTxt As TextBox
    Friend WithEvents AccionBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
