
using EngineIO;

namespace Controllers
{
    public class WarehouseNTI : Controller
    {

        // Warehouse A
        MemoryBit loadrcA4 = MemoryMap.Instance.GetBit("Load RC A4", MemoryType.Output);
        MemoryBit unloadrcA5 = MemoryMap.Instance.GetBit("Unload RC A5", MemoryType.Output);
        MemoryInt targetPositionA = MemoryMap.Instance.GetInt("Target Position A", MemoryType.Output);
        MemoryBit forksLeftA = MemoryMap.Instance.GetBit("Forks Left A", MemoryType.Output);
        MemoryBit liftA = MemoryMap.Instance.GetBit("Lift A", MemoryType.Output);
        MemoryBit forksRightA = MemoryMap.Instance.GetBit("Forks Right A", MemoryType.Output);

        // Warehouse B
        MemoryBit loadrcB3 = MemoryMap.Instance.GetBit("Load RC B3", MemoryType.Output);
        MemoryBit unloadrcB4 = MemoryMap.Instance.GetBit("Unload RC B4", MemoryType.Output);
        MemoryInt targetPositionB = MemoryMap.Instance.GetInt("Target Position B", MemoryType.Output);
        MemoryBit forksLeftB = MemoryMap.Instance.GetBit("Forks Left B", MemoryType.Output);
        MemoryBit liftB = MemoryMap.Instance.GetBit("Lift B", MemoryType.Output);
        MemoryBit forksRightB = MemoryMap.Instance.GetBit("Forks Right B", MemoryType.Output);

        //Conveyors(RC)
        MemoryBit rc11 = MemoryMap.Instance.GetBit("RC (4m) 1.1", MemoryType.Output); // entryConveyor
        MemoryBit rc12 = MemoryMap.Instance.GetBit("RC (6m) 1.2", MemoryType.Output);
        MemoryBit rc13 = MemoryMap.Instance.GetBit("RC (2m) 1.3", MemoryType.Output);
        MemoryBit rc14 = MemoryMap.Instance.GetBit("RC (2m) 1.4", MemoryType.Output);
        MemoryBit rc15 = MemoryMap.Instance.GetBit("RC (6m) 1.5", MemoryType.Output);
        MemoryBit rc16 = MemoryMap.Instance.GetBit("RC (2m) 1.6", MemoryType.Output);
        MemoryBit rc17 = MemoryMap.Instance.GetBit("RC (4m) 1.7", MemoryType.Output);

        //Conveyors(A)
        MemoryBit rcA1 = MemoryMap.Instance.GetBit("RC A1", MemoryType.Output);
        MemoryBit rcA2 = MemoryMap.Instance.GetBit("Curved RC A2", MemoryType.Output);
        MemoryBit rcA3 = MemoryMap.Instance.GetBit("RC A3", MemoryType.Output);
        MemoryBit rcA6 = MemoryMap.Instance.GetBit("RC A6", MemoryType.Output);
        MemoryBit rcA7 = MemoryMap.Instance.GetBit("RC A7", MemoryType.Output);
        MemoryBit rcA8 = MemoryMap.Instance.GetBit("RC A8", MemoryType.Output);
        MemoryBit rcA9 = MemoryMap.Instance.GetBit("RC A9", MemoryType.Output);
        MemoryBit rcA10 = MemoryMap.Instance.GetBit("RC A10", MemoryType.Output);

        //Conveyors(B)
        MemoryBit rcB1 = MemoryMap.Instance.GetBit("RC B1", MemoryType.Output);
        MemoryBit rcB2 = MemoryMap.Instance.GetBit("RC B2", MemoryType.Output);
        MemoryBit rcB5 = MemoryMap.Instance.GetBit("RC B5", MemoryType.Output);
        MemoryBit rcB6 = MemoryMap.Instance.GetBit("Curved RC B6", MemoryType.Output);
        MemoryBit rcB7 = MemoryMap.Instance.GetBit("RC B7", MemoryType.Output);
        MemoryBit rcB8 = MemoryMap.Instance.GetBit("RC B8", MemoryType.Output);
        MemoryBit rcB9 = MemoryMap.Instance.GetBit("RC B9", MemoryType.Output);
        MemoryBit rcB10 = MemoryMap.Instance.GetBit("RC B10", MemoryType.Output);

