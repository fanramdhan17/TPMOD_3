using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204038
{
    public class KodePos
    {
        enum State
        {
            START, GAME, PAUSE, EXIT,
            Batununggal, Kujangsari, Mengger, Wates,
            Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru,
            Maleer, Samoja
        };
        public void getKodePos()
        {
            State state = State.START;
            State kelurahan = State.START;
            string[] screenName = {"START", "GAME", "PAUSE", "EXIT", "40266", "40287",
            "40267", "40256", "40287", "40286", "40286", "40272", "40274", "40273"
        };

            while (state != State.EXIT)
            {
                Console.WriteLine("Ketik Nama Kelurahan");
                Console.Write("Kelurahan :");
                string command = Console.ReadLine();
                switch (state)
                {
                    case State.START:
                        if (command == "ENTER")
                        {
                            state = State.GAME;
                        }
                        else if (command == "QUIT")
                        {
                            state = State.EXIT;
                        }
                        else if (command == "Batununggal")
                        {
                            kelurahan = State.Batununggal;
                        }
                        else if (command == "Kujangsari")
                        {
                            kelurahan = State.Kujangsari;
                        }
                        else if (command == "Mengger")
                        {
                            kelurahan = State.Mengger;
                        }
                        else if (command == "Wates")
                        {
                            kelurahan = State.Wates;
                        }
                        else if (command == "Cijaura")
                        {
                            kelurahan = State.Cijaura;
                        }
                        else if (command == "Jatisari")
                        {
                            kelurahan = State.Jatisari;
                        }
                        else if (command == "Margasari")
                        {
                            kelurahan = State.Margasari;
                        }
                        else if (command == "Sekejati")
                        {
                            kelurahan = State.Sekejati;
                        }
                        else if (command == "Kebonwaru")
                        {
                            kelurahan = State.Kebonwaru;
                        }
                        else if (command == "Maleer")
                        {
                            kelurahan = State.Maleer;
                        }
                        else if (command == "Samoja")
                        {
                            kelurahan = State.Samoja;
                        }
                        else
                        {
                            state = State.START;
                            command = "QUIT";

                        }
                        break;
                }
                if (command != "QUIT")
                    Console.WriteLine("Kode Pos" + command + " : " + screenName[(int)kelurahan]);
            }
            Console.WriteLine("Exit Screen");
        }
    }
}

