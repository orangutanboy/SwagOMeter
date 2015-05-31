﻿using System.Collections;

namespace PinballSwagOMeter
{
    public class WinnerTransformer : MatrixTransformer
    {
        private enum CurrentDisplay
        {
            Name,
            Blank
        }

        private CurrentDisplay _currentDisplay;

        protected override BitMatrix Transform()
        {
            InvocationCount++;
            switch (InvocationCount)
            {
                case 1:
                    SubsequentDelayMs = 200;
                    return FruitMachine1();
                case 2:
                    return FruitMachine2();
                case 3:
                    return FruitMachine3();
                case 4:
                    return FruitMachine4();
                case 5:
                    return FruitMachine5();
                case 6:
                    return FruitMachine6();
                case 7:
                    return FruitMachine7();
                case 8:
                    SubsequentDelayMs = 1000;
                    return FruitMachine8();
                default:
                    try
                    {
                        var bitmaps = CloneOriginals();
                        if (_currentDisplay == CurrentDisplay.Name)
                        {
                            for (var i = 0; i < 8; ++i)
                            {
                                bitmaps[i] = new BitArray(140);
                            }
                        }
                        return bitmaps;
                    }
                    finally
                    {
                        _currentDisplay = _currentDisplay == CurrentDisplay.Blank ? CurrentDisplay.Name : CurrentDisplay.Blank;
                    }
            }
        }

        protected override void Initialise(BitMatrix originals)
        {
            base.Initialise(originals);
            _currentDisplay = CurrentDisplay.Blank;
        }

        private static BitMatrix FruitMachine1()
        {
            return BitMatrixFactory.Create(
            new byte[140],
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 192, 31, 0, 128, 3, 0, 224, 0, 0, 224, 0, 56, 0, 48, 0, 28 },
            new byte[] { 28, 0, 248, 255, 0, 128, 3, 0, 224, 0, 0, 224, 0, 124, 0, 120, 0, 28 },
            new byte[] { 28, 0, 126, 240, 1, 128, 3, 0, 252, 7, 0, 224, 0, 62, 0, 248, 0, 28 },
            new byte[] { 28, 128, 15, 128, 7, 128, 3, 0, 14, 14, 0, 224, 0, 62, 0, 248, 0, 28 },
            new byte[] { 28, 192, 3, 0, 15, 128, 3, 0, 6, 28, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 224, 0, 0, 28, 128, 3, 0, 3, 24, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 96, 0, 0, 56, 128, 3, 0, 3, 24, 0, 224, 0, 25, 0, 32, 1, 28 },
            new byte[] { 28, 112, 0, 0, 112, 128, 3, 0, 3, 24, 0, 224, 128, 9, 0, 32, 3, 28 },
            new byte[] { 28, 56, 0, 0, 96, 128, 3, 0, 3, 24, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 28, 0, 0, 224, 128, 3, 0, 3, 24, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 14, 0, 0, 192, 129, 3, 0, 3, 16, 0, 224, 128, 12, 0, 32, 3, 28 },
            new byte[] { 28, 7, 0, 0, 128, 131, 3, 0, 1, 48, 0, 224, 128, 12, 0, 32, 3, 28 },
            new byte[] { 28, 7, 0, 0, 0, 135, 3, 128, 1, 48, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 14, 0, 0, 0, 135, 3, 128, 1, 48, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 28, 0, 0, 128, 131, 3, 128, 1, 96, 0, 224, 128, 9, 0, 48, 1, 28 },
            new byte[] { 28, 56, 0, 0, 224, 129, 3, 192, 0, 96, 0, 224, 0, 25, 0, 48, 1, 28 },
            new byte[] { 28, 48, 0, 0, 224, 128, 3, 192, 0, 192, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 112, 0, 0, 112, 128, 3, 96, 0, 192, 0, 224, 0, 63, 0, 248, 1, 28 },
            new byte[] { 28, 96, 0, 0, 56, 128, 3, 48, 0, 128, 1, 224, 0, 126, 0, 248, 0, 28 },
            new byte[] { 28, 224, 0, 0, 28, 128, 3, 56, 0, 0, 3, 224, 0, 254, 0, 254, 0, 28 },
            new byte[] { 28, 192, 1, 0, 14, 128, 3, 248, 255, 255, 7, 224, 0, 252, 1, 127, 0, 28 },
            new byte[] { 28, 128, 7, 128, 7, 128, 3, 248, 255, 255, 3, 224, 0, 248, 255, 63, 0, 28 },
            new byte[] { 28, 0, 31, 224, 3, 128, 3, 0, 248, 3, 0, 224, 0, 240, 255, 31, 0, 28 },
            new byte[] { 28, 0, 252, 255, 0, 128, 3, 0, 248, 2, 0, 224, 0, 224, 255, 15, 0, 28 },
            new byte[] { 28, 0, 240, 63, 0, 128, 3, 0, 240, 1, 0, 224, 0, 128, 255, 3, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 192, 0, 0, 224, 0, 0, 120, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[140]);
        }