        //ChainTransfers
        MemoryBit ct1p = MemoryMap.Instance.GetBit("CT 1 (+)", MemoryType.Output);
        MemoryBit ct1n = MemoryMap.Instance.GetBit("CT 1 (-)", MemoryType.Output);
        MemoryBit ct2p = MemoryMap.Instance.GetBit("CT 2 (+)", MemoryType.Output);
        MemoryBit ct2n = MemoryMap.Instance.GetBit("CT 2 (-)", MemoryType.Output);
        MemoryBit ct3p = MemoryMap.Instance.GetBit("CT 3 (+)", MemoryType.Output);
        MemoryBit ct3n = MemoryMap.Instance.GetBit("CT 3 (-)", MemoryType.Output);
        MemoryBit ct4p = MemoryMap.Instance.GetBit("CT 4 (+)", MemoryType.Output);
        MemoryBit ct4n = MemoryMap.Instance.GetBit("CT 4 (-)", MemoryType.Output);
        MemoryBit ct1Ap = MemoryMap.Instance.GetBit("CT 1A (+)", MemoryType.Output);
        MemoryBit ct1An = MemoryMap.Instance.GetBit("CT 1A (-)", MemoryType.Output);
        MemoryBit ct2Ap = MemoryMap.Instance.GetBit("CT 2A (+)", MemoryType.Output);
        MemoryBit ct2An = MemoryMap.Instance.GetBit("CT 2A (-)", MemoryType.Output);
        MemoryBit ct3Bp = MemoryMap.Instance.GetBit("CT 3B (+)", MemoryType.Output);
        MemoryBit ct3Bn = MemoryMap.Instance.GetBit("CT 3B (-)", MemoryType.Output);
        MemoryBit ct4Bp = MemoryMap.Instance.GetBit("CT 4B (+)", MemoryType.Output);
        MemoryBit ct4Bn = MemoryMap.Instance.GetBit("CT 4B (-)", MemoryType.Output);
        MemoryBit ctAp = MemoryMap.Instance.GetBit("CT A (+)", MemoryType.Output);
        MemoryBit ctAn = MemoryMap.Instance.GetBit("CT A (-)", MemoryType.Output);
        MemoryBit ctBp = MemoryMap.Instance.GetBit("CT B (+)", MemoryType.Output);
        MemoryBit ctBn = MemoryMap.Instance.GetBit("CT B (-)", MemoryType.Output);

        MemoryBit ct1L = MemoryMap.Instance.GetBit("CT 1 Left", MemoryType.Output);
        MemoryBit ct1R = MemoryMap.Instance.GetBit("CT 1 Right", MemoryType.Output);
        MemoryBit ct2L = MemoryMap.Instance.GetBit("CT 2 Left", MemoryType.Output);
        MemoryBit ct2R = MemoryMap.Instance.GetBit("CT 2 Right", MemoryType.Output);
        MemoryBit ct3L = MemoryMap.Instance.GetBit("CT 3 Left", MemoryType.Output);
        MemoryBit ct3R = MemoryMap.Instance.GetBit("CT 3 Right", MemoryType.Output);
        MemoryBit ct4L = MemoryMap.Instance.GetBit("CT 4 Left", MemoryType.Output);
        MemoryBit ct4R = MemoryMap.Instance.GetBit("CT 4 Right", MemoryType.Output);
        MemoryBit ct1AL = MemoryMap.Instance.GetBit("CT 1A Left", MemoryType.Output);
        MemoryBit ct1AR = MemoryMap.Instance.GetBit("CT 1A Right", MemoryType.Output);
        MemoryBit ct2AL = MemoryMap.Instance.GetBit("CT 2A Left", MemoryType.Output);
        MemoryBit ct2AR = MemoryMap.Instance.GetBit("CT 2A Right", MemoryType.Output);
        MemoryBit ct3BL = MemoryMap.Instance.GetBit("CT 3B Left", MemoryType.Output);
        MemoryBit ct3BR = MemoryMap.Instance.GetBit("CT 3B Right", MemoryType.Output);
        MemoryBit ct4BL = MemoryMap.Instance.GetBit("CT 4B Left", MemoryType.Output);
        MemoryBit ct4BR = MemoryMap.Instance.GetBit("CT 4B Right", MemoryType.Output);
        MemoryBit ctAL = MemoryMap.Instance.GetBit("CT A Left", MemoryType.Output);
        MemoryBit ctAR = MemoryMap.Instance.GetBit("CT A Right", MemoryType.Output);
        MemoryBit ctBL = MemoryMap.Instance.GetBit("CT B Left", MemoryType.Output);
        MemoryBit ctBR = MemoryMap.Instance.GetBit("CT B Right", MemoryType.Output);

