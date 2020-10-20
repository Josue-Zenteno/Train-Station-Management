Public Class Management

    'Auxiliar objects that will allow us to complete the querys

    Private tr As Trip
    Private tt As TrainType
    Private t As Train
    Private p As Product
    Private pr As Price
    Private selection As String

    'Functions due to actions

    Private Sub btnSelectTableManagement_Click(sender As Object, e As EventArgs) Handles btnSelectTableManagement.Click

        'Auxiliar objects
        Me.tr = New Trip
        Dim trAux As Trip

        Me.tt = New TrainType
        Dim ttAux As TrainType

        Me.t = New Train
        Dim tAux As Train

        Me.p = New Product
        Dim pAux As Product

        Me.pr = New Price
        Dim prAux As Price

        'Allow to the user to use the other buttons
        btnUpdateManagement.Enabled = True
        btnDeleteManagement.Enabled = True
        btnInsertManagement.Enabled = True

        'Selection of what do we want to manage
        selection = Me.cmbOptionTableManagement.SelectedItem
        Select Case selection

            Case "Trips"
                'Main functionality
                Try
                    Me.tr.ReadAllTrips(Main.fileName)
                    Me.lstTableInfo1Management.Items.Clear()
                    Me.lstTableInfo2Management.Items.Clear()
                    Me.lstTableInfo3Management.Items.Clear()

                    For Each trAux In Me.tr.trDAO.Trips
                        Me.lstTableInfo1Management.Items.Add(trAux.tripDate)
                        Me.lstTableInfo2Management.Items.Add(trAux.tripTrain.TrainID)
                        Me.lstTableInfo3Management.Items.Add(trAux.tripProduct.ProductID)
                    Next

                    'Furniture
                    lblAttribute1Management.Visible = True
                    lblAttribute2Management.Visible = True
                    lblAttribute3Management.Visible = True
                    lblAttribute4Management.Visible = True

                    txtAttributeValue1Management.Visible = True
                    txtAttributeValue2Management.Visible = True
                    txtAttributeValue3Management.Visible = True
                    txtAttributeValue4Management.Visible = True

                    lblAttribute1Management.Text = "Trip Date :"
                    lblAttribute2Management.Text = "Train : "
                    lblAttribute3Management.Text = "Product : "
                    lblAttribute4Management.Text = "Transported Tons : "

                    If lstTableInfo1Management.Items.Count <> 0 Then
                        lstTableInfo1Management.SelectedIndex = 0
                        lstTableInfo2Management.SelectedIndex = 0
                        lstTableInfo3Management.SelectedIndex = 0
                        btnViewInfoManagement.Enabled = True
                    Else
                        btnViewInfoManagement.Enabled = False
                    End If

                    lblDelst1Management.Visible = True
                    lblDelst2Management.Visible = True
                    lblDelst3Management.Visible = True

                    lblDelst1Management.Text = "Trip Dates"
                    lblDelst2Management.Text = "Trains ID"
                    lblDelst3Management.Text = "Products ID"
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btnDeleteManagement.Enabled = False
                    btnInsertManagement.Enabled = False
                    btnUpdateManagement.Enabled = False
                    btnViewInfoManagement.Enabled = False
                End Try



            Case "TrainTypes"
                'Main functionality
                Try
                    Me.tt.ReadAllType(Main.fileName)
                    Me.lstTableInfo1Management.Items.Clear()
                    Me.lstTableInfo2Management.Items.Clear()
                    Me.lstTableInfo3Management.Items.Clear()

                    For Each ttAux In Me.tt.ttDAO.TrainTypes
                        Me.lstTableInfo1Management.Items.Add(ttAux.TypeID)
                    Next

                    'Furniture

                    lblAttribute4Management.Visible = False
                    lblAttribute1Management.Visible = True
                    lblAttribute2Management.Visible = True
                    lblAttribute3Management.Visible = True

                    txtAttributeValue4Management.Visible = False
                    txtAttributeValue1Management.Visible = True
                    txtAttributeValue2Management.Visible = True
                    txtAttributeValue3Management.Visible = True

                    lblAttribute1Management.Text = "Train Type ID :"
                    lblAttribute2Management.Text = "Descriptor : "
                    lblAttribute3Management.Text = "Maximum Capacity : "

                    If lstTableInfo1Management.Items.Count <> 0 Then
                        lstTableInfo1Management.SelectedIndex = 0
                        btnViewInfoManagement.Enabled = True
                    Else
                        btnViewInfoManagement.Enabled = False
                    End If

                    lblDelst1Management.Visible = True
                    lblDelst2Management.Visible = False
                    lblDelst3Management.Visible = False

                    lblDelst1Management.Text = "Train Types ID"
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btnDeleteManagement.Enabled = False
                    btnInsertManagement.Enabled = False
                    btnUpdateManagement.Enabled = False
                    btnViewInfoManagement.Enabled = False
                End Try



            Case "Trains"
                'Main functionality
                Try
                    Me.t.ReadAllTrains(Main.fileName)
                    Me.lstTableInfo1Management.Items.Clear()
                    Me.lstTableInfo2Management.Items.Clear()
                    Me.lstTableInfo3Management.Items.Clear()

                    For Each tAux In Me.t.tDAO.Trains
                        Me.lstTableInfo1Management.Items.Add(tAux.TrainID)
                    Next

                    'Furniture
                    lblAttribute3Management.Visible = False
                    lblAttribute4Management.Visible = False
                    lblAttribute1Management.Visible = True
                    lblAttribute2Management.Visible = True

                    txtAttributeValue3Management.Visible = False
                    txtAttributeValue4Management.Visible = False
                    txtAttributeValue1Management.Visible = True
                    txtAttributeValue2Management.Visible = True

                    lblAttribute1Management.Text = "Train ID :"
                    lblAttribute2Management.Text = "Train Type : "

                    If lstTableInfo1Management.Items.Count <> 0 Then
                        lstTableInfo1Management.SelectedIndex = 0
                        btnViewInfoManagement.Enabled = True
                    Else
                        btnViewInfoManagement.Enabled = False
                    End If

                    lblDelst1Management.Visible = True
                    lblDelst2Management.Visible = False
                    lblDelst3Management.Visible = False

                    lblDelst1Management.Text = "Trains ID"
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btnDeleteManagement.Enabled = False
                    btnInsertManagement.Enabled = False
                    btnUpdateManagement.Enabled = False
                    btnViewInfoManagement.Enabled = False
                End Try



            Case "Prices"
                'Main functionality
                Try
                    Me.pr.ReadAllPrices(Main.fileName)
                    Me.lstTableInfo1Management.Items.Clear()
                    Me.lstTableInfo2Management.Items.Clear()
                    Me.lstTableInfo3Management.Items.Clear()

                    For Each prAux In Me.pr.prDAO.Prices
                        Me.lstTableInfo1Management.Items.Add(prAux.Product.ProductID)
                        Me.lstTableInfo2Management.Items.Add(prAux.PriceDate)
                    Next

                    'Furniture
                    lblAttribute4Management.Visible = False
                    lblAttribute1Management.Visible = True
                    lblAttribute2Management.Visible = True
                    lblAttribute3Management.Visible = True

                    txtAttributeValue4Management.Visible = False
                    txtAttributeValue1Management.Visible = True
                    txtAttributeValue2Management.Visible = True
                    txtAttributeValue3Management.Visible = True

                    lblAttribute1Management.Text = "Product :"
                    lblAttribute2Management.Text = "Price Date : "
                    lblAttribute3Management.Text = "Euros per Ton : "

                    If lstTableInfo1Management.Items.Count <> 0 Then
                        lstTableInfo1Management.SelectedIndex = 0
                        lstTableInfo2Management.SelectedIndex = 0
                        btnViewInfoManagement.Enabled = True
                    Else
                        btnViewInfoManagement.Enabled = False
                    End If

                    lblDelst1Management.Visible = True
                    lblDelst2Management.Visible = True
                    lblDelst3Management.Visible = False

                    lblDelst1Management.Text = "Products ID"
                    lblDelst2Management.Text = "Price Dates"

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btnDeleteManagement.Enabled = False
                    btnInsertManagement.Enabled = False
                    btnUpdateManagement.Enabled = False
                    btnViewInfoManagement.Enabled = False
                End Try



            Case "Products"
                'Main functionality
                Try
                    Me.p.ReadAllProducts(Main.fileName)
                    Me.lstTableInfo1Management.Items.Clear()
                    Me.lstTableInfo2Management.Items.Clear()
                    Me.lstTableInfo3Management.Items.Clear()

                    For Each pAux In Me.p.pDAO.Products
                        Me.lstTableInfo1Management.Items.Add(pAux.ProductID)
                    Next

                    'Furniture

                    lblAttribute3Management.Visible = False
                    lblAttribute4Management.Visible = False
                    lblAttribute1Management.Visible = True
                    lblAttribute2Management.Visible = True

                    txtAttributeValue3Management.Visible = False
                    txtAttributeValue4Management.Visible = False
                    txtAttributeValue1Management.Visible = True
                    txtAttributeValue2Management.Visible = True

                    lblAttribute1Management.Text = "Product ID :"
                    lblAttribute2Management.Text = "Description : "

                    If lstTableInfo1Management.Items.Count <> 0 Then
                        lstTableInfo1Management.SelectedIndex = 0
                        btnViewInfoManagement.Enabled = True
                    Else
                        btnViewInfoManagement.Enabled = False
                    End If

                    lblDelst1Management.Visible = True
                    lblDelst2Management.Visible = False
                    lblDelst3Management.Visible = False

                    lblDelst1Management.Text = "Products ID"
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btnDeleteManagement.Enabled = False
                    btnInsertManagement.Enabled = False
                    btnUpdateManagement.Enabled = False
                    btnViewInfoManagement.Enabled = False
                End Try



        End Select

    End Sub

    'Common tasks Insert Update Delete

    Private Sub btnInsertManagement_Click(sender As Object, e As EventArgs) Handles btnInsertManagement.Click

        Select Case selection
            Case "Trips"
                Try
                    If txtAttributeValue1Management.Text <> String.Empty And txtAttributeValue2Management.Text <> String.Empty And txtAttributeValue3Management.Text <> String.Empty And txtAttributeValue4Management.Text <> String.Empty Then

                        tr = New Trip(Convert.ToDateTime(txtAttributeValue1Management.Text), txtAttributeValue2Management.Text, Integer.Parse(txtAttributeValue3Management.Text))
                        tr.ReadTrip()
                        Me.t = New Train(tr.tripTrain.TrainID)
                        t.ReadTrain()
                        Me.tt = New TrainType(t.tType.TypeID)
                        tt.ReadType()

                        If txtAttributeValue4Management.Text > tt.MaxCapacity Then
                            MessageBox.Show("Be careful! This Train can not deal with that weight", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            tr.tons = Integer.Parse(txtAttributeValue4Management.Text)

                            If tr.SpecialReadTrip() > 0 Then
                                MessageBox.Show("A train can't perform more than one trip per day", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Else
                                Try
                                    If Me.tr.InsertTrip <> 1 Then
                                        MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    Exit Sub
                                End Try
                                Me.lstTableInfo1Management.Items.Add(tr.tripDate)
                                Me.lstTableInfo2Management.Items.Add(tr.tripTrain.TrainID)
                                Me.lstTableInfo3Management.Items.Add(tr.tripProduct.ProductID)
                                btnViewInfoManagement.Enabled = True
                                lstTableInfo1Management.SelectedIndex = 0
                                lstTableInfo2Management.SelectedIndex = 0
                                lstTableInfo3Management.SelectedIndex = 0

                            End If

                        End If

                    Else
                        MessageBox.Show("Id and/or Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "TrainTypes"
                Try
                    If txtAttributeValue1Management.Text <> String.Empty And txtAttributeValue2Management.Text <> String.Empty And txtAttributeValue3Management.Text <> String.Empty Then
                        tt = New TrainType(Integer.Parse(txtAttributeValue1Management.Text))
                        tt.TypeDescriptor = txtAttributeValue2Management.Text
                        tt.MaxCapacity = Convert.ToDouble(txtAttributeValue3Management.Text)
                        Try
                            If Me.tt.InsertType <> 1 Then
                                MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End Try
                        Me.lstTableInfo1Management.Items.Add(tt.TypeID)
                        btnViewInfoManagement.Enabled = True
                        lstTableInfo1Management.SelectedIndex = 0
                    Else
                        MessageBox.Show("Id and/or Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "Trains"
                Try
                    If txtAttributeValue1Management.Text <> String.Empty And txtAttributeValue2Management.Text <> String.Empty Then
                        t = New Train(txtAttributeValue1Management.Text)
                        t.tType.TypeID = Integer.Parse(txtAttributeValue2Management.Text)
                        Try
                            If Me.t.InsertTrain <> 1 Then
                                MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End Try
                        Me.lstTableInfo1Management.Items.Add(t.TrainID)
                        btnViewInfoManagement.Enabled = True
                        lstTableInfo1Management.SelectedIndex = 0
                    Else
                        MessageBox.Show("Id and/or Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "Prices"
                Try
                    If txtAttributeValue1Management.Text <> String.Empty And txtAttributeValue2Management.Text <> String.Empty And txtAttributeValue3Management.Text <> String.Empty Then
                        pr = New Price(Integer.Parse(txtAttributeValue1Management.Text), Convert.ToDateTime(txtAttributeValue2Management.Text))
                        pr.EurosPerTon = Convert.ToDouble(txtAttributeValue3Management.Text)
                        Try
                            If Me.pr.InsertPrice <> 1 Then
                                MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End Try
                        Me.lstTableInfo1Management.Items.Add(pr.Product.ProductID)
                        Me.lstTableInfo2Management.Items.Add(pr.PriceDate)
                        btnViewInfoManagement.Enabled = True
                        lstTableInfo1Management.SelectedIndex = 0
                        lstTableInfo2Management.SelectedIndex = 0
                    Else
                        MessageBox.Show("Id and/or Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "Products"
                Try
                    If txtAttributeValue1Management.Text <> String.Empty And txtAttributeValue2Management.Text <> String.Empty Then
                        p = New Product(Integer.Parse(txtAttributeValue1Management.Text))
                        p.ProductDescription = txtAttributeValue2Management.Text
                        p.ReadProduct()

                        Try
                            If Me.p.InsertProduct <> 1 Then
                                MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End Try
                        Me.lstTableInfo1Management.Items.Add(p.ProductID)
                        btnViewInfoManagement.Enabled = True
                        lstTableInfo1Management.SelectedIndex = 0

                    Else
                        MessageBox.Show("Id and/or Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

        End Select
    End Sub

    Private Sub btnUpdateManagement_Click(sender As Object, e As EventArgs) Handles btnUpdateManagement.Click


        Select Case selection
            Case "Trips"
                Try
                    tr = New Trip(Convert.ToDateTime(txtAttributeValue1Management.Text), txtAttributeValue2Management.Text, Integer.Parse(txtAttributeValue3Management.Text))
                    tr.ReadTrip()
                    Me.t = New Train(tr.tripTrain.TrainID)
                    t.ReadTrain()
                    Me.tt = New TrainType(t.tType.TypeID)
                    tt.ReadType()

                    If Integer.Parse(txtAttributeValue4Management.Text) > tt.MaxCapacity Then
                        MessageBox.Show("Be careful! This Train can not deal with that weight", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        tr.tons = Integer.Parse(txtAttributeValue4Management.Text)

                        Try
                            If Me.tr.UpdateTrip <> 1 Then
                                MessageBox.Show("UPDATE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End Try
                    End If
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "TrainTypes"
                Try
                    tt = New TrainType(Integer.Parse(txtAttributeValue1Management.Text))
                    tt.TypeDescriptor = txtAttributeValue2Management.Text
                    tt.MaxCapacity = Convert.ToDouble(txtAttributeValue3Management.Text)
                    Try
                        If Me.tt.UpdateType <> 1 Then
                            MessageBox.Show("UPDATE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "Trains"
                Try
                    t = New Train(txtAttributeValue1Management.Text)
                    t.tType = New TrainType(Integer.Parse(txtAttributeValue2Management.Text))
                    Try
                        If Me.t.UpdateTrain <> 1 Then
                            MessageBox.Show("UPDATE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "Prices"
                Try
                    pr = New Price(Integer.Parse(txtAttributeValue1Management.Text), Convert.ToDateTime(txtAttributeValue2Management.Text))
                    pr.EurosPerTon = Convert.ToDouble(txtAttributeValue3Management.Text)
                    Try
                        If Me.pr.UpdatePrice <> 1 Then
                            MessageBox.Show("UPDATE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "Products"
                Try
                    p = New Product(Integer.Parse(txtAttributeValue1Management.Text))
                    p.ProductDescription = txtAttributeValue2Management.Text
                    Try
                        If Me.p.UpdateProduct <> 1 Then
                            MessageBox.Show("UPDATE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
        End Select
    End Sub

    Private Sub btnDeleteManagement_Click(sender As Object, e As EventArgs) Handles btnDeleteManagement.Click

        Select Case selection
            Case "Trips"
                Try
                    tr = New Trip(Convert.ToDateTime(txtAttributeValue1Management.Text), txtAttributeValue2Management.Text, Integer.Parse(txtAttributeValue3Management.Text))
                    tr.tons = Integer.Parse(txtAttributeValue4Management.Text)
                    Try
                        If Me.tr.DeleteTrip <> 1 Then
                            MessageBox.Show("DELETE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstTableInfo1Management.Items.Remove(tr.tripDate)
                    Me.lstTableInfo2Management.Items.Remove(tr.tripTrain.TrainID)
                    Me.lstTableInfo3Management.Items.Remove(tr.tripProduct.ProductID)
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "TrainTypes"
                Try
                    tt = New TrainType(Integer.Parse(txtAttributeValue1Management.Text))
                    tt.TypeDescriptor = txtAttributeValue2Management.Text
                    tt.MaxCapacity = Convert.ToDouble(txtAttributeValue3Management.Text)
                    Try
                        If Me.tt.DeleteType <> 1 Then
                            MessageBox.Show("DELETE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstTableInfo1Management.Items.Remove(tt.TypeID)
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "Trains"
                Try
                    t = New Train(txtAttributeValue1Management.Text)
                    t.tType = New TrainType(Integer.Parse(txtAttributeValue2Management.Text))
                    Try
                        If Me.t.DeleteTrain <> 1 Then
                            MessageBox.Show("DELETE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstTableInfo1Management.Items.Remove(t.TrainID)
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "Prices"
                Try
                    pr = New Price(Integer.Parse(txtAttributeValue1Management.Text), Convert.ToDateTime(txtAttributeValue2Management.Text))
                    pr.EurosPerTon = Convert.ToDouble(txtAttributeValue3Management.Text)
                    Try
                        If Me.pr.DeletePrice <> 1 Then
                            MessageBox.Show("DELETE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstTableInfo1Management.Items.Remove(pr.Product.ProductID)
                    Me.lstTableInfo2Management.Items.Remove(pr.PriceDate)
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Case "Products"
                Try
                    p = New Product(Integer.Parse(txtAttributeValue1Management.Text))
                    p.ProductDescription = txtAttributeValue2Management.Text
                    Try
                        If Me.p.DeleteProduct <> 1 Then
                            MessageBox.Show("DELETE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstTableInfo1Management.Items.Remove(p.ProductID)
                Catch ex As Exception
                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
        End Select
        If lstTableInfo1Management.Items.Count = 0 Then
            btnViewInfoManagement.Enabled = False
        End If
    End Sub

    Private Sub btnViewInfoManagement_Click(sender As Object, e As EventArgs) Handles btnViewInfoManagement.Click


        Me.tr = New Trip
        Me.tt = New TrainType
        Me.t = New Train
        Me.p = New Product
        Me.pr = New Price


        Select Case selection

            Case "Trips"
                Me.tr = New Trip(Convert.ToDateTime(lstTableInfo1Management.SelectedItem), lstTableInfo2Management.SelectedItem, Integer.Parse(lstTableInfo3Management.SelectedItem))
                tr.ReadTrip()
                txtAttributeValue1Management.Text = tr.tripDate
                txtAttributeValue2Management.Text = tr.tripTrain.TrainID
                txtAttributeValue3Management.Text = tr.tripProduct.ProductID
                txtAttributeValue4Management.Text = tr.tons

            Case "TrainTypes"
                Me.tt = New TrainType(Integer.Parse(lstTableInfo1Management.SelectedItem))
                tt.ReadType()
                txtAttributeValue1Management.Text = tt.TypeID
                txtAttributeValue2Management.Text = tt.TypeDescriptor
                txtAttributeValue3Management.Text = tt.MaxCapacity

            Case "Trains"
                Me.t = New Train(lstTableInfo1Management.SelectedItem)
                t.ReadTrain()
                txtAttributeValue1Management.Text = t.TrainID
                txtAttributeValue2Management.Text = t.tType.TypeID

            Case "Prices"
                Me.pr = New Price(Integer.Parse(lstTableInfo1Management.SelectedItem), Convert.ToDateTime(lstTableInfo2Management.SelectedItem))
                pr.ReadPrice()
                txtAttributeValue1Management.Text = pr.Product.ProductID
                txtAttributeValue2Management.Text = pr.PriceDate
                txtAttributeValue3Management.Text = pr.EurosPerTon

            Case "Products"
                Me.p = New Product(Integer.Parse(lstTableInfo1Management.SelectedItem))
                p.ReadProduct()
                txtAttributeValue1Management.Text = p.ProductID
                txtAttributeValue2Management.Text = p.ProductDescription

        End Select

    End Sub

    Private Sub lstTableInfo1Management_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTableInfo1Management.SelectedIndexChanged

        Select Case selection

            Case "Trips"
                Me.lstTableInfo2Management.SelectedIndex = Me.lstTableInfo1Management.SelectedIndex
                Me.lstTableInfo3Management.SelectedIndex = Me.lstTableInfo1Management.SelectedIndex

            Case "Prices"
                Me.lstTableInfo2Management.SelectedIndex = Me.lstTableInfo1Management.SelectedIndex

        End Select

    End Sub

    Private Sub lstTableInfo2Management_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTableInfo2Management.SelectedIndexChanged

        Select Case selection

            Case "Trips"
                Me.lstTableInfo1Management.SelectedIndex = Me.lstTableInfo2Management.SelectedIndex
                Me.lstTableInfo3Management.SelectedIndex = Me.lstTableInfo2Management.SelectedIndex

            Case "Prices"
                Me.lstTableInfo1Management.SelectedIndex = Me.lstTableInfo2Management.SelectedIndex

        End Select

    End Sub

    Private Sub lstTableInfo3Management_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTableInfo3Management.SelectedIndexChanged

        Select Case selection

            Case "Trips"
                Me.lstTableInfo1Management.SelectedIndex = Me.lstTableInfo3Management.SelectedIndex
                Me.lstTableInfo2Management.SelectedIndex = Me.lstTableInfo3Management.SelectedIndex

            Case "Prices"
                Me.lstTableInfo1Management.SelectedIndex = Me.lstTableInfo3Management.SelectedIndex

        End Select

    End Sub

    'AUXILIAR METHODS REALTED TO THE WINDOW 

    'Como Hacer que la ventana se mueva arrastrando con el raton
    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub frm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub frm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    'Como hacer los botones de Cerrar aplicacion y minimizar la ventana
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class