<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        userTxt = New TextBox()
        passwordTxt = New TextBox()
        Label2 = New Label()
        loginBtn = New Button()
        registerBtn = New Button()
        updateBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "User"
        ' 
        ' userTxt
        ' 
        userTxt.Location = New Point(13, 27)
        userTxt.Name = "userTxt"
        userTxt.Size = New Size(227, 23)
        userTxt.TabIndex = 1
        ' 
        ' passwordTxt
        ' 
        passwordTxt.Location = New Point(10, 83)
        passwordTxt.Name = "passwordTxt"
        passwordTxt.PasswordChar = "*"c
        passwordTxt.Size = New Size(224, 23)
        passwordTxt.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' loginBtn
        ' 
        loginBtn.Location = New Point(36, 125)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(75, 23)
        loginBtn.TabIndex = 4
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = True
        ' 
        ' registerBtn
        ' 
        registerBtn.Location = New Point(123, 125)
        registerBtn.Name = "registerBtn"
        registerBtn.Size = New Size(75, 23)
        registerBtn.TabIndex = 5
        registerBtn.Text = "Register"
        registerBtn.UseVisualStyleBackColor = True
        ' 
        ' updateBtn
        ' 
        updateBtn.Location = New Point(36, 154)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(162, 23)
        updateBtn.TabIndex = 6
        updateBtn.Text = "Forgot your password"
        updateBtn.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(241, 203)
        Controls.Add(updateBtn)
        Controls.Add(registerBtn)
        Controls.Add(loginBtn)
        Controls.Add(Label2)
        Controls.Add(passwordTxt)
        Controls.Add(userTxt)
        Controls.Add(Label1)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents userTxt As TextBox
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents registerBtn As Button
    Friend WithEvents updateBtn As Button
End Class