        //Strop sensors
        MemoryBit rStop1 = MemoryMap.Instance.GetBit("StopR 1 Out", MemoryType.Input);
        MemoryBit rStop1A = MemoryMap.Instance.GetBit("StopR 1A In", MemoryType.Input);
        MemoryBit rStop2 = MemoryMap.Instance.GetBit("StopR 2 In", MemoryType.Input);
        MemoryBit rStop2Aout = MemoryMap.Instance.GetBit("StopR 2A Out", MemoryType.Input);
        MemoryBit rStop2AfromB = MemoryMap.Instance.GetBit("StopR 2A In from B", MemoryType.Input);
        MemoryBit rStop2AfromA = MemoryMap.Instance.GetBit("StopR 2A In from A", MemoryType.Input);
        MemoryBit rStopA = MemoryMap.Instance.GetBit("StopR A", MemoryType.Input);
        MemoryBit rStopB = MemoryMap.Instance.GetBit("StopR B", MemoryType.Input);
        MemoryBit rStop3in = MemoryMap.Instance.GetBit("StopR 3 In", MemoryType.Input);
        MemoryBit rStop3out = MemoryMap.Instance.GetBit("StopR 3 Out", MemoryType.Input);
        MemoryBit rStop3Bin = MemoryMap.Instance.GetBit("StopR 3B In", MemoryType.Input);
        MemoryBit rStop3BtoB = MemoryMap.Instance.GetBit("StopR 3B Out to B", MemoryType.Input);
        MemoryBit rStop3BtoA = MemoryMap.Instance.GetBit("StopR 3B Out to A", MemoryType.Input);
        MemoryBit rStop4B = MemoryMap.Instance.GetBit("StopR 4B", MemoryType.Input);

        // Storage A
        MemoryBit movingXA = MemoryMap.Instance.GetBit("Moving X A", MemoryType.Input);
        MemoryBit movingZA = MemoryMap.Instance.GetBit("Moving Z A", MemoryType.Input);
        MemoryBit atLoadA = MemoryMap.Instance.GetBit("At Load A", MemoryType.Input);
        MemoryBit atLeftA = MemoryMap.Instance.GetBit("At Left A", MemoryType.Input);
        MemoryBit atMiddleA = MemoryMap.Instance.GetBit("At Middle A", MemoryType.Input);
        MemoryBit atRightA = MemoryMap.Instance.GetBit("At Right A", MemoryType.Input);

        // Storage B
        MemoryBit movingXB = MemoryMap.Instance.GetBit("Moving X B", MemoryType.Input);
        MemoryBit movingZB = MemoryMap.Instance.GetBit("Moving Z B", MemoryType.Input);
        MemoryBit atLoadB = MemoryMap.Instance.GetBit("At Load B", MemoryType.Input);
        MemoryBit atLeftB = MemoryMap.Instance.GetBit("At Left B", MemoryType.Input);
        MemoryBit atMiddleB = MemoryMap.Instance.GetBit("At Middle B", MemoryType.Input);
        MemoryBit atRightB = MemoryMap.Instance.GetBit("At Right B", MemoryType.Input);

