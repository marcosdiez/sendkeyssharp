using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;
using System.Threading;

namespace SendKeysSharp
{
    class Typer
    {
        WindowsInput.IKeyboardSimulator keyboard;
        bool shiftIsDown = false;
        int sleepTime = 50;

        public Typer()
        {
            keyboard = new WindowsInput.InputSimulator().Keyboard;
        }


        private void ShiftDown()
        {
            if (!shiftIsDown)
            {
                keyboard.CITRIXKeyDown(VirtualKeyCode.SHIFT);
                Thread.Sleep(sleepTime);
                shiftIsDown = true;
            }
        }

        private void ShiftUp()
        {
            if (shiftIsDown)
            {
                keyboard.CITRIXKeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(sleepTime);
                shiftIsDown = false;
            }
        }

        public void CitrixTypeSentence(string msg)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                var c = msg[i];
                if (c >= '0' && c <= '9')
                {
                    ShiftUp();
                    keyboard.CITRIXKeyPress((VirtualKeyCode)c);
                    Thread.Sleep(sleepTime);
                    continue;
                }
                if ((c >= 'A' && c <= 'Z'))
                {
                    ShiftDown();
                    keyboard.CITRIXKeyPress((VirtualKeyCode)c);
                    Thread.Sleep(sleepTime);
                    continue;
                }
                if (c >= 'a' && c <= 'z')
                {
                    ShiftUp();
                    keyboard.CITRIXKeyPress((VirtualKeyCode)(c - 'a' + 'A'));
                    Thread.Sleep(sleepTime);
                    continue;
                }
                switch (c)
                {
                    case ' ':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.SPACE);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '\n':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.RETURN);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '\t':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.TAB);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '!':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_1);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '@':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_2);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '#':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_3);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '$':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_4);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '%':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_5);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '^':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_6);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '&':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_7);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '*':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_8);
                        Thread.Sleep(sleepTime);
                        continue;
                    case '(':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_9);
                        Thread.Sleep(sleepTime);
                        continue;
                    case ')':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.VK_0);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '-':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_MINUS);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '_':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_MINUS);
                        Thread.Sleep(sleepTime);
                        continue;


                    case '=':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_PLUS);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '+':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_PLUS);
                        Thread.Sleep(sleepTime);
                        continue;


                    case ',':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_COMMA);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '.':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_PERIOD);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '>':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_PERIOD);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '<':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_COMMA);
                        Thread.Sleep(sleepTime);
                        continue;


                    case '/':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_2);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '?':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_2);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '`':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_3);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '~':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_3);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '[':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_4);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '{':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_4);
                        Thread.Sleep(sleepTime);
                        continue;

                    case ']':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_6);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '}':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_6);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '\\':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_5);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '|':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_5);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '\'':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_7);
                        Thread.Sleep(sleepTime);
                        continue;

                    case '"':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_7);
                        Thread.Sleep(sleepTime);
                        continue;

                    case ';':
                        ShiftUp();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_1);
                        Thread.Sleep(sleepTime);
                        continue;

                    case ':':
                        ShiftDown();
                        keyboard.CITRIXKeyPress(VirtualKeyCode.OEM_1);
                        Thread.Sleep(sleepTime);
                        continue;

                    default:
                        continue;
                }
            }
            ShiftUp();
        }
    }
}
