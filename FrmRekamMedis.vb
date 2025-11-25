Public Class FrmRekamMedis
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmRekamMedis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_CariPasien.Rows.Add("RM202405223001", "Sakit Kepala")
        DataGridView_CariPasien.Rows.Add("RM202405223002", "Demam")
        DataGridView_CariPasien.Rows.Add("RM202405223003", "Demam")

        DataGridView_ResepObat.Rows.Add("Paracetamol 500mg", "1    2    1", 1)
        DataGridView_ResepObat.Rows.Add("Amoxicillin 500mg", "1    1    2", 1)

    End Sub
End Class