        // Capctive sensors 
        MemoryBit cs1 = MemoryMap.Instance.GetBit("CS 1", MemoryType.Input);
        MemoryBit cs2 = MemoryMap.Instance.GetBit("CS 2", MemoryType.Input);
        MemoryBit cs3 = MemoryMap.Instance.GetBit("CS 3", MemoryType.Input);
        MemoryBit cs4 = MemoryMap.Instance.GetBit("CS 4", MemoryType.Input);
        MemoryBit cs1A = MemoryMap.Instance.GetBit("CS 1A", MemoryType.Input);
        MemoryBit cs2A = MemoryMap.Instance.GetBit("CS 2A", MemoryType.Input);
        MemoryBit cs3B = MemoryMap.Instance.GetBit("CS 3B", MemoryType.Input);
        MemoryBit cs4B = MemoryMap.Instance.GetBit("CS 4B", MemoryType.Input);
        MemoryBit csA = MemoryMap.Instance.GetBit("CS A", MemoryType.Input);
        MemoryBit csB = MemoryMap.Instance.GetBit("CS B", MemoryType.Input);

        //Sensors
        MemoryBit rs1In = MemoryMap.Instance.GetBit("RS 1 In", MemoryType.Input);
        MemoryBit rs1Out = MemoryMap.Instance.GetBit("RS 1 Out", MemoryType.Input);
        MemoryBit rs1AIn = MemoryMap.Instance.GetBit("RS 1A In", MemoryType.Input);
        MemoryBit rs1AOut = MemoryMap.Instance.GetBit("RS 1A Out", MemoryType.Input);

        MemoryBit rs2In = MemoryMap.Instance.GetBit("RS 2 In", MemoryType.Input);
        MemoryBit rs2Out = MemoryMap.Instance.GetBit("RS 2 Out", MemoryType.Input);
        MemoryBit rs2AfromA = MemoryMap.Instance.GetBit("RS 2A In From A", MemoryType.Input);
        MemoryBit rs2AfromB = MemoryMap.Instance.GetBit("RS 2A In From B", MemoryType.Input);
        MemoryBit rs2AOut = MemoryMap.Instance.GetBit("RS 2A Out", MemoryType.Input);

        MemoryBit rs3In = MemoryMap.Instance.GetBit("RS 3 In", MemoryType.Input);
        MemoryBit rs3Out = MemoryMap.Instance.GetBit("RS 3 Out", MemoryType.Input);
        MemoryBit rs3AtoA = MemoryMap.Instance.GetBit("RS 3B Out to A", MemoryType.Input);
        MemoryBit rs3AtoB = MemoryMap.Instance.GetBit("RS 3B Out to B", MemoryType.Input);
        MemoryBit rs3BIn = MemoryMap.Instance.GetBit("RS 3B In", MemoryType.Input);

        MemoryBit rs4In = MemoryMap.Instance.GetBit("RS 4 In", MemoryType.Input);
        MemoryBit rs4Out = MemoryMap.Instance.GetBit("RS 4 Out", MemoryType.Input);
        MemoryBit rs4BIn = MemoryMap.Instance.GetBit("RS 4B In", MemoryType.Input);
        MemoryBit rs4BOut = MemoryMap.Instance.GetBit("RS 4B Out", MemoryType.Input);

        MemoryBit rsAIn = MemoryMap.Instance.GetBit("RS A In", MemoryType.Input);
        MemoryBit rsAOut = MemoryMap.Instance.GetBit("RS A Out", MemoryType.Input);
        MemoryBit rsAtoB = MemoryMap.Instance.GetBit("RS A Out to B", MemoryType.Input);
        MemoryBit rsBIn = MemoryMap.Instance.GetBit("RS B In", MemoryType.Input);
        MemoryBit rsBfromA = MemoryMap.Instance.GetBit("RS B In from A", MemoryType.Input);
        MemoryBit rsBOut = MemoryMap.Instance.GetBit("RS B Out", MemoryType.Input);

