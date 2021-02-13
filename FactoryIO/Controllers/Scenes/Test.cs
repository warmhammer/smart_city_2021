//-----------------------------------------------------------------------------
// FACTORY I/O (SDK)
//
// Copyright (C) Real Games. All rights reserved.
//-----------------------------------------------------------------------------

using EngineIO;
using System;

namespace Controllers
{
    public class Test : Controller
    {
        MemoryBit camera = MemoryMap.Instance.GetBit("Camera 1", MemoryType.Output);
        

        //MemoryBit movingX = MemoryMap.Instance.GetBit("Moving X", MemoryType.Input);
        
        FTRIG ftMovXZ = new FTRIG();
        RTRIG rtAtLoad = new RTRIG();
        RTRIG rtAtLeft = new RTRIG();
        FTRIG ftMovZ = new FTRIG();
        RTRIG rtAtMiddle = new RTRIG();
        RTRIG rtAtRight = new RTRIG();

        int currentPos = 0;

        State state = State.State0;

        public Test()
        {
            state = State.State1;

            Console.WriteLine(camera.Value);

        }

        public override void Execute(int elapsedMilliseconds)
        {
            /*
            ftMovXZ.CLK(movingX.Value || movingZ.Value);
            rtAtLoad.CLK(!atLoad.Value);
            rtAtLeft.CLK(atLeft.Value);
            ftMovZ.CLK(movingZ.Value);
            rtAtMiddle.CLK(atMiddle.Value);
            rtAtRight.CLK(atRight.Value);

            if (state == State.State0)
            {
                targetPosition.Value = 55;

                if (ftMovXZ.Q)
                    state = State.State1;
            }
            else if (state == State.State1)
            {
                //Waiting for load...

                if (!atLoad.Value)
                    state = State.State2;
            }
            else if (state == State.State2)
            {
                forksLeft.Value = true;

                if (rtAtLeft.Q)
                    state = State.State3;
            }
            else if (state == State.State3)
            {
                lift.Value = true;

                if (ftMovZ.Q)
                    state = State.State4;
            }
            else if (state == State.State4)
            {
                forksLeft.Value = false; //*

                if (rtAtMiddle.Q)
                    state = State.State5;
            }
            else if (state == State.State5)
            {
                targetPosition.Value = ++currentPos;

                state = State.State6;
            }
            else if (state == State.State6)
            {
                //Moving to destination...

                if (ftMovXZ.Q)
                    state = State.State7;
            }
            else if (state == State.State7)
            {
                forksRight.Value = true;

                if (rtAtRight.Q)
                    state = State.State8;
            }
            else if (state == State.State8)
            {
                lift.Value = false; //*

                if (ftMovZ.Q)
                    state = State.State9;
            }
            else if (state == State.State9)
            {
                forksRight.Value = false; //*

                if (rtAtMiddle.Q)
                    state = State.State0;
            }

            entryConveyor.Value = loadConveyor.Value = atLoad.Value;
            */
        }
    }
}