        private static BitMatrix FruitMachine2()
        {
            return BitMatrixFactory.Create(
            new byte[140],
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 192, 31, 0, 128, 3, 0, 224, 0, 0, 224, 0, 56, 0, 48, 0, 28 },
            new byte[] { 28, 0, 248, 255, 0, 128, 3, 0, 224, 0, 0, 224, 0, 124, 0, 120, 0, 28 },
            new byte[] { 28, 0, 126, 240, 1, 128, 3, 0, 252, 7, 0, 224, 0, 62, 0, 248, 0, 28 },
            new byte[] { 28, 128, 15, 128, 7, 128, 3, 0, 14, 14, 0, 224, 0, 62, 0, 248, 0, 28 },
            new byte[] { 28, 192, 3, 0, 15, 128, 3, 0, 6, 28, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 224, 0, 0, 28, 128, 3, 0, 3, 24, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 96, 0, 0, 56, 128, 3, 0, 3, 24, 0, 224, 0, 25, 0, 32, 1, 28 },
            new byte[] { 28, 112, 0, 0, 112, 128, 3, 0, 3, 24, 0, 224, 128, 9, 0, 32, 3, 28 },
            new byte[] { 28, 56, 0, 0, 96, 128, 3, 0, 3, 24, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 28, 0, 0, 224, 128, 3, 0, 3, 24, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 14, 0, 0, 192, 129, 3, 0, 3, 16, 0, 224, 128, 12, 0, 32, 3, 28 },
            new byte[] { 28, 7, 0, 0, 128, 131, 3, 0, 1, 48, 0, 224, 128, 12, 0, 32, 3, 28 },
            new byte[] { 28, 7, 0, 0, 0, 135, 3, 128, 1, 48, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 14, 0, 0, 0, 135, 3, 128, 1, 48, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 28, 0, 0, 128, 131, 3, 128, 1, 96, 0, 224, 128, 9, 0, 48, 1, 28 },
            new byte[] { 28, 56, 0, 0, 224, 129, 3, 192, 0, 96, 0, 224, 0, 25, 0, 48, 1, 28 },
            new byte[] { 28, 48, 0, 0, 224, 128, 3, 192, 0, 192, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 112, 0, 0, 112, 128, 3, 96, 0, 192, 0, 224, 0, 63, 0, 248, 1, 28 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[140]);
        }