        //RFID Sensors
        MemoryInt rfidInCommand = MemoryMap.Instance.GetInt("RFID In Command", MemoryType.Output);
        MemoryBit rfidInExecuteCommand = MemoryMap.Instance.GetBit("RFID In Execute Command", MemoryType.Output);
        MemoryInt rfidInMemoryIndex = MemoryMap.Instance.GetInt("RFID In Memory Index", MemoryType.Output);
        MemoryInt rfidInWriteData = MemoryMap.Instance.GetInt("RFID In Write Data", MemoryType.Output);
        MemoryInt rfidInCommandID = MemoryMap.Instance.GetInt("RFID In Command ID", MemoryType.Input);
        MemoryInt rfidInStatus = MemoryMap.Instance.GetInt("RFID In Status", MemoryType.Input);
        MemoryInt rfidInReadData = MemoryMap.Instance.GetInt("RFID In Read Data", MemoryType.Input);

        MemoryInt rfid2Command = MemoryMap.Instance.GetInt("RFID 2 Command", MemoryType.Output);
        MemoryBit rfid2ExecuteCommand = MemoryMap.Instance.GetBit("RFID 2 Execute Command", MemoryType.Output);
        MemoryInt rfid2MemoryIndex = MemoryMap.Instance.GetInt("RFID 2 Memory Index", MemoryType.Output);
        MemoryInt rfid2WriteData = MemoryMap.Instance.GetInt("RFID 2 Write Data", MemoryType.Output);
        MemoryInt rfid2CommandID = MemoryMap.Instance.GetInt("RFID 2 Command ID", MemoryType.Input);
        MemoryInt rfid2Status = MemoryMap.Instance.GetInt("RFID 2 Status", MemoryType.Input);
        MemoryInt rfid2ReadData = MemoryMap.Instance.GetInt("RFID 2 Read Data", MemoryType.Input);

        MemoryInt rfidOutCommand = MemoryMap.Instance.GetInt("RFID Out Command", MemoryType.Output);
        MemoryBit rfidOutExecuteCommand = MemoryMap.Instance.GetBit("RFID Out Execute Command", MemoryType.Output);
        MemoryInt rfidOutMemoryIndex = MemoryMap.Instance.GetInt("RFID Out Memory Index", MemoryType.Output);
        MemoryInt rfidOutWriteData = MemoryMap.Instance.GetInt("RFID Out Write Data", MemoryType.Output);
        MemoryInt rfidOutCommandID = MemoryMap.Instance.GetInt("RFID Out Command ID", MemoryType.Input);
        MemoryInt rfidOutStatus = MemoryMap.Instance.GetInt("RFID Out Status", MemoryType.Input);
        MemoryInt rfidOutReadData = MemoryMap.Instance.GetInt("RFID Out Read Data", MemoryType.Input);

        MemoryInt rfidA1Command = MemoryMap.Instance.GetInt("RFID A1 Command", MemoryType.Output);
        MemoryBit rfidA1ExecuteCommand = MemoryMap.Instance.GetBit("RFID A1 Execute Command", MemoryType.Output);
        MemoryInt rfidA1MemoryIndex = MemoryMap.Instance.GetInt("RFID A1 Memory Index", MemoryType.Output);
        MemoryInt rfidA1WriteData = MemoryMap.Instance.GetInt("RFID A1 Write Data", MemoryType.Output);
        MemoryInt rfidA1CommandID = MemoryMap.Instance.GetInt("RFID A1 Command ID", MemoryType.Input);
        MemoryInt rfidA1Status = MemoryMap.Instance.GetInt("RFID A1 Status", MemoryType.Input);
        MemoryInt rfidA1ReadData = MemoryMap.Instance.GetInt("RFID A1 Read Data", MemoryType.Input);

