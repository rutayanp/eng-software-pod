Namespace SIL3.rLoop.rPodControl.Ethernet


    ''' <summary>
    ''' Pod control end points
    ''' </summary>
    Public Enum E_POD_CONTROL_POINTS
        POD_CTRL_PT__XILINX_SIM
        POD_CTRL_PT__FCU
        POD_CTRL_PT__FCU_SPACEX_DIAG
        POD_CTRL_PT__POWER_A
        POD_CTRL_PT__POWER_B
        POD_CTRL_PT__LGU
    End Enum


    ''' <summary>
    ''' Network packet defines
    ''' http://confluence.rloop.org/display/SD/Packet+Types
    ''' </summary>
    Public Enum E_NET__PACKET_T
        '/** null packet type */
        NET_PKT__NONE = &H0

        '//////////////////////////////////////////////////////
        '//FCU: GENERAL (&h0000)
        '//////////////////////////////////////////////////////

        '/** Pod stop command */
        NET_PKT__FCU_GEN__POD_STOP_COMMAND = &H1

        '/** Allow us to emulate pod sensor data */
        NET_PKT__FCU_GEN__POD_EMULATION_CONTROL = &H2

        '/** Switch on or off DAQ streaming */
        NET_PKT__FCU_GEN__DAQ_ENABLE = &HFE

        '/** Force a flush of the DAQ system */
        NET_PKT__FCU_GEN__DAQ_FLUSH = &HFF

        '/** Flight control data streaming */
        NET_PKT__FCU_GEN__STREAMING_CONTROL = &H100

        '//////////////////////////////////////////////////////
        '//FCU: ACCEL (&h1000)
        '//////////////////////////////////////////////////////

        '/** Request from the host to send the Acclelerometer calibration data */
        NET_PKT__FCU_ACCEL__REQUEST_CAL_DATA = &H1000

        '/** Transmit the accel calibration data to the host */
        NET_PKT__FCU_ACCEL__TX_CAL_DATA = &H1001

        '/** request a full data stream from our devices */
        NET_PKT__FCU_ACCEL__REQUEST_FULL_DATA = &H1002

        '/** Transmit the full available accel data to the host */
        NET_PKT__FCU_ACCEL__TX_FULL_DATA = &H1003

        '/** enter auto calibration mode */
        NET_PKT__FCU_ACCEL__AUTO_CALIBRATE = &H1004

        '/** Fine adjustment on Any */
        NET_PKT__FCU_ACCEL__FINE_ZERO_ADJUSTMENT = &H1005


        '//////////////////////////////////////////////////////
        '//FCU: LASER OPTONCDT(&h1100)
        '//////////////////////////////////////////////////////

        '/** Request from the host to send the laser data */
        NET_PKT__LASER_OPTO__REQUEST_LASER_DATA = &H1100

        '/** FCU to Host, return laser data */
        NET_PKT__LASER_OPTO__TX_LASER_DATA = &H1101



        '//////////////////////////////////////////////////////
        '//FCU: LASER DISTANCE(&h1200)
        '//////////////////////////////////////////////////////

        '/** Request from the host to send the laser data */
        NET_PKT__LASER_DIST__REQUEST_LASER_DATA = &H1200

        '/** FCU to Host, return laser data */
        NET_PKT__LASER_DIST__TX_LASER_DATA = &H1201



        '//////////////////////////////////////////////////////
        '//FCU: LASER CONTRAST(&h1300)
        '//////////////////////////////////////////////////////

        '/** Request from the host to send the laser data */
        NET_PKT__LASER_CONT__REQUEST_LASER_DATA = &H1300

        '/** FCU to Host, return laser data */
        NET_PKT__LASER_CONT__TX_LASER_DATA_0 = &H1301
        NET_PKT__LASER_CONT__TX_LASER_DATA_1 = &H1302
        NET_PKT__LASER_CONT__TX_LASER_DATA_2 = &H1303


        '//////////////////////////////////////////////////////
        '//FCU: BRAKES (&h1400)
        '//////////////////////////////////////////////////////

        '/** Permit brake development mode */
        NET_PKT__FCU_BRAKES__ENABLE_DEV_MODE = &H1400

        '/** Perform a raw motor move */
        NET_PKT__FCU_BRAKES__MOVE_MOTOR_RAW = &H1401


        '//////////////////////////////////////////////////////
        '//FCU: NAVIGATION (0x1600)
        '//////////////////////////////////////////////////////

        '/** Stream Navigation Progress Data */
        NET_PKT__FCU_BRAKES__TX_NAV_PROGRESS = &H1600

        '//////////////////////////////////////////////////////
        '//POWER: GENERAL (&h3000)
        '//////////////////////////////////////////////////////

        '/** Pod safe command */
        NET_PKT__PWR_GEN__POD_SAFE_COMMAND = &H3000

        '/** Allow us to emulate pod sensor data */
        NET_PKT__PWR_GEN__POD_EMULATION_CONTROL = &H3001

        '/** Power Node data streaming */
        NET_PKT__PWR_GEN__STREAMING_CONTROL = &H3010


        '//////////////////////////////////////////////////////
        '//POWER: TEMPERATURE SYSTEM(&h3200)
        '//////////////////////////////////////////////////////

        '/** Request a temperature packet */
        NET_PKT__PWR_TEMP__REQ_CURRENT_TEMPS = &H3200

        '/** Send an entire temperature sensor packet */
        NET_PKT__PWR_TEMP__TX_CURRENT_TEMPS = &H3201

        '/** Host wants sensor loc data */
        NET_PKT__PWR_TEMP__REQ_SENSOR_LOCATION = &H3202

        '/** Send the location data */
        NET_PKT__PWR_TEMP__TX_SENSOR_LOCATION_DATA = &H3203

        '/** Request a ROMID based on an index */
        NET_PKT__PWR_TEMP__REQ_ROMID_INDEX = &H3204

        '/** Send the ROMID based on an index */
        NET_PKT__PWR_TEMP__TX_ROMID_INDEX = &H3205

        '/** Set the ROMID by sensor index */
        NET_PKT__PWR_TEMP__SET_ROMID_INDEX = &H3206

        '/** Set the User Data by Sensor Index*/
        NET_PKT__PWR_TEMP__SET_USERDATA_INDEX = &H3207

        '//////////////////////////////////////////////////////
        '//DAQ (0x4000)
        '//////////////////////////////////////////////////////

        '/** Flight control DAQ offset */
        NET_PKT__FCU_DAQ__OFFSET_INDEX = &H4000

        '//////////////////////////////////////////////////////
        '//XILINX HYPERLOOP SIMULATION (&h5000)
        '//////////////////////////////////////////////////////

        '/** simulation control on the ML507 board */
        NET_PKT__XILINX_SIM__SIMULATION_CONTROL = &H5000

        '/** Allow us to manually change the state of the laser pin.
        '* Only works if the run Is stopped */
        NET_PKT__XILINX_SIM__MANUAL_LASER_CONTROL = &H5001

        '/** Transmit a progress update to the host */
        NET_PKT__XILINX_SIM__TX_PROGRESS_UPDATE = &H5002

    End Enum

End Namespace