        private static BitMatrix FruitMachine3()
        {
            return BitMatrixFactory.Create(
            new byte[140],
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 192, 31, 0, 128, 3, 0, 224, 0, 0, 224, 0, 56, 0, 48, 0, 28 },
            new byte[] { 28, 0, 248, 255, 0, 128, 3, 0, 224, 0, 0, 224, 0, 124, 0, 120, 0, 28 },
            new byte[] { 28, 0, 126, 240, 1, 128, 3, 0, 252, 7, 0, 224, 0, 62, 0, 248, 0, 28 },
            new byte[] { 28, 128, 15, 128, 7, 128, 3, 0, 14, 14, 0, 224, 0, 62, 0, 248, 0, 28 },
            new byte[] { 28, 192, 3, 0, 15, 128, 3, 0, 6, 28, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 224, 0, 0, 28, 128, 3, 0, 3, 24, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 96, 0, 0, 56, 128, 3, 0, 3, 24, 0, 224, 0, 25, 0, 32, 1, 28 },
            new byte[] { 28, 112, 0, 0, 112, 128, 3, 0, 3, 24, 0, 224, 128, 9, 0, 32, 3, 28 },
            new byte[] { 28, 56, 0, 0, 96, 128, 3, 0, 3, 24, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 28, 0, 0, 224, 128, 3, 0, 3, 24, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 28, 14, 0, 0, 192, 129, 3, 0, 3, 16, 0, 224, 128, 12, 0, 32, 3, 28 },
            new byte[] { 28, 7, 0, 0, 128, 131, 3, 0, 1, 48, 0, 224, 128, 12, 0, 32, 3, 28 },
            new byte[] { 28, 7, 0, 0, 0, 135, 3, 128, 1, 48, 0, 224, 128, 15, 0, 224, 3, 28 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[140]);
        }

        private static BitMatrix FruitMachine4()
        {
            return BitMatrixFactory.Create(
            new byte[140],
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 28, 0, 127, 244, 31, 128, 3, 192, 31, 253, 7, 224, 0, 248, 163, 255, 0, 28 },
            new byte[] { 28, 0, 62, 252, 31, 128, 3, 128, 15, 255, 7, 224, 0, 240, 225, 255, 0, 28 },
            new byte[] { 28, 0, 0, 252, 31, 128, 3, 0, 0, 255, 7, 224, 0, 0, 224, 255, 0, 28 },
            new byte[] { 28, 0, 0, 248, 15, 128, 3, 0, 0, 254, 3, 224, 0, 0, 192, 127, 0, 28 },
            new byte[] { 28, 0, 0, 240, 7, 128, 3, 0, 0, 252, 1, 224, 0, 0, 128, 63, 0, 28 },
            new byte[] { 28, 0, 0, 224, 3, 128, 3, 0, 0, 248, 0, 224, 0, 0, 0, 31, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 192, 31, 0, 128, 3, 0, 224, 0, 0, 224, 0, 56, 0, 48, 0, 28 },
            new byte[] { 28, 0, 248, 255, 0, 128, 3, 0, 224, 0, 0, 224, 0, 124, 0, 120, 0, 28 },
            new byte[] { 28, 0, 126, 240, 1, 128, 3, 0, 252, 7, 0, 224, 0, 62, 0, 248, 0, 28 },
            new byte[] { 28, 128, 15, 128, 7, 128, 3, 0, 14, 14, 0, 224, 0, 62, 0, 248, 0, 28 },
            new byte[] { 28, 192, 3, 0, 15, 128, 3, 0, 6, 28, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 224, 0, 0, 28, 128, 3, 0, 3, 24, 0, 224, 0, 31, 0, 240, 1, 28 },
            new byte[] { 28, 96, 0, 0, 56, 128, 3, 0, 3, 24, 0, 224, 0, 25, 0, 32, 1, 28 },
            new byte[] { 28, 112, 0, 0, 112, 128, 3, 0, 3, 24, 0, 224, 128, 9, 0, 32, 3, 28 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[140]);
        }