        MemoryInt rfidA2Command = MemoryMap.Instance.GetInt("RFID A2 Command", MemoryType.Output);
        MemoryBit rfidA2ExecuteCommand = MemoryMap.Instance.GetBit("RFID A2 Execute Command", MemoryType.Output);
        MemoryInt rfidA2MemoryIndex = MemoryMap.Instance.GetInt("RFID A2 Memory Index", MemoryType.Output);
        MemoryInt rfidA2WriteData = MemoryMap.Instance.GetInt("RFID A2 Write Data", MemoryType.Output);
        MemoryInt rfidA2CommandID = MemoryMap.Instance.GetInt("RFID A2 Command ID", MemoryType.Input);
        MemoryInt rfidA2Status = MemoryMap.Instance.GetInt("RFID A2 Status", MemoryType.Input);
        MemoryInt rfidA2ReadData = MemoryMap.Instance.GetInt("RFID A2 Read Data", MemoryType.Input);

        MemoryInt rfidA3Command = MemoryMap.Instance.GetInt("RFID A3 Command", MemoryType.Output);
        MemoryBit rfidA3ExecuteCommand = MemoryMap.Instance.GetBit("RFID A3 Execute Command", MemoryType.Output);
        MemoryInt rfidA3MemoryIndex = MemoryMap.Instance.GetInt("RFID A3 Memory Index", MemoryType.Output);
        MemoryInt rfidA3WriteData = MemoryMap.Instance.GetInt("RFID A3 Write Data", MemoryType.Output);
        MemoryInt rfidA3CommandID = MemoryMap.Instance.GetInt("RFID A3 Command ID", MemoryType.Input);
        MemoryInt rfidA3Status = MemoryMap.Instance.GetInt("RFID A3 Status", MemoryType.Input);
        MemoryInt rfidA3ReadData = MemoryMap.Instance.GetInt("RFID A3 Read Data", MemoryType.Input);

        MemoryInt rfidA4Command = MemoryMap.Instance.GetInt("RFID A4 Command", MemoryType.Output);
        MemoryBit rfidA4ExecuteCommand = MemoryMap.Instance.GetBit("RFID A4 Execute Command", MemoryType.Output);
        MemoryInt rfidA4MemoryIndex = MemoryMap.Instance.GetInt("RFID A4 Memory Index", MemoryType.Output);
        MemoryInt rfidA4WriteData = MemoryMap.Instance.GetInt("RFID A4 Write Data", MemoryType.Output);
        MemoryInt rfidA4CommandID = MemoryMap.Instance.GetInt("RFID A4 Command ID", MemoryType.Input);
        MemoryInt rfidA4Status = MemoryMap.Instance.GetInt("RFID A4 Status", MemoryType.Input);
        MemoryInt rfidA4ReadData = MemoryMap.Instance.GetInt("RFID A4 Read Data", MemoryType.Input);

        MemoryInt rfidB1Command = MemoryMap.Instance.GetInt("RFID B1 Command", MemoryType.Output);
        MemoryBit rfidB1ExecuteCommand = MemoryMap.Instance.GetBit("RFID B1 Execute Command", MemoryType.Output);
        MemoryInt rfidB1MemoryIndex = MemoryMap.Instance.GetInt("RFID B1 Memory Index", MemoryType.Output);
        MemoryInt rfidB1WriteData = MemoryMap.Instance.GetInt("RFID B1 Write Data", MemoryType.Output);
        MemoryInt rfidB1CommandID = MemoryMap.Instance.GetInt("RFID B1 Command ID", MemoryType.Input);
        MemoryInt rfidB1Status = MemoryMap.Instance.GetInt("RFID B1 Status", MemoryType.Input);
        MemoryInt rfidB1ReadData = MemoryMap.Instance.GetInt("RFID B1 Read Data", MemoryType.Input);

