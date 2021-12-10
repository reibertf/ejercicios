Public Class FormEjercicio16

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxpais.SelectedIndexChanged
        cbxestado.Items.Clear()

        If cbxpais.SelectedItem = "Chile" Then
            cbxestado.Items.Add("Metropolitana de Santiago - Gran Santiago")
            cbxestado.Items.Add("Valparaiso - Gran Valparaiso")
            cbxestado.Items.Add("Biobío - Gran Concepción")
            cbxestado.Items.Add("CoquimboGran - La Serena")
            cbxestado.Items.Add("Antofagasta - Antofagasta")
            cbxestado.Items.Add("Tarapacá - Gran Iquique")
            cbxestado.Items.Add("O'Higgins - Gran Rancgua")
            cbxestado.Items.Add("Araucanía - Gran Temuco")
            cbxestado.Items.Add("Maule - Talca")
            cbxestado.Items.Add("Arica y Parinacota - Arica")
            cbxestado.Items.Add("Los Lagos - Puerto Montt")
            cbxestado.Items.Add("Ñuble - Gran Chillan")
            cbxestado.Items.Add("Atacama - Copiapó")
            cbxestado.Items.Add("Los Rios - Valdivia")
            cbxestado.Items.Add("Magallanes - Punta Arena")
            cbxestado.Items.Add("Aysén - Coyhaique")

        ElseIf cbxpais.SelectedItem = "Venezuela" Then
            cbxestado.Items.Add("Amazonas - Puerto Ayacucho")
            cbxestado.Items.Add("Anzoategui - Barcelona")
            cbxestado.Items.Add("Apure - San Fernando de Apure")
            cbxestado.Items.Add("Aragua - Maracay")
            cbxestado.Items.Add("Barinas - Barinas")
            cbxestado.Items.Add("Bolivar Ciudad de Guayana")
            cbxestado.Items.Add("Carabobo - Valencia")
            cbxestado.Items.Add("Cojedes - San Carlos")
            cbxestado.Items.Add("Delta Amacuro - Tucupita")
            cbxestado.Items.Add("Distrito Capital - Caracas")
            cbxestado.Items.Add("Falcón - Punto Fijo")
            cbxestado.Items.Add("Guárico - San Juan De Los Morros")
            cbxestado.Items.Add("Lara - Barquisimeto")
            cbxestado.Items.Add("Mérida - Merida")
            cbxestado.Items.Add("Miranda - Caracas")
            cbxestado.Items.Add("Monagas - Maturin")
            cbxestado.Items.Add("Nueva Esparta - Por La Mar")
            cbxestado.Items.Add("Portuguesa - Acarigua")
            cbxestado.Items.Add("Sucre - Cumaná")
            cbxestado.Items.Add("Táchira - San Cristobal")
            cbxestado.Items.Add("Trujillo - Valencia")
            cbxestado.Items.Add("La Guaira - Catia La Mar")
            cbxestado.Items.Add("Yaracuy - San Felipe")
            cbxestado.Items.Add("Zulia - Maracaibo")

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub FormEjercicio16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub cbxciudades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxciudades.SelectedIndexChanged


    'End Sub

    Private Sub cbxestado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxestado.SelectedIndexChanged

    End Sub
End Class