        private static BitMatrix FruitMachine5()
        {
            return BitMatrixFactory.Create(
            new byte[140],
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 254, 255, 255, 255, 255, 191, 255, 255, 255, 255, 255, 247, 255, 255, 255, 31 },
            new byte[] { 28, 64, 255, 225, 3, 128, 3, 208, 127, 248, 0, 224, 0, 250, 15, 31, 0, 28 },
            new byte[] { 28, 64, 255, 49, 7, 128, 3, 208, 127, 204, 1, 224, 0, 250, 143, 57, 0, 28 },
            new byte[] { 28, 192, 255, 217, 15, 128, 3, 240, 127, 246, 3, 224, 0, 254, 207, 126, 0, 28 },
            new byte[] { 28, 192, 255, 237, 31, 128, 3, 240, 127, 251, 7, 224, 0, 254, 111, 255, 0, 28 },
            new byte[] { 28, 128, 255, 244, 31, 128, 3, 224, 63, 253, 7, 224, 0, 252, 167, 255, 0, 28 },
            new byte[] { 28, 0, 127, 244, 31, 128, 3, 192, 31, 253, 7, 224, 0, 248, 163, 255, 0, 28 },
            new byte[] { 28, 0, 62, 252, 31, 128, 3, 128, 15, 255, 7, 224, 0, 240, 225, 255, 0, 28 },
            new byte[] { 28, 0, 0, 252, 31, 128, 3, 0, 0, 255, 7, 224, 0, 0, 224, 255, 0, 28 },
            new byte[] { 28, 0, 0, 248, 15, 128, 3, 0, 0, 254, 3, 224, 0, 0, 192, 127, 0, 28 },
            new byte[] { 28, 0, 0, 240, 7, 128, 3, 0, 0, 252, 1, 224, 0, 0, 128, 63, 0, 28 },
            new byte[] { 28, 0, 0, 224, 3, 128, 3, 0, 0, 248, 0, 224, 0, 0, 0, 31, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 192, 31, 0, 128, 3, 0, 224, 0, 0, 224, 0, 56, 0, 48, 0, 28 },
            new byte[] { 28, 0, 248, 255, 0, 128, 3, 0, 224, 0, 0, 224, 0, 124, 0, 120, 0, 28 },
            new byte[] { 28, 0, 126, 240, 1, 128, 3, 0, 252, 7, 0, 224, 0, 62, 0, 248, 0, 28 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[140]);
        }

        private static BitMatrix FruitMachine6()
        {
            return BitMatrixFactory.Create(
            new byte[140],
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 28, 0, 64, 32, 0, 128, 3, 0, 16, 8, 0, 224, 0, 0, 2, 1, 0, 28 },
            new byte[] { 28, 0, 62, 96, 0, 128, 3, 128, 15, 24, 0, 224, 0, 240, 1, 3, 0, 28 },
            new byte[] { 28, 0, 115, 64, 0, 128, 3, 192, 28, 16, 0, 224, 0, 152, 3, 2, 0, 28 },
            new byte[] { 28, 128, 253, 192, 0, 128, 3, 96, 63, 48, 0, 224, 0, 236, 7, 6, 0, 28 },
            new byte[] { 28, 192, 254, 129, 0, 128, 3, 176, 127, 32, 0, 224, 0, 246, 15, 4, 0, 28 },
            new byte[] { 28, 64, 255, 225, 3, 128, 3, 208, 127, 248, 0, 224, 0, 250, 15, 31, 0, 28 },
            new byte[] { 28, 64, 255, 49, 7, 128, 3, 208, 127, 204, 1, 224, 0, 250, 143, 57, 0, 28 },
            new byte[] { 28, 192, 255, 217, 15, 128, 3, 240, 127, 246, 3, 224, 0, 254, 207, 126, 0, 28 },
            new byte[] { 28, 192, 255, 237, 31, 128, 3, 240, 127, 251, 7, 224, 0, 254, 111, 255, 0, 28 },
            new byte[] { 28, 128, 255, 244, 31, 128, 3, 224, 63, 253, 7, 224, 0, 252, 167, 255, 0, 28 },
            new byte[] { 28, 0, 127, 244, 31, 128, 3, 192, 31, 253, 7, 224, 0, 248, 163, 255, 0, 28 },
            new byte[] { 28, 0, 62, 252, 31, 128, 3, 128, 15, 255, 7, 224, 0, 240, 225, 255, 0, 28 },
            new byte[] { 28, 0, 0, 252, 31, 128, 3, 0, 0, 255, 7, 224, 0, 0, 224, 255, 0, 28 },
            new byte[] { 28, 0, 0, 248, 15, 128, 3, 0, 0, 254, 3, 224, 0, 0, 192, 127, 0, 28 },
            new byte[] { 28, 0, 0, 240, 7, 128, 3, 0, 0, 252, 1, 224, 0, 0, 128, 63, 0, 28 },
            new byte[] { 28, 0, 0, 224, 3, 128, 3, 0, 0, 248, 0, 224, 0, 0, 0, 31, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[140]);
        }