        MemoryInt rfidB2Command = MemoryMap.Instance.GetInt("RFID B2 Command", MemoryType.Output);
        MemoryBit rfidB2ExecuteCommand = MemoryMap.Instance.GetBit("RFID B2 Execute Command", MemoryType.Output);
        MemoryInt rfidB2MemoryIndex = MemoryMap.Instance.GetInt("RFID B2 Memory Index", MemoryType.Output);
        MemoryInt rfidB2WriteData = MemoryMap.Instance.GetInt("RFID B2 Write Data", MemoryType.Output);
        MemoryInt rfidB2CommandID = MemoryMap.Instance.GetInt("RFID B2 Command ID", MemoryType.Input);
        MemoryInt rfidB2Status = MemoryMap.Instance.GetInt("RFID B2 Status", MemoryType.Input);
        MemoryInt rfidB2ReadData = MemoryMap.Instance.GetInt("RFID B2 Read Data", MemoryType.Input);

        MemoryInt rfidB3Command = MemoryMap.Instance.GetInt("RFID B3 Command", MemoryType.Output);
        MemoryBit rfidB3ExecuteCommand = MemoryMap.Instance.GetBit("RFID B3 Execute Command", MemoryType.Output);
        MemoryInt rfidB3MemoryIndex = MemoryMap.Instance.GetInt("RFID B3 Memory Index", MemoryType.Output);
        MemoryInt rfidB3WriteData = MemoryMap.Instance.GetInt("RFID B3 Write Data", MemoryType.Output);
        MemoryInt rfidB3CommandID = MemoryMap.Instance.GetInt("RFID B3 Command ID", MemoryType.Input);
        MemoryInt rfidB3Status = MemoryMap.Instance.GetInt("RFID B3 Status", MemoryType.Input);
        MemoryInt rfidB3ReadData = MemoryMap.Instance.GetInt("RFID B3 Read Data", MemoryType.Input);

        //My trsts tegs 
        //MemoryBit atExit = MemoryMap.Instance.GetBit("At exit", MemoryType.Input);
        // MemoryBit atEntry1 = MemoryMap.Instance.GetBit("At entry 1", MemoryType.Input);
       // MemoryBit load1 = MemoryMap.Instance.GetBit("Load 1", MemoryType.Output);
       // MemoryBit load2 = MemoryMap.Instance.GetBit("Load 2", MemoryType.Output);
        



        FTRIG ftMovXZ_A = new FTRIG();
        RTRIG rtAtLoad_A = new RTRIG();
        RTRIG rtAtLeft_A = new RTRIG();
        FTRIG ftMovZ_A = new FTRIG();
        RTRIG rtAtMiddle_A = new RTRIG();
        RTRIG rtAtRight_A = new RTRIG();

        FTRIG ftMovXZ_B = new FTRIG();
        RTRIG rtAtLoad_B = new RTRIG();
        RTRIG rtAtLeft_B = new RTRIG();
        FTRIG ftMovZ_B = new FTRIG();
        RTRIG rtAtMiddle_B = new RTRIG();
        RTRIG rtAtRight_B = new RTRIG();


        RTRIG rtAtEntry1 = new RTRIG();
        RTRIG rtAtEntry2 = new RTRIG();
        RTRIG rtAtExit = new RTRIG();
        FTRIG ftAtExit = new FTRIG();


        bool doTransfer1;
        bool doTransfer2;

        int currentPos = 0;

        State state = State.State0;
        State mngState = State.State0;
        State trfState1 = State.State0;
        State trfState2 = State.State0;
        
