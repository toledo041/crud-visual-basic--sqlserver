<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateUserForm
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
        Label4 = New Label()
        password2Txt = New TextBox()
        registerBtn = New Button()
        Label2 = New Label()
        passwordTxt = New TextBox()
        userTxt = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 15)
        Label4.TabIndex = 24
        Label4.Text = "Confirm your password"
        ' 
        ' password2Txt
        ' 
        password2Txt.Location = New Point(15, 142)
        password2Txt.Name = "password2Txt"
        password2Txt.PasswordChar = "*"c
        password2Txt.Size = New Size(224, 23)
        password2Txt.TabIndex = 21
        ' 
        ' registerBtn
        ' 
        registerBtn.Location = New Point(47, 181)
        registerBtn.Name = "registerBtn"
        registerBtn.Size = New Size(134, 23)
        registerBtn.TabIndex = 22
        registerBtn.Text = "Update password"
        registerBtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 19
        Label2.Text = "Password"
        ' 
        ' passwordTxt
        ' 
        passwordTxt.Location = New Point(15, 84)
        passwordTxt.Name = "passwordTxt"
        passwordTxt.PasswordChar = "*"c
        passwordTxt.Size = New Size(224, 23)
        passwordTxt.TabIndex = 20
        ' 
        ' userTxt
        ' 
        userTxt.Location = New Point(12, 29)
        userTxt.Name = "userTxt"
        userTxt.Size = New Size(227, 23)
        userTxt.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 16
        Label1.Text = "User"
        ' 
        ' UpdateUserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(245, 215)
        Controls.Add(Label4)
        Controls.Add(password2Txt)
        Controls.Add(registerBtn)
        Controls.Add(Label2)
        Controls.Add(passwordTxt)
        Controls.Add(userTxt)
        Controls.Add(Label1)
        Name = "UpdateUserForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UpdateUserForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents password2Txt As TextBox
    Friend WithEvents registerBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents userTxt As TextBox
    Friend WithEvents Label1 As Label
End Class
