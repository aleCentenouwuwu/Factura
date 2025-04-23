<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        ComboBox3 = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        ComboBox4 = New ComboBox()
        Label5 = New Label()
        ComboBox5 = New ComboBox()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        cProducto = New DataGridViewTextBoxColumn()
        c3 = New DataGridViewTextBoxColumn()
        c4 = New DataGridViewTextBoxColumn()
        GroupBox4 = New GroupBox()
        GroupBox5 = New GroupBox()
        DataGridView2 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        c5 = New DataGridViewTextBoxColumn()
        c6 = New DataGridViewTextBoxColumn()
        lblSubtotal = New Label()
        txtSubtotal = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        TextBox2 = New TextBox()
        lblImporteCordoba = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(309, 74)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos del cliente"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(9, 42)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(290, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(9, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cliente"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ComboBox3)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(ComboBox2)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(12, 92)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(309, 74)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos generales de factura"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(201, 42)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(98, 23)
        ComboBox3.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(201, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 5
        Label3.Text = "Estado"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(6, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 15)
        Label4.TabIndex = 4
        Label4.Text = "Fecha"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(6, 42)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(84, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(97, 42)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(98, 23)
        ComboBox2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(97, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 0
        Label2.Text = "Tipo"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton2)
        GroupBox3.Controls.Add(RadioButton1)
        GroupBox3.Controls.Add(ComboBox4)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(ComboBox5)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(420, 24)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(338, 74)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "Factura"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.ForeColor = Color.White
        RadioButton2.Location = New Point(221, 18)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(67, 19)
        RadioButton2.TabIndex = 10
        RadioButton2.TabStop = True
        RadioButton2.Text = "Efectivo"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.ForeColor = Color.White
        RadioButton1.Location = New Point(221, 43)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(104, 19)
        RadioButton1.TabIndex = 9
        RadioButton1.TabStop = True
        RadioButton1.Text = "Targeta credito"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormatString = "N2"
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(110, 42)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(98, 23)
        ComboBox4.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(110, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 15)
        Label5.TabIndex = 5
        Label5.Text = "Referencia $"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormatString = "N2"
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(6, 42)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(98, 23)
        ComboBox5.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(6, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 15)
        Label7.TabIndex = 0
        Label7.Text = "Referencia C$"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {cProducto, c3, c4})
        DataGridView1.Location = New Point(9, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(368, 125)
        DataGridView1.TabIndex = 8
        ' 
        ' cProducto
        ' 
        cProducto.HeaderText = "Codigo Producto"
        cProducto.Name = "cProducto"
        ' 
        ' c3
        ' 
        c3.HeaderText = "Producto"
        c3.Name = "c3"
        ' 
        ' c4
        ' 
        c4.HeaderText = "Precio"
        c4.Name = "c4"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(DataGridView1)
        GroupBox4.ForeColor = Color.White
        GroupBox4.Location = New Point(12, 216)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(385, 187)
        GroupBox4.TabIndex = 7
        GroupBox4.TabStop = False
        GroupBox4.Text = "Productos"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(DataGridView2)
        GroupBox5.ForeColor = Color.White
        GroupBox5.Location = New Point(420, 104)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(510, 270)
        GroupBox5.TabIndex = 9
        GroupBox5.TabStop = False
        GroupBox5.Text = "Detalle factura"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, c5, c6})
        DataGridView2.Location = New Point(9, 22)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(495, 225)
        DataGridView2.TabIndex = 8
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Codigo Producto"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Precio unitario"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' c5
        ' 
        c5.HeaderText = "Cantidad"
        c5.Name = "c5"
        ' 
        ' c6
        ' 
        c6.HeaderText = "Importe"
        c6.Name = "c6"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.ForeColor = Color.White
        lblSubtotal.Location = New Point(518, 383)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(51, 15)
        lblSubtotal.TabIndex = 10
        lblSubtotal.Text = "Subtotal"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.ForeColor = Color.White
        txtSubtotal.Location = New Point(648, 380)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(100, 23)
        txtSubtotal.TabIndex = 11
        ' 
        ' TextBox1
        ' 
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(755, 466)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(517, 474)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(648, 466)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 15
        ' 
        ' lblImporteCordoba
        ' 
        lblImporteCordoba.AutoSize = True
        lblImporteCordoba.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        lblImporteCordoba.ForeColor = Color.White
        lblImporteCordoba.Location = New Point(517, 469)
        lblImporteCordoba.Name = "lblImporteCordoba"
        lblImporteCordoba.Size = New Size(78, 15)
        lblImporteCordoba.TabIndex = 14
        lblImporteCordoba.Text = "Importe Total"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(522, 410)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(82, 19)
        CheckBox1.TabIndex = 16
        CheckBox1.Text = "Descuento"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.ForeColor = Color.White
        CheckBox2.Location = New Point(522, 435)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(43, 19)
        CheckBox2.TabIndex = 17
        CheckBox2.Text = "IVA"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.ForeColor = Color.White
        TextBox3.Location = New Point(648, 410)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 18
        ' 
        ' TextBox4
        ' 
        TextBox4.ForeColor = Color.White
        TextBox4.Location = New Point(648, 438)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        ClientSize = New Size(969, 506)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox2)
        Controls.Add(lblImporteCordoba)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(txtSubtotal)
        Controls.Add(lblSubtotal)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Facturacion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Friend WithEvents GroupBox4 As GroupBox

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Friend WithEvents cProducto As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewTextBoxColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents c5 As DataGridViewTextBoxColumn
    Friend WithEvents c6 As DataGridViewTextBoxColumn

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtSubtotal As TextBox

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblImporteCordoba As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