        private static BitMatrix FruitMachine7()
        {
            return BitMatrixFactory.Create(
            new byte[140],
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 28, 0, 0, 99, 0, 128, 3, 0, 192, 24, 0, 224, 0, 0, 24, 3, 0, 28 },
            new byte[] { 28, 0, 0, 33, 0, 128, 3, 0, 64, 8, 0, 224, 0, 0, 8, 1, 0, 28 },
            new byte[] { 28, 0, 0, 33, 0, 128, 3, 0, 64, 8, 0, 224, 0, 0, 8, 1, 0, 28 },
            new byte[] { 28, 0, 128, 33, 0, 128, 3, 0, 96, 8, 0, 224, 0, 0, 12, 1, 0, 28 },
            new byte[] { 28, 0, 192, 32, 0, 128, 3, 0, 48, 8, 0, 224, 0, 0, 6, 1, 0, 28 },
            new byte[] { 28, 0, 64, 32, 0, 128, 3, 0, 16, 8, 0, 224, 0, 0, 2, 1, 0, 28 },
            new byte[] { 28, 0, 64, 32, 0, 128, 3, 0, 16, 8, 0, 224, 0, 0, 2, 1, 0, 28 },
            new byte[] { 28, 0, 62, 96, 0, 128, 3, 128, 15, 24, 0, 224, 0, 240, 1, 3, 0, 28 },
            new byte[] { 28, 0, 115, 64, 0, 128, 3, 192, 28, 16, 0, 224, 0, 152, 3, 2, 0, 28 },
            new byte[] { 28, 128, 253, 192, 0, 128, 3, 96, 63, 48, 0, 224, 0, 236, 7, 6, 0, 28 },
            new byte[] { 28, 192, 254, 129, 0, 128, 3, 176, 127, 32, 0, 224, 0, 246, 15, 4, 0, 28 },
            new byte[] { 28, 64, 255, 225, 3, 128, 3, 208, 127, 248, 0, 224, 0, 250, 15, 31, 0, 28 },
            new byte[] { 28, 64, 255, 49, 7, 128, 3, 208, 127, 204, 1, 224, 0, 250, 143, 57, 0, 28 },
            new byte[] { 28, 192, 255, 217, 15, 128, 3, 240, 127, 246, 3, 224, 0, 254, 207, 126, 0, 28 },
            new byte[] { 28, 192, 255, 237, 31, 128, 3, 240, 127, 251, 7, 224, 0, 254, 111, 255, 0, 28 },
            new byte[] { 28, 128, 255, 244, 31, 128, 3, 224, 63, 253, 7, 224, 0, 252, 167, 255, 0, 28 },
            new byte[] { 28, 0, 127, 244, 31, 128, 3, 192, 31, 253, 7, 224, 0, 248, 163, 255, 0, 28 },
            new byte[] { 28, 0, 62, 252, 31, 128, 3, 128, 15, 255, 7, 224, 0, 240, 225, 255, 0, 28 },
            new byte[] { 28, 0, 0, 252, 31, 128, 3, 0, 0, 255, 7, 224, 0, 0, 224, 255, 0, 28 },
            new byte[] { 28, 0, 0, 248, 15, 128, 3, 0, 0, 254, 3, 224, 0, 0, 192, 127, 0, 28 },
            new byte[] { 28, 0, 0, 240, 7, 128, 3, 0, 0, 252, 1, 224, 0, 0, 128, 63, 0, 28 },
            new byte[] { 28, 0, 0, 224, 3, 128, 3, 0, 0, 248, 0, 224, 0, 0, 0, 31, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[140]);
        }

