<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterUserForm
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
        registerBtn = New Button()
        Label2 = New Label()
        passwordTxt = New TextBox()
        userTxt = New TextBox()
        Label1 = New Label()
        emailTxt = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        password2Txt = New TextBox()
        SuspendLayout()
        ' 
        ' registerBtn
        ' 
        registerBtn.Location = New Point(71, 225)
        registerBtn.Name = "registerBtn"
        registerBtn.Size = New Size(75, 23)
        registerBtn.TabIndex = 11
        registerBtn.Text = "Register"
        registerBtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 9
        Label2.Text = "Password"
        ' 
        ' passwordTxt
        ' 
        passwordTxt.Location = New Point(12, 131)
        passwordTxt.Name = "passwordTxt"
        passwordTxt.PasswordChar = "*"c
        passwordTxt.Size = New Size(224, 23)
        passwordTxt.TabIndex = 9
        ' 
        ' userTxt
        ' 
        userTxt.Location = New Point(12, 27)
        userTxt.Name = "userTxt"
        userTxt.Size = New Size(227, 23)
        userTxt.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 6
        Label1.Text = "User"
        ' 
        ' emailTxt
        ' 
        emailTxt.Location = New Point(12, 78)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(227, 23)
        emailTxt.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 12
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 15)
        Label4.TabIndex = 15
        Label4.Text = "Confirm your password"
        ' 
        ' password2Txt
        ' 
        password2Txt.Location = New Point(12, 189)
        password2Txt.Name = "password2Txt"
        password2Txt.PasswordChar = "*"c
        password2Txt.Size = New Size(224, 23)
        password2Txt.TabIndex = 10
        ' 
        ' RegisterUserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(244, 260)
        Controls.Add(Label4)
        Controls.Add(password2Txt)
        Controls.Add(emailTxt)
        Controls.Add(Label3)
        Controls.Add(registerBtn)
        Controls.Add(Label2)
        Controls.Add(passwordTxt)
        Controls.Add(userTxt)
        Controls.Add(Label1)
        Name = "RegisterUserForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register user"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents registerBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents userTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents password2Txt As TextBox
End Class