        public WarehouseNTI(){

           // loadrcA4 .Value = false;
            unloadrcA5.Value = false;
            targetPositionA.Value = 55;
            forksLeftA.Value = false;
            liftA.Value = false;
            forksRightA.Value = false;

            loadrcB3.Value = false;
            unloadrcB4.Value = false;
            targetPositionB.Value = 55;
            forksLeftB.Value = false;
            liftB.Value = false;
            forksRightB.Value = false;

            ct1L.Value = false;
            ct1AR.Value = false;
            ct1p.Value = false;


            rc11.Value = false;
            rc12.Value = false;
            rc13.Value = false;
            rc14.Value = false;
            rc15.Value = false;
            rc16.Value = false;
            rc17.Value = false;

            rcA1.Value = false;
            rcA2.Value = false;
            rcA3.Value = false;
            rcA6.Value = false;
            rcA7.Value = false;
            rcA8.Value = false;
            rcA9.Value = false;
            rcA10.Value = false;

            rcB1.Value = false;
            rcB2.Value = false;
            rcB5.Value = false;
            rcB6.Value = false;
            rcB7.Value = false;
            rcB8.Value = false;
            rcB9.Value = false;
            rcB10.Value = false;


        }

        public override void Execute(int elapsedMilliseconds){


            ftMovXZ_A.CLK(movingXA.Value || movingZA.Value);
            rtAtLoad_A.CLK(!atLoadA.Value);
            rtAtLeft_A.CLK(atLeftA.Value);
            ftMovZ_A.CLK(movingZA.Value);
            rtAtMiddle_A.CLK(atMiddleA.Value);
            rtAtRight_A.CLK(atRightA.Value);

            ftMovXZ_B.CLK(movingXB.Value || movingZB.Value);
            rtAtLoad_B.CLK(!atLoadB.Value);
            rtAtLeft_B.CLK(atLeftB.Value);
            ftMovZ_B.CLK(movingZB.Value);
            rtAtMiddle_B.CLK(atMiddleB.Value);
            rtAtRight_B.CLK(atRightB.Value);


            rtAtEntry1.CLK(!rs1In.Value);
            rtAtEntry2.CLK(cs1A.Value);
            rtAtExit.CLK(rs1Out.Value);
            ftAtExit.CLK(rs1AOut.Value);


               //Master controller
            if (mngState == State.State0)
            {
                if (rs1In.Value)
                    mngState = State.State1;
                else if (cs1A.Value)
                   mngState = State.State2;

            }
            else if (mngState == State.State1)
            {
                doTransfer1 = true;

                if (ftAtExit.Q)
                    mngState = State.State0;
            }
            else if (mngState == State.State2)
            {
                doTransfer2 = true;

                if (ftAtExit.Q)
                    mngState = State.State0;
            }

            //Transfer 1
            if (doTransfer1)
            {
                if (trfState1 == State.State0)
                {
                    ct1p.Value = false;

                    if (rs1In.Value)
                        trfState1 = State.State1;
                }
                else if (trfState1 == State.State1)
                {
                    ct1p.Value = true;

                    if (ftAtExit.Q)
                    {
                        doTransfer1 = false;
                        trfState1 = State.State0;
                    }
                }
            }

            //Transfer 2
            if (doTransfer2)
            {
                if (trfState2 == State.State0)
                {
                    ct1AR.Value = false;

                    // if (cs1A.Value)
                    //    trfState2 = State.State1;
                }
                else if (trfState2 == State.State1)
                {
                    ct1AR.Value = true;

                    if (cs1A.Value)
                        trfState2 = State.State2;
                }
                else if (trfState2 == State.State2)
                {
                    ct1AR.Value = false;

                    ct1L.Value = true;
                    ct1AR.Value = true;

                    if (cs1A.Value)
                        trfState2 = State.State3;
                }
                else if (trfState2 == State.State3)
                {
                    ct1L.Value = true;

                    ct1L.Value = false;
                    ct1AR.Value = false;

                    if (ftAtExit.Q)
                    {
                        doTransfer2 = false;
                        trfState2 = State.State0;
                    }
                }
            }

            rc11.Value = !rs1In.Value || (ct1L.Value && doTransfer1);
            //rc12.Value = !atEntry2.Value || ct1AR.Value;
            rcA1.Value = ct1AR.Value || ct1L.Value;
            rcA2.Value = ct1AR.Value || ct1L.Value;
            rcA3.Value = ct1AR.Value || ct1L.Value;
        }


    }


}
