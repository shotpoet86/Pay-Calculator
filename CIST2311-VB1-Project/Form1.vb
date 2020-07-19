'Austin Parker'
'March 28th, 2020'
'CIST2311 Final Project'

Public Class payCalculatorApp
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles employeeLabel.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles hrsWorkedLabel.Click

        Console.ReadLine()

    End Sub

    Private Sub maritalLabel_Click(sender As Object, e As EventArgs) Handles maritalLabel.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles hrsRateTextBox.TextChanged

    End Sub

    Private Sub payCalculatorApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nameLabel_Click(sender As Object, e As EventArgs) Handles nameLabel.Click

    End Sub

    Private Sub hourlyLabel_Click(sender As Object, e As EventArgs) Handles hourlyLabel.Click

    End Sub

    Private Sub weekInfoLabel_Click(sender As Object, e As EventArgs) Handles weekInfoLabel.Click

    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        'Variables for radio buttons and checkbox'
        Dim youMarried As Boolean = marriedRadioButton.Checked
        Dim youSingle As Boolean = singleRadioButton.Checked
        Dim healthInsurance As Boolean = healthInsuranceCheckBox.Checked


        'variables for health insurance information'
        Dim healthSingle As Double = 60.0
        Dim healthMarried As Double = 100.0
        Dim healthNone As Double = 0.00

        'Determines appropriate information to display based on health insurance checkbox'
        If youMarried = True And healthInsurance = True Then
            healthInsuranceDisplayBox.Text = healthMarried
        ElseIf youSingle = True And healthInsurance = True Then
            healthInsuranceDisplayBox.Text = healthSingle.ToString()
        Else
            healthInsuranceDisplayBox.Text = healthNone.ToString()
        End If

        'variables for gross pay'
        Dim hourlyRate As Double
        Dim hoursWorked As Double
        Dim grossPay As Double

        'Gross overtime pay calculation'
        Double.TryParse(hrsRateTextBox.Text, hourlyRate)
        Double.TryParse(hrsWorkedTextBox.Text, hoursWorked)
        If hoursWorked > 40 Then
            grossPay = (hourlyRate * hoursWorked) + (hoursWorked - 40) * (hourlyRate * 0.5)
            grossPayDisplayBox.Text = grossPay.ToString("N2")
        End If

        'Gross standard pay calculation'
        If hoursWorked < 41 Then
            grossPay = hourlyRate * hoursWorked
            grossPayDisplayBox.Text = grossPay.ToString("N2")
        End If

        'tax calculations'
        Dim dependPrice As Double = 70.0
        Dim dependNumber As Double
        Dim fedTax As Double
        Dim taxablePay As Double
        Double.TryParse(fedTaxDisplayBox.Text, fedTax)
        Double.TryParse(dependentsTextBox.Text, dependNumber)
        Double.TryParse(healthInsuranceDisplayBox.Text, healthInsurance)
        Double.TryParse(netPayDisplayBox.Text, taxablePay)
        If youMarried = True Then
            taxablePay = grossPay - 150 - dependPrice * dependNumber
            grossPayDisplayBox.Text = grossPay.ToString("N2")
            netPayDisplayBox.Text = taxablePay.ToString("N2")
            fedTaxDisplayBox.Text = fedTax.ToString("N2")
            If healthInsurance Then
                taxablePay = taxablePay - 100
                If taxablePay > 800 Then
                    fedTax = (taxablePay - 800) * 0.35 + (800 - 500) * 0.25 + (500 - 200) * 0.15 + 200 * 0.1
                ElseIf taxablePay > 500 Then
                    fedTax = (taxablePay - 500) * 0.25 + (500 - 200) * 0.15 + 200 * 0.1
                ElseIf taxablePay > 200 Then
                    fedTax = (taxablePay - 200) * 0.15 + 200 * 0.1
                Else
                    fedTax = taxablePay * 0.1
                End If
                taxablePay = grossPay - 100 - fedTax
                grossPayDisplayBox.Text = grossPay.ToString("N2")
                netPayDisplayBox.Text = taxablePay.ToString("N2")
                fedTaxDisplayBox.Text = fedTax.ToString("N2")
            End If
        Else
            taxablePay = grossPay - 75.0 - 70.0 * dependNumber
            grossPayDisplayBox.Text = grossPay.ToString("N2")
            netPayDisplayBox.Text = taxablePay.ToString("N2")
            fedTaxDisplayBox.Text = fedTax.ToString("N2")
            If healthInsurance = False Then
                taxablePay = taxablePay - 60

                If taxablePay > 400 Then
                    fedTax = (taxablePay - 400) * 0.35 + (400 - 250) * 0.25 + (250 - 100) * 0.15 + 100 * 0.1
                ElseIf taxablePay > 250 Then
                    fedTax = (taxablePay - 250) * 0.25 + (250 - 100) * 0.15 + 100 * 0.1
                ElseIf taxablePay > 100 Then
                    fedTax = (taxablePay - 100) * 0.15 + 100 * 0.1
                Else
                    fedTax = taxablePay * 0.1
                End If
                taxablePay = grossPay - fedTax
                grossPayDisplayBox.Text = grossPay.ToString("N2")
                netPayDisplayBox.Text = taxablePay.ToString("N2")
                fedTaxDisplayBox.Text = fedTax.ToString("N2")
            End If
        End If

    End Sub

    Private Sub grossPayDisplayBox_TextChanged(sender As Object, e As EventArgs) Handles grossPayDisplayBox.TextChanged

    End Sub

    Private Sub hrsWorkedTextBox_TextChanged(sender As Object, e As EventArgs) Handles hrsWorkedTextBox.TextChanged

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        Me.Close()

    End Sub

    Private Sub dependentsTextBox_TextChanged(sender As Object, e As EventArgs) Handles dependentsTextBox.TextChanged

    End Sub

    Private Sub healthInsuranceCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles healthInsuranceCheckBox.CheckedChanged



    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        'clears all boxes if clear button is pressed'
        nameTextBox.Text = String.Empty
        hrsRateTextBox.Text = String.Empty
        dependentsTextBox.Text = String.Empty
        hrsWorkedTextBox.Text = String.Empty
        grossPayDisplayBox.Text = String.Empty
        healthInsuranceDisplayBox.Text = String.Empty
        fedTaxDisplayBox.Text = String.Empty
        netPayDisplayBox.Text = String.Empty

    End Sub

    Private Sub healthInsuranceDisplayBox_TextChanged(sender As Object, e As EventArgs) Handles healthInsuranceDisplayBox.TextChanged

    End Sub

    Private Sub fedTaxDisplayBox_TextChanged(sender As Object, e As EventArgs) Handles fedTaxDisplayBox.TextChanged

    End Sub

    Private Sub netPayDisplayBox_TextChanged(sender As Object, e As EventArgs) Handles netPayDisplayBox.TextChanged

    End Sub
End Class
