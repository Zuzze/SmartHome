Partial Public Class SmartHomeForm

    Dim bedroomTemperature As String = "OFF"
    Dim bathTemperature As String = "OFF"
    Dim sofaTemperature As String = "OFF"
    Dim tvChannel As String = "MTV"
    Dim volume As String = "70 %"
    Dim washTemperature As String = "40 C"
    Dim dishProgramme As String = "Eco"
    Dim ovenTemperature As String = "225 C"
    Dim fridgeTemperature As String = "7 C"
    Dim freezerTemperature As String = "-5 C"
    Dim favoriteName As String = "Fav1"


    'BATHROOM
    Private Sub washingMachine_Click(sender As Object, e As EventArgs) Handles washingMachine.Click
        PopUpWindowPanel.Visible = True
        washWindow.Visible = True
        washCombobox.SelectedIndex = 0
    End Sub

    Private Sub washingMachine_Hover(sender As Object, e As EventArgs) Handles washingMachine.MouseHover
        washLbl.Visible = True
        If Not washingMachine.BackColor = Color.Black Then
            washLbl.Text = "Washing Machine" + Environment.NewLine + "Temperature: " + washTemperature + Environment.NewLine + "Time left: 2h 10min"
        Else
            washLbl.Text = "Washing Machine" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub washingMachine_Leave(sender As Object, e As EventArgs) Handles washingMachine.MouseLeave
        washLbl.Visible = False
    End Sub

    Private Sub washSave_Click(sender As Object, e As EventArgs) Handles WashSaveBtn.Click
        washingMachine.BackColor = Color.SkyBlue
        washTemperature = washCombobox.SelectedItem.ToString
        PopUpWindowPanel.Visible = False
        washWindow.Visible = False

    End Sub

    Private Sub washCancel_Click(sender As Object, e As EventArgs) Handles washCancelBtn.Click
        washWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub washOffBtn_Click(sender As Object, e As EventArgs) Handles washOffBtn.Click
        washingMachine.BackColor = Color.Black
        washWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub lightBath_Click(sender As Object, e As EventArgs) Handles lightBath.Click
        If lightBath.BackColor = Color.Black Then
            lightBath.BackColor = Color.SkyBlue
            bathLightLbl.Text = "Light" + Environment.NewLine + "ON"
        Else
            lightBath.BackColor = Color.Black
            bathLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub lightBath_Hover(sender As Object, e As EventArgs) Handles lightBath.MouseHover
        bathLightLbl.Visible = True
        If lightBath.BackColor = Color.Black Then
            bathLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        Else
            bathLightLbl.Text = "Light" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub lightBath_Leave(sender As Object, e As EventArgs) Handles lightBath.MouseLeave
        bathLightLbl.Visible = False
    End Sub

    'HALL
    Private Sub LightHall_Click(sender As Object, e As EventArgs) Handles LightHall.Click
        If LightHall.BackColor = Color.Black Then
            LightHall.BackColor = Color.SkyBlue
            hallLightLbl.Text = "Light" + Environment.NewLine + "ON"
        Else
            LightHall.BackColor = Color.Black
            hallLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub LightHall_Hover(sender As Object, e As EventArgs) Handles LightHall.MouseHover
        hallLightLbl.Visible = True
        If LightHall.BackColor = Color.Black Then
            hallLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        Else
            hallLightLbl.Text = "Light" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub LightHall_Leave(sender As Object, e As EventArgs) Handles LightHall.MouseLeave
        hallLightLbl.Visible = False
    End Sub


    Private Sub LockFrontDoor_Click(sender As Object, e As EventArgs) Handles LockFrontDoor.Click
        If LockFrontDoor.BackColor = Color.Black Then
            LockFrontDoor.BackColor = Color.SkyBlue
            frontLockLbl.Text = "Lock" + Environment.NewLine + "LOCKED"
        Else
            LockFrontDoor.BackColor = Color.Black
            frontLockLbl.Text = "Lock" + Environment.NewLine + "UNLOCKED"
        End If
    End Sub


    Private Sub LockFrontDoor_Hover(sender As Object, e As EventArgs) Handles LockFrontDoor.MouseHover
        frontLockLbl.Visible = True
        If Not LockFrontDoor.BackColor = Color.Black Then
            frontLockLbl.Text = "Lock" + Environment.NewLine + "LOCKED"
        Else
            frontLockLbl.Text = "Lock" + Environment.NewLine + "UNLOCKED"
        End If
    End Sub

    Private Sub LockFrontDoor_Leave(sender As Object, e As EventArgs) Handles LockFrontDoor.MouseLeave
        frontLockLbl.Visible = False
    End Sub

    Private Sub CamHall_Click(sender As Object, e As EventArgs) Handles CamHall.Click
        If CamHall.BackColor = Color.Black Then
            CamHall.BackColor = Color.SkyBlue
            hallCamLbl.Text = "Camera" + Environment.NewLine + "ON"
        Else
            CamHall.BackColor = Color.Black
            hallCamLbl.Text = "Camera" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub CamHall_Hover(sender As Object, e As EventArgs) Handles CamHall.MouseHover
        hallCamLbl.Visible = True
        If CamHall.BackColor = Color.Black Then
            hallCamLbl.Text = "Camera" + Environment.NewLine + "OFF"
        Else
            hallCamLbl.Text = "Camera" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub CamHall_Leave(sender As Object, e As EventArgs) Handles CamHall.MouseLeave
        hallCamLbl.Visible = False
    End Sub


    'BEDROOM
    Private Sub fireAlarmBed_Click(sender As Object, e As EventArgs) Handles fireAlarmBed.Click
        If fireAlarmBed.BackColor = Color.Black Then
            fireAlarmBed.BackColor = Color.SkyBlue
            bedAlarmLbl.Text = "Smoke Detector" + Environment.NewLine + "ON"
        Else
            fireAlarmBed.BackColor = Color.Black
            bedAlarmLbl.Text = "Smoke Detector" + Environment.NewLine + "OFF"
        End If
    End Sub


    Private Sub fireAlarmBed_Hover(sender As Object, e As EventArgs) Handles fireAlarmBed.MouseHover
        bedAlarmLbl.Visible = True
        If fireAlarmBed.BackColor = Color.Black Then
            bedAlarmLbl.Text = "Smoke Detector" + Environment.NewLine + "OFF"
        Else
            bedAlarmLbl.Text = "Smoke Detector" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub fireAlarmBed_Leave(sender As Object, e As EventArgs) Handles fireAlarmBed.MouseLeave
        bedAlarmLbl.Visible = False
    End Sub

    Private Sub LightBed2_Click(sender As Object, e As EventArgs) Handles lightBed2.Click
        If lightBed2.BackColor = Color.Black Then
            lightBed2.BackColor = Color.SkyBlue
            bedlight2Lbl.Text = "Light" + Environment.NewLine + "ON"
        Else
            lightBed2.BackColor = Color.Black
            bedlight2Lbl.Text = "Light" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub LightBed2_hover(sender As Object, e As EventArgs) Handles lightBed2.MouseHover
        bedlight2Lbl.Visible = True
        If lightBed2.BackColor = Color.Black Then
            bedlight2Lbl.Text = "Light" + Environment.NewLine + "OFF"
        Else
            bedlight2Lbl.Text = "Light" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub LightBed2_Leave(sender As Object, e As EventArgs) Handles lightBed2.MouseLeave
        bedlight2Lbl.Visible = False
    End Sub

    Private Sub LightBed1_Click(sender As Object, e As EventArgs) Handles LightBed1.Click
        If LightBed1.BackColor = Color.Black Then
            LightBed1.BackColor = Color.SkyBlue
            bedlight1Lbl.Text = "Light" + Environment.NewLine + "ON"
        Else
            LightBed1.BackColor = Color.Black
            bedlight1Lbl.Text = "Light" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub LightBed1_hover(sender As Object, e As EventArgs) Handles LightBed1.MouseHover
        bedlight1Lbl.Visible = True
        If LightBed1.BackColor = Color.Black Then
            bedlight1Lbl.Text = "Light" + Environment.NewLine + "OFF"
        Else
            bedlight1Lbl.Text = "Light" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub LightBed1_Leave(sender As Object, e As EventArgs) Handles LightBed1.MouseLeave
        bedlight1Lbl.Visible = False
    End Sub

    Private Sub airBed_Click(sender As Object, e As EventArgs)
        airWindow.Visible = True
        PopUpWindowPanel.Visible = True
        temperatureCombobox.SelectedItem = 1
    End Sub

    'Private Sub airBed_Hover(sender As Object, e As EventArgs)
    '    airBedLbl.Visible = True
    '    If Not airBed.BackColor = Color.Black Then
    '        airBedLbl.Text = bedroomTemperature
    '    Else
    '        airBedLbl.Text = "OFF"
    '    End If
    'End Sub

    'Private Sub airBed_Leave(sender As Object, e As EventArgs)
    '    airBedLbl.Visible = False
    'End Sub



    'SOFA AREA
    Private Sub fireAlarmSofa_Click(sender As Object, e As EventArgs) Handles fireAlarmSofa.Click
        If fireAlarmSofa.BackColor = Color.Black Then
            fireAlarmSofa.BackColor = Color.SkyBlue
            alarmSofaLbl.Text = "Smoke Detector" + Environment.NewLine + "ON"
        Else
            fireAlarmSofa.BackColor = Color.Black
            alarmSofaLbl.Text = "Smoke Detector" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub fireAlarmSofa_Hover(sender As Object, e As EventArgs) Handles fireAlarmSofa.MouseHover
        alarmSofaLbl.Visible = True
        If fireAlarmSofa.BackColor = Color.Black Then
            alarmSofaLbl.Text = "Smoke Detector" + Environment.NewLine + " OFF"
        Else
            alarmSofaLbl.Text = "Smoke Detector" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub fireAlarmSofa_Leave(sender As Object, e As EventArgs) Handles fireAlarmSofa.MouseLeave
        alarmSofaLbl.Visible = False
    End Sub

    Private Sub lightSofa_Click(sender As Object, e As EventArgs) Handles lightSofa.Click
        If lightSofa.BackColor = Color.Black Then
            lightSofa.BackColor = Color.SkyBlue
            sofaLightLbl.Text = "Light" + Environment.NewLine + "ON"
        Else
            lightSofa.BackColor = Color.Black
            sofaLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub lightSofa_Hover(sender As Object, e As EventArgs) Handles lightSofa.MouseHover
        sofaLightLbl.Visible = True
        If lightSofa.BackColor = Color.Black Then
            sofaLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        Else
            sofaLightLbl.Text = "Light" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub lightSofa_Leave(sender As Object, e As EventArgs) Handles lightSofa.MouseLeave
        sofaLightLbl.Visible = False
    End Sub


    Private Sub tv_Click(sender As Object, e As EventArgs) Handles tv.Click
        tvWindow.Visible = True
        PopUpWindowPanel.Visible = True
        TVComboBox.SelectedIndex = 0
        volumeBar.Value = 5
    End Sub

    Private Sub tv_Save(sender As Object, e As EventArgs) Handles tvSaveBtn.Click
        tvChannel = TVComboBox.SelectedItem.ToString
        volume = (volumeBar.Value * 10).ToString
        tvWindow.Visible = False
        PopUpWindowPanel.Visible = False
        tv.BackColor = Color.SkyBlue
    End Sub

    Private Sub tv_Cancel(sender As Object, e As EventArgs) Handles tvCancelBtn.Click
        tvWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub tv_off(sender As Object, e As EventArgs) Handles tvOffBtn.Click
        tv.BackColor = Color.Black
        tvWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub tv_Hover(sender As Object, e As EventArgs) Handles tv.MouseHover
        tvLbl.Visible = True
        If Not tv.BackColor = Color.Black Then
            tvLbl.Text = "TV" + Environment.NewLine + " Channel: " + tvChannel + Environment.NewLine + "Volume: " + volume + "%"
        Else
            tvLbl.Text = "TV" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub tv_Leave(sender As Object, e As EventArgs) Handles tv.MouseLeave
        tvLbl.Visible = False
    End Sub

    Private Sub camSofa_Click(sender As Object, e As EventArgs) Handles camSofa.Click
        If camSofa.BackColor = Color.Black Then
            camSofa.BackColor = Color.SkyBlue
            sofaCamLbl.Text = "Camera" + Environment.NewLine + "ON"
        Else
            camSofa.BackColor = Color.Black
            sofaCamLbl.Text = "Camera" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub camSofa_Hover(sender As Object, e As EventArgs) Handles camSofa.MouseHover
        sofaCamLbl.Visible = True
        If camSofa.BackColor = Color.Black Then
            sofaCamLbl.Text = "Camera" + Environment.NewLine + "OFF"
        Else
            sofaCamLbl.Text = "Camera" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub camSofa_leave(sender As Object, e As EventArgs) Handles camSofa.MouseLeave
        sofaCamLbl.Visible = False
    End Sub

    'KITCHEN
    Private Sub lightKitchen_Click(sender As Object, e As EventArgs) Handles lightKitchen.Click
        If lightKitchen.BackColor = Color.Black Then
            kitchenLightLbl.Text = "Light" + Environment.NewLine + "ON"
            lightKitchen.BackColor = Color.SkyBlue
        Else
            lightKitchen.BackColor = Color.Black
            kitchenLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub lightKitchen_Hover(sender As Object, e As EventArgs) Handles lightKitchen.MouseHover
        kitchenLightLbl.Visible = True
        If lightKitchen.BackColor = Color.Black Then
            kitchenLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        Else
            kitchenLightLbl.Text = "Light" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub lightKitchen_Leave(sender As Object, e As EventArgs) Handles lightKitchen.MouseLeave
        kitchenLightLbl.Visible = False
    End Sub

    Private Sub dishwasher_Click(sender As Object, e As EventArgs) Handles dishwasher.Click
        dishWindow.Visible = True
        PopUpWindowPanel.Visible = True
        dishCombobox.SelectedIndex = 0
    End Sub

    Private Sub dishCancelBtn_Click(sender As Object, e As EventArgs) Handles dishCancelBtn.Click
        dishWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub dishOffBtn_Click(sender As Object, e As EventArgs) Handles dishOffBtn.Click
        dishwasher.BackColor = Color.Black
        dishWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub dishSaveBtn_Click(sender As Object, e As EventArgs) Handles dishSaveBtn.Click
        dishWindow.Visible = False
        PopUpWindowPanel.Visible = False
        dishProgramme = dishCombobox.SelectedItem.ToString
        dishwasher.BackColor = Color.SkyBlue
    End Sub

    Private Sub dishwasher_Hover(sender As Object, e As EventArgs) Handles dishwasher.MouseHover
        dishLbl.Visible = True
        If Not dishwasher.BackColor = Color.Black Then
            dishLbl.Text = "Dishwasher" + Environment.NewLine + "Programme: " + dishProgramme + Environment.NewLine + "Time left: 1h 45min"
        Else
            dishLbl.Text = "Dishwasher" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub dishwasher_Leave(sender As Object, e As EventArgs) Handles dishwasher.MouseLeave
        dishLbl.Visible = False
    End Sub

    Private Sub oven_Click(sender As Object, e As EventArgs) Handles oven.Click
        ovenWindow.Visible = True
        PopUpWindowPanel.Visible = True
        ovenCombobox.SelectedIndex = 0
    End Sub

    Private Sub OvenCancelBtn_Click(sender As Object, e As EventArgs) Handles ovenCancelBtn.Click
        ovenWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub ovenOff(sender As Object, e As EventArgs) Handles ovenOffBtn.Click
        ovenWindow.Visible = False
        PopUpWindowPanel.Visible = False
        oven.BackColor = Color.Black
    End Sub

    Private Sub ovenSaveBtn_Click(sender As Object, e As EventArgs) Handles ovenSaveBtn.Click
        ovenWindow.Visible = False
        PopUpWindowPanel.Visible = False
        oven.BackColor = Color.SkyBlue
        ovenTemperature = ovenCombobox.SelectedItem.ToString
    End Sub

    Private Sub oven_Hover(sender As Object, e As EventArgs) Handles oven.MouseHover
        OvenLbl.Visible = True
        If Not oven.BackColor = Color.Black Then
            OvenLbl.Text = "Oven" + Environment.NewLine + "temperature: " + ovenTemperature
        Else
            OvenLbl.Text = "Oven" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub oven_Leave(sender As Object, e As EventArgs) Handles oven.MouseLeave
        OvenLbl.Visible = False
    End Sub

    Private Sub fridge_Click(sender As Object, e As EventArgs) Handles fridge.Click
        fridgeWindow.Visible = True
        PopUpWindowPanel.Visible = True
        freezerCombobox.SelectedIndex = 0
        fridgeCombobox.SelectedIndex = 0
    End Sub

    Private Sub fridgeCancelBtn_Click(sender As Object, e As EventArgs) Handles fridgeCancelBtn.Click
        PopUpWindowPanel.Visible = False
        fridgeWindow.Visible = False
    End Sub

    Private Sub fridgeOffBtn_Click(sender As Object, e As EventArgs) Handles fridgeOffBtn.Click
        PopUpWindowPanel.Visible = False
        fridgeWindow.Visible = False
        fridge.BackColor = Color.Black
    End Sub

    Private Sub fridgeSaveBtn_Click(sender As Object, e As EventArgs) Handles fridgeSaveBtn.Click
        freezerTemperature = freezerCombobox.SelectedItem.ToString
        fridgeTemperature = fridgeCombobox.SelectedItem.ToString
        PopUpWindowPanel.Visible = False
        fridgeWindow.Visible = False
        fridge.BackColor = Color.SkyBlue
    End Sub

    Private Sub fridge_Hover(sender As Object, e As EventArgs) Handles fridge.MouseHover
        fridgeLbl.Visible = True
        If Not fridge.BackColor = Color.Black Then
            fridgeLbl.Text = "Fridge " + fridgeTemperature + Environment.NewLine + "Freezer " + freezerTemperature
        Else
            fridgeLbl.Text = "Fridge/Freezer" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub fridge_Leave(sender As Object, e As EventArgs) Handles fridge.MouseLeave
        fridgeLbl.Visible = False
    End Sub

    Private Sub diningLight_Click(sender As Object, e As EventArgs) Handles diningLight.Click
        If diningLight.BackColor = Color.Black Then
            diningLight.BackColor = Color.SkyBlue
            diningLightLbl.Text = "Light" + Environment.NewLine + "ON"
        Else
            diningLight.BackColor = Color.Black
            diningLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub diningLight_Hover(sender As Object, e As EventArgs) Handles diningLight.MouseHover
        diningLightLbl.Visible = True
        If diningLight.BackColor = Color.Black Then
            diningLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        Else
            diningLightLbl.Text = "Light" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub diningLight_Leave(sender As Object, e As EventArgs) Handles diningLight.MouseLeave
        diningLightLbl.Visible = False
    End Sub

    Private Sub KitchenAir_Click(sender As Object, e As EventArgs) Handles kitchenAir.Click
        airWindow.Visible = True
        PopUpWindowPanel.Visible = True
        temperatureCombobox.SelectedIndex = 0
    End Sub

    Private Sub KitchenAir_Hover(sender As Object, e As EventArgs) Handles kitchenAir.MouseHover
        airKitchenLbl.Visible = True
        If kitchenAir.BackColor = Color.Black Then
            airKitchenLbl.Text = "Air Conditioner" + Environment.NewLine + "OFF"
        Else
            airKitchenLbl.Text = "Air Conditioner" + Environment.NewLine + sofaTemperature
        End If
    End Sub

    Private Sub KitchenAir_Leave(sender As Object, e As EventArgs) Handles kitchenAir.MouseLeave
        airKitchenLbl.Visible = False
    End Sub

    'OUTDOOR
    Private Sub outdoorLight_Click(sender As Object, e As EventArgs) Handles outdoorLight.Click
        If outdoorLight.BackColor = Color.Black Then
            outdoorLight.BackColor = Color.SkyBlue
            outLightLbl.Text = "Light" + Environment.NewLine + "ON"
        Else
            outdoorLight.BackColor = Color.Black
            outLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        End If
    End Sub

    Private Sub outdoorLight_Hover(sender As Object, e As EventArgs) Handles outdoorLight.MouseHover
        outLightLbl.Visible = True
        If outdoorLight.BackColor = Color.Black Then
            outLightLbl.Text = "Light" + Environment.NewLine + "OFF"
        Else
            outLightLbl.Text = "Light" + Environment.NewLine + "ON"
        End If
    End Sub

    Private Sub outdoorLight_Leave(sender As Object, e As EventArgs) Handles outdoorLight.MouseLeave
        outLightLbl.Visible = False
    End Sub


    Private Sub balconyLock_Click(sender As Object, e As EventArgs) Handles balconyLock.Click
        If balconyLock.BackColor = Color.Black Then
            balconyLock.BackColor = Color.SkyBlue
            balconyLockLbl.Text = "Lock" + Environment.NewLine + "LOCKED"
        Else
            balconyLock.BackColor = Color.Black
            balconyLockLbl.Text = "Lock" + Environment.NewLine + "UNLOCKED"
        End If

    End Sub

    Private Sub balconyLock_Hover(sender As Object, e As EventArgs) Handles balconyLock.MouseHover
        balconyLockLbl.Visible = True
        If balconyLock.BackColor = Color.Black Then
            balconyLockLbl.Text = "Lock" + Environment.NewLine + "UNLOCKED"
        Else
            balconyLockLbl.Text = "Lock " + Environment.NewLine + "LOCKED"
        End If
    End Sub

    Private Sub balconyLock_Leave(sender As Object, e As EventArgs) Handles balconyLock.MouseLeave
        balconyLockLbl.Visible = False
    End Sub

    Private Sub airBath_Click(sender As Object, e As EventArgs)
        airWindow.Visible = True
        PopUpWindowPanel.Visible = True
        temperatureCombobox.SelectedIndex = 0
    End Sub

    'Private Sub airBath_Hover(sender As Object, e As EventArgs)
    '    airBathLbl.Visible = True
    '    If Not airBath.BackColor = Color.Black Then
    '        airBathLbl.Text = bathTemperature
    '    Else
    '        airBathLbl.Text = "OFF"
    '    End If
    'End Sub

    'Private Sub airBath_mouseLeave(sender As Object, e As EventArgs)
    '    airBathLbl.Visible = False
    'End Sub


    Private Sub airCancelBtn_Click(sender As Object, e As EventArgs) Handles airCancelBtn.Click
        airWindow.Visible = False
        PopUpWindowPanel.Visible = False
        temperatureCombobox.SelectedIndex = 0
    End Sub

    Private Sub airSaveBtn_Click(sender As Object, e As EventArgs) Handles airSaveBtn.Click
        airWindow.Visible = False
        PopUpWindowPanel.Visible = False
        bathTemperature = temperatureCombobox.SelectedItem.ToString
        sofaTemperature = temperatureCombobox.SelectedItem.ToString
        bedroomTemperature = temperatureCombobox.SelectedItem.ToString
        'airBath.BackColor = Color.SkyBlue
        'airBed.BackColor = Color.SkyBlue
        kitchenAir.BackColor = Color.SkyBlue
    End Sub

    Private Sub Emergency_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to call help?", "Emergency", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MessageBox.Show("Alarm sent, wait for the authorities in a safe place", "Emergency", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub tempOffBtn_Click(sender As Object, e As EventArgs) Handles airOffBtn.Click
        airWindow.Visible = False
        PopUpWindowPanel.Visible = False
        bathTemperature = "OFF"
        sofaTemperature = "OFF"
        bedroomTemperature = "OFF"
        'airBath.BackColor = Color.Black
        'airBed.BackColor = Color.Black
        kitchenAir.BackColor = Color.Black
    End Sub


    'SETTINGS
    Private Sub settingsSaveBtn_Click(sender As Object, e As EventArgs) Handles settingsSaveBtn.Click
        PopUpWindowPanel.Visible = False
        settingsWindow.Visible = False
    End Sub

    Private Sub settingsCancelBtn_Click(sender As Object, e As EventArgs) Handles settingsCancelBtn.Click
        PopUpWindowPanel.Visible = False
        settingsWindow.Visible = False
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click, SettingsLabel.Click
        PopUpWindowPanel.Visible = True
        settingsWindow.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        StartWindow.Visible = False
    End Sub


    '========================================================
    '                       MODES
    '========================================================


    'AT HOME MODE
    Private Sub AtHomeMode(sender As Object, e As EventArgs) Handles homePanel.Click, homeLbl.Click, homePic.Click
        'hall
        CamHall.BackColor = Color.Black
        LightHall.BackColor = Color.SkyBlue
        LockFrontDoor.BackColor = Color.SkyBlue

        'bedroom
        LightBed1.BackColor = Color.Black
        lightBed2.BackColor = Color.SkyBlue
        bedroomTemperature = "21 C"
        'airBed.BackColor = Color.SkyBlue
        fireAlarmBed.BackColor = Color.SkyBlue

        'bathroom
        'airBath.BackColor = Color.SkyBlue
        bathTemperature = "22 C"
        washingMachine.BackColor = Color.Black
        lightBath.BackColor = Color.SkyBlue

        'kitchen living room
        dishwasher.BackColor = Color.Black
        oven.BackColor = Color.Black
        fridge.BackColor = Color.SkyBlue
        lightKitchen.BackColor = Color.SkyBlue
        diningLight.BackColor = Color.Black
        camSofa.BackColor = Color.Black
        lightSofa.BackColor = Color.SkyBlue
        fireAlarmSofa.BackColor = Color.SkyBlue
        tv.BackColor = Color.Black
        outdoorLight.BackColor = Color.SkyBlue
        balconyLock.BackColor = Color.Black
        kitchenAir.BackColor = Color.SkyBlue
        sofaTemperature = "24 C"
    End Sub

    Private Sub awayBtn_Click(sender As Object, e As EventArgs) Handles awayLbl.Click, awayPanel.Click, awayPic.Click
        'hall
        CamHall.BackColor = Color.SkyBlue
        LightHall.BackColor = Color.Black
        LockFrontDoor.BackColor = Color.SkyBlue

        'bedroom
        LightBed1.BackColor = Color.Black
        lightBed2.BackColor = Color.Black
        bedroomTemperature = "21 C"
        'airBed.BackColor = Color.SkyBlue
        fireAlarmBed.BackColor = Color.SkyBlue

        'bathroom
        'airBath.BackColor = Color.SkyBlue
        bathTemperature = "22 C"
        washingMachine.BackColor = Color.Black
        lightBath.BackColor = Color.Black

        'kitchen living room
        dishwasher.BackColor = Color.Black
        oven.BackColor = Color.Black
        fridge.BackColor = Color.SkyBlue
        lightKitchen.BackColor = Color.Black
        diningLight.BackColor = Color.Black
        camSofa.BackColor = Color.SkyBlue
        lightSofa.BackColor = Color.Black
        fireAlarmSofa.BackColor = Color.SkyBlue
        tv.BackColor = Color.Black
        outdoorLight.BackColor = Color.Black
        balconyLock.BackColor = Color.SkyBlue
        kitchenAir.BackColor = Color.SkyBlue
        sofaTemperature = "24 C"
    End Sub

    'EMERGENCY
    Private Sub Emergency_Click_1(sender As Object, e As EventArgs) Handles Emergency.Click
        If Emergency.Text = "EMERGENCY" Then
            EmergencyWindow.Visible = True
            PopUpWindowPanel.Visible = True
        Else
            EmergencyReverse.Visible = True
            PopUpWindowPanel.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EmergencyWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EmergencyConfirmationWindow.Visible = True
        EmergencyWindow.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmergencyConfirmationWindow.Visible = False
        PopUpWindowPanel.Visible = False
        EmergencyLbl.Visible = True
        Emergency.Text = "Reverse Alarm"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EmergencyReverse.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ReverseAlarmBtn.Click
        EmergencyLbl.Visible = False
        EmergencyReverse.Visible = False
        PopUpWindowPanel.Visible = False
        Emergency.Text = "EMERGENCY"
    End Sub

    Private Sub FavoriteIcon_Click(sender As Object, e As EventArgs) Handles FavoriteIcon.Click, favoritesLbl.Click
        PopUpWindowPanel.Visible = True
        addFavoriteWindow.Visible = True
    End Sub

    Private Sub saveFavBtn_Click(sender As Object, e As EventArgs) Handles saveFavBtn.Click
        addFavoriteWindow.Visible = False
        favConfWindow.Visible = True
        favPanelText.Text = FavNameTextbox.Text
        favoritePanel.Visible = True
    End Sub

    Private Sub favConfOKBtn_Click(sender As Object, e As EventArgs) Handles favConfOKbtn.Click
        favConfWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub cancelAddFavBtn_Click(sender As Object, e As EventArgs) Handles cancelAddFavBtn.Click
        addFavoriteWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub


    'ALARM
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SmokeAlarmWindow.Visible = True
        PopUpWindowPanel.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        SmokeAlarmWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SmokeAlarmWindow.Visible = False
        AlarmWindow.Visible = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AlarmWindow.Visible = False
        PopUpWindowPanel.Visible = False
    End Sub


    'TV MODE
    Private Sub tvModePic_Click(sender As Object, e As EventArgs) Handles tvModePic.Click, tvModePanel.Click, tvModeLbl.Click
        'hall
        CamHall.BackColor = Color.SkyBlue
        LightHall.BackColor = Color.Black
        LockFrontDoor.BackColor = Color.SkyBlue

        'bedroom
        LightBed1.BackColor = Color.Black
        lightBed2.BackColor = Color.Black
        bedroomTemperature = "21 C"
        'airBed.BackColor = Color.SkyBlue
        fireAlarmBed.BackColor = Color.SkyBlue

        'bathroom
        'airBath.BackColor = Color.SkyBlue
        bathTemperature = "22 C"
        washingMachine.BackColor = Color.Black
        lightBath.BackColor = Color.Black

        'kitchen living room
        dishwasher.BackColor = Color.Black
        oven.BackColor = Color.Black
        fridge.BackColor = Color.SkyBlue
        lightKitchen.BackColor = Color.Black
        diningLight.BackColor = Color.Black
        camSofa.BackColor = Color.Black
        lightSofa.BackColor = Color.Black
        fireAlarmSofa.BackColor = Color.SkyBlue
        tv.BackColor = Color.SkyBlue
        outdoorLight.BackColor = Color.Black
        balconyLock.BackColor = Color.SkyBlue
        kitchenAir.BackColor = Color.SkyBlue
        sofaTemperature = "24 C"
    End Sub

    Private Sub sleepModePic_Click(sender As Object, e As EventArgs) Handles sleepModePic.Click, sleepModeLbl.Click, sleepModePanel.Click
        'hall
        CamHall.BackColor = Color.Black
        LightHall.BackColor = Color.Black
        LockFrontDoor.BackColor = Color.SkyBlue

        'bedroom
        LightBed1.BackColor = Color.Black
        lightBed2.BackColor = Color.Black
        bedroomTemperature = "21 C"
        'airBed.BackColor = Color.SkyBlue
        fireAlarmBed.BackColor = Color.SkyBlue

        'bathroom
        'airBath.BackColor = Color.SkyBlue
        bathTemperature = "22 C"
        washingMachine.BackColor = Color.Black
        lightBath.BackColor = Color.Black

        'kitchen living room
        dishwasher.BackColor = Color.Black
        oven.BackColor = Color.Black
        fridge.BackColor = Color.SkyBlue
        lightKitchen.BackColor = Color.Black
        diningLight.BackColor = Color.Black
        camSofa.BackColor = Color.SkyBlue
        lightSofa.BackColor = Color.Black
        fireAlarmSofa.BackColor = Color.SkyBlue
        tv.BackColor = Color.Black
        outdoorLight.BackColor = Color.SkyBlue
        balconyLock.BackColor = Color.SkyBlue
        kitchenAir.BackColor = Color.SkyBlue
        sofaTemperature = "24 C"
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        HelpPanel.Visible = True
    End Sub

    Private Sub HelpOKBtn_Click(sender As Object, e As EventArgs) Handles HelpOKBtn.Click
        HelpPanel.Visible = False
    End Sub
End Class

