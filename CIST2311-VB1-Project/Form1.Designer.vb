<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payCalculatorApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.employeeLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.hourlyLabel = New System.Windows.Forms.Label()
        Me.maritalLabel = New System.Windows.Forms.Label()
        Me.singleRadioButton = New System.Windows.Forms.RadioButton()
        Me.marriedRadioButton = New System.Windows.Forms.RadioButton()
        Me.healthInsuranceCheckBox = New System.Windows.Forms.CheckBox()
        Me.dependLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.hrsRateTextBox = New System.Windows.Forms.TextBox()
        Me.dependentsTextBox = New System.Windows.Forms.TextBox()
        Me.weekInfoLabel = New System.Windows.Forms.Label()
        Me.hrsWorkedLabel = New System.Windows.Forms.Label()
        Me.weekPayLabel = New System.Windows.Forms.Label()
        Me.grossPayLabel = New System.Windows.Forms.Label()
        Me.healthInsuranceLabel = New System.Windows.Forms.Label()
        Me.fedTaxLabel = New System.Windows.Forms.Label()
        Me.hrsWorkedTextBox = New System.Windows.Forms.TextBox()
        Me.netPayLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.healthInsuranceDisplayBox = New System.Windows.Forms.TextBox()
        Me.fedTaxDisplayBox = New System.Windows.Forms.TextBox()
        Me.netPayDisplayBox = New System.Windows.Forms.TextBox()
        Me.grossPayDisplayBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'employeeLabel
        '
        Me.employeeLabel.AutoSize = true
        Me.employeeLabel.Location = New System.Drawing.Point(12, 9)
        Me.employeeLabel.Name = "employeeLabel"
        Me.employeeLabel.Size = New System.Drawing.Size(108, 13)
        Me.employeeLabel.TabIndex = 0
        Me.employeeLabel.Text = "Employee Information"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = true
        Me.nameLabel.Location = New System.Drawing.Point(70, 28)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(38, 13)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "&Name:"
        '
        'hourlyLabel
        '
        Me.hourlyLabel.AutoSize = true
        Me.hourlyLabel.Location = New System.Drawing.Point(42, 54)
        Me.hourlyLabel.Name = "hourlyLabel"
        Me.hourlyLabel.Size = New System.Drawing.Size(66, 13)
        Me.hourlyLabel.TabIndex = 2
        Me.hourlyLabel.Text = "Hourly &Rate:"
        '
        'maritalLabel
        '
        Me.maritalLabel.AutoSize = true
        Me.maritalLabel.Location = New System.Drawing.Point(12, 94)
        Me.maritalLabel.Name = "maritalLabel"
        Me.maritalLabel.Size = New System.Drawing.Size(71, 13)
        Me.maritalLabel.TabIndex = 3
        Me.maritalLabel.Text = "Marital Status"
        '
        'singleRadioButton
        '
        Me.singleRadioButton.AutoSize = true
        Me.singleRadioButton.Location = New System.Drawing.Point(15, 110)
        Me.singleRadioButton.Name = "singleRadioButton"
        Me.singleRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.singleRadioButton.TabIndex = 4
        Me.singleRadioButton.TabStop = true
        Me.singleRadioButton.Text = "&Single"
        Me.singleRadioButton.UseVisualStyleBackColor = true
        '
        'marriedRadioButton
        '
        Me.marriedRadioButton.AutoSize = true
        Me.marriedRadioButton.Location = New System.Drawing.Point(15, 133)
        Me.marriedRadioButton.Name = "marriedRadioButton"
        Me.marriedRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.marriedRadioButton.TabIndex = 5
        Me.marriedRadioButton.TabStop = true
        Me.marriedRadioButton.Text = "&Married"
        Me.marriedRadioButton.UseVisualStyleBackColor = true
        '
        'healthInsuranceCheckBox
        '
        Me.healthInsuranceCheckBox.AutoSize = true
        Me.healthInsuranceCheckBox.Location = New System.Drawing.Point(114, 130)
        Me.healthInsuranceCheckBox.Name = "healthInsuranceCheckBox"
        Me.healthInsuranceCheckBox.Size = New System.Drawing.Size(113, 17)
        Me.healthInsuranceCheckBox.TabIndex = 6
        Me.healthInsuranceCheckBox.Text = "Health Insurance?"
        Me.healthInsuranceCheckBox.UseVisualStyleBackColor = true
        '
        'dependLabel
        '
        Me.dependLabel.AutoSize = true
        Me.dependLabel.Location = New System.Drawing.Point(111, 107)
        Me.dependLabel.Name = "dependLabel"
        Me.dependLabel.Size = New System.Drawing.Size(68, 13)
        Me.dependLabel.TabIndex = 7
        Me.dependLabel.Text = "&Dependents:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(114, 25)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(154, 20)
        Me.nameTextBox.TabIndex = 8
        '
        'hrsRateTextBox
        '
        Me.hrsRateTextBox.Location = New System.Drawing.Point(114, 51)
        Me.hrsRateTextBox.Name = "hrsRateTextBox"
        Me.hrsRateTextBox.Size = New System.Drawing.Size(59, 20)
        Me.hrsRateTextBox.TabIndex = 9
        '
        'dependentsTextBox
        '
        Me.dependentsTextBox.Location = New System.Drawing.Point(185, 104)
        Me.dependentsTextBox.Name = "dependentsTextBox"
        Me.dependentsTextBox.Size = New System.Drawing.Size(29, 20)
        Me.dependentsTextBox.TabIndex = 10
        '
        'weekInfoLabel
        '
        Me.weekInfoLabel.AutoSize = true
        Me.weekInfoLabel.Location = New System.Drawing.Point(36, 167)
        Me.weekInfoLabel.Name = "weekInfoLabel"
        Me.weekInfoLabel.Size = New System.Drawing.Size(98, 13)
        Me.weekInfoLabel.TabIndex = 11
        Me.weekInfoLabel.Text = "Weekly Information"
        '
        'hrsWorkedLabel
        '
        Me.hrsWorkedLabel.AutoSize = true
        Me.hrsWorkedLabel.Location = New System.Drawing.Point(57, 190)
        Me.hrsWorkedLabel.Name = "hrsWorkedLabel"
        Me.hrsWorkedLabel.Size = New System.Drawing.Size(79, 13)
        Me.hrsWorkedLabel.TabIndex = 12
        Me.hrsWorkedLabel.Text = "&Hours Worked:"
        '
        'weekPayLabel
        '
        Me.weekPayLabel.AutoSize = true
        Me.weekPayLabel.Location = New System.Drawing.Point(36, 224)
        Me.weekPayLabel.Name = "weekPayLabel"
        Me.weekPayLabel.Size = New System.Drawing.Size(64, 13)
        Me.weekPayLabel.TabIndex = 13
        Me.weekPayLabel.Text = "Weekly Pay"
        '
        'grossPayLabel
        '
        Me.grossPayLabel.AutoSize = true
        Me.grossPayLabel.Location = New System.Drawing.Point(81, 239)
        Me.grossPayLabel.Name = "grossPayLabel"
        Me.grossPayLabel.Size = New System.Drawing.Size(58, 13)
        Me.grossPayLabel.TabIndex = 14
        Me.grossPayLabel.Text = "Gross Pay:"
        '
        'healthInsuranceLabel
        '
        Me.healthInsuranceLabel.AutoSize = true
        Me.healthInsuranceLabel.Location = New System.Drawing.Point(48, 265)
        Me.healthInsuranceLabel.Name = "healthInsuranceLabel"
        Me.healthInsuranceLabel.Size = New System.Drawing.Size(91, 13)
        Me.healthInsuranceLabel.TabIndex = 15
        Me.healthInsuranceLabel.Text = "Health Insurance:"
        '
        'fedTaxLabel
        '
        Me.fedTaxLabel.AutoSize = true
        Me.fedTaxLabel.Location = New System.Drawing.Point(73, 291)
        Me.fedTaxLabel.Name = "fedTaxLabel"
        Me.fedTaxLabel.Size = New System.Drawing.Size(66, 13)
        Me.fedTaxLabel.TabIndex = 16
        Me.fedTaxLabel.Text = "Federal Tax:"
        '
        'hrsWorkedTextBox
        '
        Me.hrsWorkedTextBox.Location = New System.Drawing.Point(142, 187)
        Me.hrsWorkedTextBox.Name = "hrsWorkedTextBox"
        Me.hrsWorkedTextBox.Size = New System.Drawing.Size(59, 20)
        Me.hrsWorkedTextBox.TabIndex = 17
        '
        'netPayLabel
        '
        Me.netPayLabel.AutoSize = true
        Me.netPayLabel.Location = New System.Drawing.Point(91, 317)
        Me.netPayLabel.Name = "netPayLabel"
        Me.netPayLabel.Size = New System.Drawing.Size(48, 13)
        Me.netPayLabel.TabIndex = 18
        Me.netPayLabel.Text = "Net Pay:"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(8, 398)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 19
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = true
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(98, 398)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 20
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = true
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(185, 398)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 21
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = true
        '
        'healthInsuranceDisplayBox
        '
        Me.healthInsuranceDisplayBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.healthInsuranceDisplayBox.Location = New System.Drawing.Point(145, 262)
        Me.healthInsuranceDisplayBox.Name = "healthInsuranceDisplayBox"
        Me.healthInsuranceDisplayBox.Size = New System.Drawing.Size(100, 20)
        Me.healthInsuranceDisplayBox.TabIndex = 22
        '
        'fedTaxDisplayBox
        '
        Me.fedTaxDisplayBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.fedTaxDisplayBox.Location = New System.Drawing.Point(145, 288)
        Me.fedTaxDisplayBox.Name = "fedTaxDisplayBox"
        Me.fedTaxDisplayBox.Size = New System.Drawing.Size(100, 20)
        Me.fedTaxDisplayBox.TabIndex = 23
        '
        'netPayDisplayBox
        '
        Me.netPayDisplayBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.netPayDisplayBox.Location = New System.Drawing.Point(145, 314)
        Me.netPayDisplayBox.Name = "netPayDisplayBox"
        Me.netPayDisplayBox.Size = New System.Drawing.Size(100, 20)
        Me.netPayDisplayBox.TabIndex = 24
        '
        'grossPayDisplayBox
        '
        Me.grossPayDisplayBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.grossPayDisplayBox.Location = New System.Drawing.Point(145, 236)
        Me.grossPayDisplayBox.Name = "grossPayDisplayBox"
        Me.grossPayDisplayBox.Size = New System.Drawing.Size(100, 20)
        Me.grossPayDisplayBox.TabIndex = 25
        '
        'payCalculatorApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 438)
        Me.Controls.Add(Me.grossPayDisplayBox)
        Me.Controls.Add(Me.netPayDisplayBox)
        Me.Controls.Add(Me.fedTaxDisplayBox)
        Me.Controls.Add(Me.healthInsuranceDisplayBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.netPayLabel)
        Me.Controls.Add(Me.hrsWorkedTextBox)
        Me.Controls.Add(Me.fedTaxLabel)
        Me.Controls.Add(Me.healthInsuranceLabel)
        Me.Controls.Add(Me.grossPayLabel)
        Me.Controls.Add(Me.weekPayLabel)
        Me.Controls.Add(Me.hrsWorkedLabel)
        Me.Controls.Add(Me.weekInfoLabel)
        Me.Controls.Add(Me.dependentsTextBox)
        Me.Controls.Add(Me.hrsRateTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.dependLabel)
        Me.Controls.Add(Me.healthInsuranceCheckBox)
        Me.Controls.Add(Me.marriedRadioButton)
        Me.Controls.Add(Me.singleRadioButton)
        Me.Controls.Add(Me.maritalLabel)
        Me.Controls.Add(Me.hourlyLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.employeeLabel)
        Me.Name = "payCalculatorApp"
        Me.Text = "Pay Calculator"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents employeeLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents hourlyLabel As Label
    Friend WithEvents maritalLabel As Label
    Friend WithEvents singleRadioButton As RadioButton
    Friend WithEvents marriedRadioButton As RadioButton
    Friend WithEvents healthInsuranceCheckBox As CheckBox
    Friend WithEvents dependLabel As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents hrsRateTextBox As TextBox
    Friend WithEvents dependentsTextBox As TextBox
    Friend WithEvents weekInfoLabel As Label
    Friend WithEvents hrsWorkedLabel As Label
    Friend WithEvents weekPayLabel As Label
    Friend WithEvents grossPayLabel As Label
    Friend WithEvents healthInsuranceLabel As Label
    Friend WithEvents fedTaxLabel As Label
    Friend WithEvents hrsWorkedTextBox As TextBox
    Friend WithEvents netPayLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents healthInsuranceDisplayBox As TextBox
    Friend WithEvents fedTaxDisplayBox As TextBox
    Friend WithEvents netPayDisplayBox As TextBox
    Friend WithEvents grossPayDisplayBox As TextBox
End Class