        private static BitMatrix FruitMachine8()
        {
            return BitMatrixFactory.Create(
            new byte[140],
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 28, 0, 0, 224, 7, 128, 3, 0, 0, 248, 1, 224, 0, 0, 0, 63, 0, 28 },
            new byte[] { 28, 0, 0, 248, 7, 128, 3, 0, 0, 254, 1, 224, 0, 0, 192, 63, 0, 28 },
            new byte[] { 28, 0, 0, 204, 0, 128, 3, 0, 0, 51, 0, 224, 0, 0, 96, 6, 0, 28 },
            new byte[] { 28, 0, 0, 70, 0, 128, 3, 0, 128, 17, 0, 224, 0, 0, 48, 2, 0, 28 },
            new byte[] { 28, 0, 0, 66, 0, 128, 3, 0, 128, 16, 0, 224, 0, 0, 16, 2, 0, 28 },
            new byte[] { 28, 0, 0, 99, 0, 128, 3, 0, 192, 24, 0, 224, 0, 0, 24, 3, 0, 28 },
            new byte[] { 28, 0, 0, 33, 0, 128, 3, 0, 64, 8, 0, 224, 0, 0, 8, 1, 0, 28 },
            new byte[] { 28, 0, 0, 33, 0, 128, 3, 0, 64, 8, 0, 224, 0, 0, 8, 1, 0, 28 },
            new byte[] { 28, 0, 128, 33, 0, 128, 3, 0, 96, 8, 0, 224, 0, 0, 12, 1, 0, 28 },
            new byte[] { 28, 0, 192, 32, 0, 128, 3, 0, 48, 8, 0, 224, 0, 0, 6, 1, 0, 28 },
            new byte[] { 28, 0, 64, 32, 0, 128, 3, 0, 16, 8, 0, 224, 0, 0, 2, 1, 0, 28 },
            new byte[] { 28, 0, 64, 32, 0, 128, 3, 0, 16, 8, 0, 224, 0, 0, 2, 1, 0, 28 },
            new byte[] { 28, 0, 62, 96, 0, 128, 3, 128, 15, 24, 0, 224, 0, 240, 1, 3, 0, 28 },
            new byte[] { 28, 0, 115, 64, 0, 128, 3, 192, 28, 16, 0, 224, 0, 152, 3, 2, 0, 28 },
            new byte[] { 28, 128, 253, 192, 0, 128, 3, 96, 63, 48, 0, 224, 0, 236, 7, 6, 0, 28 },
            new byte[] { 28, 192, 254, 129, 0, 128, 3, 176, 127, 32, 0, 224, 0, 246, 15, 4, 0, 28 },
            new byte[] { 28, 64, 255, 225, 3, 128, 3, 208, 127, 248, 0, 224, 0, 250, 15, 31, 0, 28 },
            new byte[] { 28, 64, 255, 49, 7, 128, 3, 208, 127, 204, 1, 224, 0, 250, 143, 57, 0, 28 },
            new byte[] { 28, 192, 255, 217, 15, 128, 3, 240, 127, 246, 3, 224, 0, 254, 207, 126, 0, 28 },
            new byte[] { 28, 192, 255, 237, 31, 128, 3, 240, 127, 251, 7, 224, 0, 254, 111, 255, 0, 28 },
            new byte[] { 28, 128, 255, 244, 31, 128, 3, 224, 63, 253, 7, 224, 0, 252, 167, 255, 0, 28 },
            new byte[] { 28, 0, 127, 244, 31, 128, 3, 192, 31, 253, 7, 224, 0, 248, 163, 255, 0, 28 },
            new byte[] { 28, 0, 62, 252, 31, 128, 3, 128, 15, 255, 7, 224, 0, 240, 225, 255, 0, 28 },
            new byte[] { 28, 0, 0, 252, 31, 128, 3, 0, 0, 255, 7, 224, 0, 0, 224, 255, 0, 28 },
            new byte[] { 28, 0, 0, 248, 15, 128, 3, 0, 0, 254, 3, 224, 0, 0, 192, 127, 0, 28 },
            new byte[] { 28, 0, 0, 240, 7, 128, 3, 0, 0, 252, 1, 224, 0, 0, 128, 63, 0, 28 },
            new byte[] { 28, 0, 0, 224, 3, 128, 3, 0, 0, 248, 0, 224, 0, 0, 0, 31, 0, 28 },
            new byte[] { 28, 0, 0, 0, 0, 128, 3, 0, 0, 0, 0, 224, 0, 0, 0, 0, 0, 28 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[] { 252, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 31 },
            new byte[140]);
        }
    }
}
